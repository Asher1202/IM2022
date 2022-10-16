using InventoryManager2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager2022.Forms
{
    public partial class formBanHang : Form
    {
        public static string ttSoLuong;
        public static string ttGiaBan;
        public static string ttTenKhach;
        public static string TTLoaiHang;
        public formBanHang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iM22DataSet1.NhapHangHoas' table. You can move, or remove it, as needed.
            this.nhapHangHoasTableAdapter.Fill(this.iM22DataSet.NhapHangHoas);

            //this.reportViewer1.RefreshReport();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow row = new DataGridViewRow();
        //    row = dataGridView1.Rows[e.RowIndex];
        //    ttSoLuong = row.Cells[1].ToString();
        //    ttGiaBan = row.Cells[6].ToString();
        //    MessageBox.Show("b" + ttSoLuong + ttGiaBan);
        //}

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //this.nhapHangHoasTableAdapter.searchID(this.iM22DataSet.NhapHangHoas, tb_tenhang.Text);
            nhapHangHoasBindingSource.Filter = "TenHang LIKE '%" + tb_tenhang.Text + "%'";
        }

        public void iconButton2_Click(object sender, EventArgs e)
        {
            if (formBanHang.ttSoLuong == null)
            {
                MessageBox.Show("Bạn chưa chọn món hàng nào để thanh toán, vui lòng chọn");
                return;
            }
            formThanhToan f2 = new formThanhToan();
                
            f2.ShowDialog();
            this.Close();
            

        }

        private void tb_tongtien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_soluongton_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            ttTenKhach = row.Cells[0].Value.ToString();
            ttSoLuong = row.Cells[1].Value.ToString();
            TTLoaiHang = row.Cells[3].Value.ToString();
            ttGiaBan = row.Cells[5].Value.ToString();

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhanVienInfoesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void iM22DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void nhapHangHoasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_loaihang_Click(object sender, EventArgs e)
        {

        }

        private void tb_giaban_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nhapHangHoasBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
