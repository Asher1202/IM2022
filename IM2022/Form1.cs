using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace IM2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-3VVTV3I\SQLEXPRESS;Initial Catalog=IM2022;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            String id, password;
            id = t_id.Text;
            password = t_password.Text;

            try
            {
                string query = "SELECT * FROM users WHERE id = '"+ t_id.Text + "    ' AND password = '"+t_password.Text +"' ";  

                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                
                if(dtbl.Rows.Count != 0)
                {
                    MessageBox.Show("Ban da dang nhap thanh cong");
                }
                else
                {
                    MessageBox.Show("Ban da dang nhap that bai");
                }
            }

            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
    }
}
