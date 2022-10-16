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
            SqlConnection con = new SqlConnection("Data Source=MSI\\BATRUONG;Initial Catalog=IM22;Integrated Security=True");
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
           
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.Connection = con;
                sc.CommandType = CommandType.StoredProcedure;
                sc.CommandText = "ThongKe";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sc);
                da.Fill(dt);
                con.Close();
                chart1.DataSource = dt;
                chart1.Series["HoaDon"].XValueMember = "orderID"; 
                chart1.Series["HoaDon"].YValueMembers = "giatien";
                chart1.Titles.Add("Thống kê top 5 hóa đơn");

                con.Open();
                SqlCommand sh = new SqlCommand();
                sh.Connection = con;
                sh.CommandType = CommandType.StoredProcedure;
                sh.CommandText = "HangBan";
                DataTable hu = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(sh);
                ad.Fill(hu);
                con.Close();
                chart2.DataSource = hu;
                chart2.Series["BanChay"].XValueMember = "TenHang"; 
                chart2.Series["BanChay"].YValueMembers = "SoLuongBan";
                chart2.Titles.Add("Thống kê top 3 mặt hàng bán chạy");

        }

        private void formThongKe_ResizeEnd_1(object sender, EventArgs e)
        {
            EndReponsive();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
