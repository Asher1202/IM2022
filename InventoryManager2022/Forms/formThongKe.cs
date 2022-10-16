using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager2022
{
    public partial class formThongKe : Form
    {
        public formThongKe()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void EndReponsive()
        {
            if (this.Width < 1125)
            {
                this.Width = 1125;
            }
            else this.Width = 1125;

        }

        private void formThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iM22DataSet.inHoaDons' table. You can move, or remove it, as needed.
            this.inHoaDonsTableAdapter.Fill(this.iM22DataSet.inHoaDons);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9HKHU3U;Initial Catalog=IM22;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT SUM(CAST(giatien as int)) from dbo.inHoaDons";
                int totalmoney = ((int)cmd.ExecuteScalar());
                cmd.CommandText = "SELECT COUNT(*) FROM DBO.inHoaDons";
                int totalorder = ((int)cmd.ExecuteScalar());
                SqlCommand chart = new SqlCommand("SELECT * from dbo.inHoaDons;", con);

                SqlDataReader reader;
                reader = chart.ExecuteReader();
                while (reader.Read())
                {
                   // this.chart1.Series[]
                }
                con.Close();

                label5.Text = totalmoney.ToString();
                label3.Text = totalorder.ToString();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Loi truy van" + EX);
            }
        }

        private void formThongKe_ResizeEnd_1(object sender, EventArgs e)
        {
            EndReponsive();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
