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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //this.nhapHangHoasTableAdapter.searchID(this.iM22DataSet.NhapHangHoas, tb_tenhang.Text);
            nhapHangHoasBindingSource.Filter = "TenHang LIKE '%" + tb_tenhang.Text + "%'";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_soluongton.Text) - int.Parse(tb_slmua.Text) <= 0) {
                MessageBox.Show("Khách hàng không thể mua hàng với số lượng này");
                return;
            }
            else
            {
                tb_tongtien.Text = (int.Parse(tb_slmua.Text)*int.Parse(tb_giaban.Text)).ToString();
            }
            

        }

        private void tb_tongtien_TextChanged(object sender, EventArgs e)
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
        }
        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

    }
}
