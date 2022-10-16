using FontAwesome.Sharp;
using InventoryManager2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace InventoryManager2022.Forms
{
    public partial class loginForm1 : Form
    {
        public static int pAdmin;
        public static string pUser;
        public static string pMaNV;
        public static bool pLogged;
        public loginForm1()
        {
            InitializeComponent();
        }

        private void loginForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e) 
        {
            {
            SqlConnection con = new SqlConnection("Data Source=MSI\\BATRUONG;Initial Catalog=IM22;Integrated Security=True");
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "loginForm";
                    cmd.Parameters.AddWithValue("@username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    if (rd.HasRows)
                    {
                        this.Hide();
                        formMainMenu mm = new formMainMenu();
                        if (rd[3].ToString() == "Quản lí")
                        {
                            pAdmin = 1;
                        }

                        else pAdmin = 0;
                        pLogged = true;
                        pUser = rd.GetString(2);
                        pMaNV = rd.GetString(0);
                        mm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu hoặc tài khoản vui lòng thử lại");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();

                }
            }
        }

        private void chekSee_CheckedChanged(object sender, EventArgs e)
        {
            if (chekSee.Checked)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
