namespace InventoryManager2022
{
    partial class formMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_thongke = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_hanghoa = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_main = new System.Windows.Forms.Label();
            this.lb_mainn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconChild = new FontAwesome.Sharp.IconPictureBox();
            this.lb_choosed = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelSubHangHoa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_nhanvien = new FontAwesome.Sharp.IconButton();
            this.panelSubNhanVien = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChild)).BeginInit();
            this.panelSubHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btn_thongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.ForeColor = System.Drawing.Color.Black;
            this.btn_thongke.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btn_thongke.IconColor = System.Drawing.Color.Black;
            this.btn_thongke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_thongke.IconSize = 40;
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(0, 100);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(199, 51);
            this.btn_thongke.TabIndex = 1;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.panelSubNhanVien);
            this.panelMenu.Controls.Add(this.btn_nhanvien);
            this.panelMenu.Controls.Add(this.panelSubHangHoa);
            this.panelMenu.Controls.Add(this.btn_hanghoa);
            this.panelMenu.Controls.Add(this.btn_thongke);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(199, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_hanghoa
            // 
            this.btn_hanghoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btn_hanghoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hanghoa.FlatAppearance.BorderSize = 0;
            this.btn_hanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hanghoa.IconChar = FontAwesome.Sharp.IconChar.DumpsterFire;
            this.btn_hanghoa.IconColor = System.Drawing.Color.Black;
            this.btn_hanghoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_hanghoa.IconSize = 40;
            this.btn_hanghoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hanghoa.Location = new System.Drawing.Point(0, 151);
            this.btn_hanghoa.Name = "btn_hanghoa";
            this.btn_hanghoa.Size = new System.Drawing.Size(199, 51);
            this.btn_hanghoa.TabIndex = 2;
            this.btn_hanghoa.Text = "Hàng hóa";
            this.btn_hanghoa.UseVisualStyleBackColor = false;
            this.btn_hanghoa.Click += new System.EventHandler(this.btn_hanghoa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lb_mainn);
            this.panel2.Controls.Add(this.lb_main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 100);
            this.panel2.TabIndex = 0;
            // 
            // lb_main
            // 
            this.lb_main.AutoSize = true;
            this.lb_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lb_main.Location = new System.Drawing.Point(3, 9);
            this.lb_main.Name = "lb_main";
            this.lb_main.Size = new System.Drawing.Size(183, 63);
            this.lb_main.TabIndex = 0;
            this.lb_main.Text = "LOGO";
            // 
            // lb_mainn
            // 
            this.lb_mainn.AutoSize = true;
            this.lb_mainn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lb_mainn.Location = new System.Drawing.Point(91, 54);
            this.lb_mainn.Name = "lb_mainn";
            this.lb_mainn.Size = new System.Drawing.Size(108, 46);
            this.lb_mainn.TabIndex = 1;
            this.lb_mainn.Text = "2022";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lb_choosed);
            this.panel1.Controls.Add(this.iconChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 36);
            this.panel1.TabIndex = 2;
            // 
            // iconChild
            // 
            this.iconChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.iconChild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconChild.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.iconChild.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChild.Location = new System.Drawing.Point(3, 1);
            this.iconChild.Name = "iconChild";
            this.iconChild.Size = new System.Drawing.Size(32, 32);
            this.iconChild.TabIndex = 0;
            this.iconChild.TabStop = false;
            // 
            // lb_choosed
            // 
            this.lb_choosed.AutoSize = true;
            this.lb_choosed.Location = new System.Drawing.Point(42, 9);
            this.lb_choosed.Name = "lb_choosed";
            this.lb_choosed.Size = new System.Drawing.Size(53, 13);
            this.lb_choosed.TabIndex = 1;
            this.lb_choosed.Text = "Thống kê";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(199, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 1);
            this.panel3.TabIndex = 3;
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(199, 37);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(601, 413);
            this.panelShow.TabIndex = 4;
            // 
            // panelSubHangHoa
            // 
            this.panelSubHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panelSubHangHoa.Controls.Add(this.button3);
            this.panelSubHangHoa.Controls.Add(this.button2);
            this.panelSubHangHoa.Controls.Add(this.button1);
            this.panelSubHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubHangHoa.Location = new System.Drawing.Point(0, 202);
            this.panelSubHangHoa.Name = "panelSubHangHoa";
            this.panelSubHangHoa.Size = new System.Drawing.Size(199, 69);
            this.panelSubHangHoa.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lí hàng hóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nhập hàng hóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hủy hàng hóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btn_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_nhanvien.IconColor = System.Drawing.Color.Black;
            this.btn_nhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_nhanvien.IconSize = 40;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 271);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(199, 51);
            this.btn_nhanvien.TabIndex = 8;
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            // 
            // panelSubNhanVien
            // 
            this.panelSubNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panelSubNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubNhanVien.Location = new System.Drawing.Point(0, 322);
            this.panelSubNhanVien.Name = "panelSubNhanVien";
            this.panelSubNhanVien.Size = new System.Drawing.Size(199, 100);
            this.panelSubNhanVien.TabIndex = 9;
            // 
            // formMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "formMainMenu";
            this.Text = "formMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChild)).EndInit();
            this.panelSubHangHoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_thongke;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_hanghoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_mainn;
        private System.Windows.Forms.Label lb_main;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconChild;
        private System.Windows.Forms.Label lb_choosed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelSubHangHoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btn_nhanvien;
        private System.Windows.Forms.Panel panelSubNhanVien;
    }
}