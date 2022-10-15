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
    public partial class formXemHoaDon : Form
    {
        int ID;
        public formXemHoaDon()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            inHoaDonsBindingSource.Filter = "customerID LIKE '%" + tb_tenkhach.Text + "%'";
            dataGridView1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formXemHoaDon_Load(object sender, EventArgs e)
        {
            this.inHoaDonsTableAdapter1.Fill(this.iM22DataSet.inHoaDons);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            ID = int.Parse(row.Cells[0].Value.ToString());

        }

        private void bt_xuathoadon_Click(object sender, EventArgs e)
        {
            if (ID == null)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nào để xuất, vui lòng chọn");
                return;
            }
            formThanhToan.ttOrderIDD = ID;
            formPrintInvoice fpiv = new formPrintInvoice();
            fpiv.Show();
        }
    }
}
