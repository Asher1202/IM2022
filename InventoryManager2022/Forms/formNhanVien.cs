using InventoryManager2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManager2022.Forms
{
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
        }
        //method
        public bool CheckEmail(string em) //hàm regex check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void formNhanVien_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'iM22DataSet.NhanVienInfoes' table. You can move, or remove it, as needed.
            this.nhanVienInfoesTableAdapter.Fill(this.iM22DataSet.NhanVienInfoes);
            using (HangHoaModelContext db = new HangHoaModelContext())
            {
                nhanVienInfoesBindingSource.DataSource = db.nhanVienInfos.ToList();
            }
            gb_ThongTin.Enabled = false;
            panel1.Enabled = true;
            //panel1.Enabled = false;
            btn_add.Enabled = true;
            btn_remove.Enabled = false;
            btn_save.Enabled = false;


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            gb_ThongTin.Enabled = true;
            btn_remove.Enabled = false;
            btn_save.Enabled = true;
            nhanVienInfoesBindingSource.Add(new NhanVienInfo());
            nhanVienInfoesBindingSource.MoveLast();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (HangHoaModelContext db = new HangHoaModelContext())
            {
                NhanVienInfo obj = nhanVienInfoesBindingSource.Current as NhanVienInfo;
                if (obj != null)
                {
                    if (db.Entry<NhanVienInfo>(obj).State ==
                    System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<NhanVienInfo>().Attach(obj);
                    }

                    if (obj.id == 0)
                    {

                        db.Entry<NhanVienInfo>(obj).State =
                        System.Data.Entity.EntityState.Added;
                    }
                    else
                    {

                        db.Entry<NhanVienInfo>(obj).State =
                        System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();
                    MessageBox.Show(this, "Lưu thành công");

                    dataGridView1.Refresh();
                    btn_add.Enabled = true;
                    btn_remove.Enabled = false;
                    btn_save.Enabled = false;
                    gb_ThongTin.Enabled = false;

                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dòng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (HangHoaModelContext db = new HangHoaModelContext())
                {
                    NhanVienInfo obj = nhanVienInfoesBindingSource.Current as NhanVienInfo;
                    if (obj != null)
                    {
                        if (db.Entry<NhanVienInfo>(obj).State ==
                        System.Data.Entity.EntityState.Detached)
                        {
                            db.Set<NhanVienInfo>().Attach(obj);
                        }
                        db.Entry<NhanVienInfo>(obj).State =
                        System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show(this, "Xóa thành công");
                        nhanVienInfoesBindingSource.RemoveCurrent();

                    }
                }
            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            gb_ThongTin.Enabled = true;
            btn_remove.Enabled = false;
            btn_save.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            if (!CheckEmail(email)) { MessageBox.Show("Định dạng email không đúng! Vui lòng nhập lại!"); return; }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_remove.Enabled = true;
        }
    }
}
