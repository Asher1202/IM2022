using InventoryManager2022.Classes;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace InventoryManager2022.Forms
{
    public partial class formThanhToan : Form
    {
        public static string ttOrderID;
        public static int ttOrderIDD;
        public formThanhToan()
        {
            InitializeComponent();
            
        }
        //methods

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            using (HangHoaModelContext db = new HangHoaModelContext())
            {
                //nhapHangHoasBindingSource.DataSource = db.Emplist.ToList();
                inHoaDon obj = inHoaDonsBindingSource.Current as inHoaDon;
                if (obj != null)
                {
                    if (db.Entry<inHoaDon>(obj).State ==
                    System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<inHoaDon>().Attach(obj);
                    }

                    if (obj.staticid == 0)
                    {

                        db.Entry<inHoaDon>(obj).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {

                        db.Entry<inHoaDon>(obj).State =
                        System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();
                    formMainMenu fmm = new formMainMenu();
                    fmm.OpenChildForm(new formThongKe());
                    DialogResult dialogResult = MessageBox.Show("Lưu thành công bạn có muốn xuất hóa đơn?", "Thông báo", MessageBoxButtons.YesNo);
                    this.Hide();
                    if (dialogResult == DialogResult.Yes)
                    {
                        formThanhToan.ttOrderIDD = obj.orderID;
                        formPrintInvoice fpiv = new formPrintInvoice();
                        fpiv.Show();
                        MessageBox.Show("Lưu thành công bạn sẽ trở về trang chính", "Thông báo", MessageBoxButtons.YesNo);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Lưu thành công bạn sẽ trở về trang chính", "Thông báo", MessageBoxButtons.YesNo);

                    }
                    

                    dataGridView1.Refresh();
                }

            }
        }
        private void formKhachHang_Load(object sender, EventArgs e)
        {

            
            using (HangHoaModelContext db = new HangHoaModelContext())
            {
                inHoaDonsBindingSource.DataSource = db.inHoaDonInfos.ToList();
            }
            inHoaDonsBindingSource.Add(new inHoaDon());
            inHoaDonsBindingSource.MoveLast();


            // TODO: This line of code loads data into the 'iM22DataSet.inHoaDons' table. You can move, or remove it, as needed.
            this.inHoaDonsTableAdapter.Fill(this.iM22DataSet.inHoaDons);
            tb_sphammua.Text = formBanHang.ttTenKhach;
            tb_loaihangmua.Text = formBanHang.TTLoaiHang;
            dateTimePicker1.Value = DateTime.Now;
            inHoaDonsBindingSource.EndEdit();
            //dateTimePicker1.Text = DateTime.Now.ToLongDateString();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = tb_tongtien.Text.Replace(",", "")
                .Replace("VND", "").Replace(".", "").TrimStart('0');
            decimal ul;
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                tb_tongtien.TextChanged -= textBox1_TextChanged;
                tb_tongtien.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:C}", ul);
                tb_tongtien.TextChanged += textBox1_TextChanged;
                tb_tongtien.Select(tb_tongtien.Text.Length, 0);

            }
            if (tb_tongtien.Text != null)
            {
                tb_tongtien.Text = tb_tongtien.Text;
            }
        }
        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }
        private void tb_soluongmua_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            tb_tongtien.Text = (int.Parse(tb_slmua.Text) * int.Parse(formBanHang.ttGiaBan)).ToString();
            inHoaDonsBindingSource.EndEdit();
/*            if (int.Parse(formBanHang.ttSoLuong) - int.Parse(tb_slmua.Text) < 1)
            {
                MessageBox.Show("Khách hàng không thể mua hàng với số lượng này");
                return;
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_slmua_Validated(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
