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
using System.Xml.Linq;

namespace InventoryManager2022.Forms
{
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
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
                    btn_remove.Enabled = true;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhapHangHoasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_sdt_Click(object sender, EventArgs e)
        {

        }

        private void lb_namsinh_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gb_ThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_email_Click(object sender, EventArgs e)
        {

        }

        private void cb_loaihanghoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_soluongnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_tenhanghoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_chucvu_Click(object sender, EventArgs e)
        {

        }

        private void lb_tennhanvien_Click(object sender, EventArgs e)
        {

        }

        private void lb_manv_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienInfoesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void iM22DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
