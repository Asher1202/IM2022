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
    public partial class formHangHoa : Form
    {
        public formHangHoa()
        {
            InitializeComponent();
        }

        private void formHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iM22DataSet.NhapHangHoas' table. You can move, or remove it, as needed.
            this.nhapHangHoasTableAdapter.Fill(this.iM22DataSet.NhapHangHoas);
            /*sing (HangHoaModelContext db = new HangHoaModelContext()) 
            {
                nhapHangHoasBindingSource.DataSource = db.Emplist.ToList();
            }*/
            gb_ThongTin.Enabled = false;
            //panel1.Enabled = false;
            btn_add.Enabled = true;
            btn_remove.Enabled = false;
            btn_save.Enabled = false;
            btn_timkiem.Enabled = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            nhapHangHoasBindingSource.Filter = "TenHang LIKE '%" + tb_tenhangtim.Text + "%'";         
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            using(HangHoaModelContext db = new HangHoaModelContext())
            {
                nhapHangHoasBindingSource.DataSource = db.Emplist.ToList();
            }
            gb_ThongTin.Enabled = true;
            nhapHangHoasBindingSource.Add(new NhapHangHoa());
            nhapHangHoasBindingSource.MoveLast();
            btn_save.Enabled = true;
            btn_timkiem.Enabled = false;
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            using (HangHoaModelContext db = new HangHoaModelContext())
            {
                //nhapHangHoasBindingSource.DataSource = db.Emplist.ToList();
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
                    btn_timkiem.Enabled = true;

                }
            }
        }

        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dòng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                using (HangHoaModelContext db = new HangHoaModelContext())
                {
                   // nhapHangHoasBindingSource.DataSource = db.Emplist.ToList();
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
    }
}
