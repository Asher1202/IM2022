using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager2022
{
    public partial class formMainMenu : Form
    {
        //Khai báo biến cho panel và button màu
        private IconButton buttonChon;
        private Panel leftPanel;
        private Form formOpen;
        public formMainMenu()
        {
            InitializeComponent();
            leftPanel = new Panel();
            leftPanel.Size = new Size(7, 51);
            panelMenu.Controls.Add(leftPanel);
            tuyChinhMenu();
        }
        //callbacks

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (formOpen != null)
            {
                formOpen.Close();
            }
            formOpen = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelShow.Controls.Add(childForm);
            panelShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           // lb_choosed.Text = childForm.Text;
        }
        //method
        private void tuyChinhMenu()
        {
            panelSubHangHoa.Visible = false;
        }
        private void anMenuCon()
        {
            if (panelSubHangHoa.Visible == true)
                panelSubHangHoa.Visible = false;

        }
        private void hienMenuCon(Panel menuCon)
        {
            if (menuCon.Visible == false)
            {
                anMenuCon();
                menuCon.Visible = true;
            }
            else menuCon.Visible = false;
            

        }
        private void daNhanNut(object senderBtn, Color color)//active
        {
            if (senderBtn != null)
            {
                hetNhanNut();
                buttonChon = (IconButton)senderBtn;
                buttonChon.BackColor = Color.FromArgb(177, 178, 255);
                buttonChon.ForeColor = color;
                buttonChon.TextAlign = ContentAlignment.MiddleCenter;
                buttonChon.IconColor = color;
                buttonChon.TextImageRelation = TextImageRelation.TextBeforeImage;
                buttonChon.ImageAlign = ContentAlignment.MiddleRight;
                // khu vuc ben trai button
                leftPanel.BackColor = color;
                leftPanel.Location = new Point(0, buttonChon.Location.Y);
                leftPanel.Visible = true;
                leftPanel.BringToFront();
                iconChild.IconChar = buttonChon.IconChar;
                lb_choosed.Text = buttonChon.Text;

            }
        }
        private void hetNhanNut()//deactive
        {
            if (buttonChon != null)
            {
                buttonChon.BackColor = Color.FromArgb(177, 178, 255);
                buttonChon.ForeColor = Color.FromArgb(0,0,0); ;
                buttonChon.TextAlign = ContentAlignment.MiddleCenter;
                buttonChon.IconColor = Color.FromArgb(0, 0, 0); ;
                buttonChon.TextImageRelation = TextImageRelation.ImageBeforeText;
                buttonChon.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            daNhanNut(sender, RGBColors.color1);
            OpenChildForm(new formThongKe());
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            daNhanNut(sender, RGBColors.color2);
            hienMenuCon(panelSubHangHoa);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            daNhanNut(sender, RGBColors.color3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
