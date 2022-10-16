using InventoryManager2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager2022.Forms
{
    public partial class formQLHang : Form
    {
        public formQLHang()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            nhapHangHoasBindingSource.Filter = "TenHang LIKE '%" + tb_tenhangtim.Text + "%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_tenhanghoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_soluongnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nhacungcap_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_sotien_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
            this.nhapHangHoasTableAdapter.Fill(this.iM22DataSet.NhapHangHoas);
            using (HangHoaModelContext db = new HangHoaModelContext())
            {
                nhapHangHoasBindingSource.DataSource = db.Emplist.ToList();
            }
            gb_ThongTin.Enabled = false;
            //panel1.Enabled = false;
            btn_add.Enabled = true;
            btn_remove.Enabled = false;
            btn_save.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            gb_ThongTin.Enabled = false;
            //panel1.Enabled = false;
            btn_add.Enabled = true;
            btn_remove.Enabled = false;
            btn_save.Enabled = false;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dòng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (HangHoaModelContext db = new HangHoaModelContext())
                {
                    NhapHangHoa obj = nhapHangHoasBindingSource.Current as NhapHangHoa;
                    if (obj != null)
                    {
                        if (db.Entry<NhapHangHoa>(obj).State ==
                        System.Data.Entity.EntityState.Detached)
                        {
                            db.Set<NhapHangHoa>().Attach(obj);
                        }
                        db.Entry<NhapHangHoa>(obj).State =
                        System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show(this, "Xóa thành công");
                        nhapHangHoasBindingSource.RemoveCurrent();

                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (HangHoaModelContext db = new HangHoaModelContext())
            {
                NhapHangHoa obj = nhapHangHoasBindingSource.Current as NhapHangHoa;
                if (obj != null)
                {
                    if (db.Entry<NhapHangHoa>(obj).State ==
                    System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<NhapHangHoa>().Attach(obj);
                    }

                    if (obj.id == 0)
                    {

                        db.Entry<NhapHangHoa>(obj).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {

                        db.Entry<NhapHangHoa>(obj).State =
                        System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();
                    MessageBox.Show(this, "Lưu thành công");

                    dataGridView1.Refresh();
                    btn_add.Enabled = true;
                    btn_remove.Enabled = true;
                    btn_save.Enabled = false;
                    gb_ThongTin.Enabled = false;

                }
            }
        }
    }
}
