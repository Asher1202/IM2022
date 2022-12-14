namespace InventoryManager2022.Forms
{
    partial class formNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.nhanVienInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet = new InventoryManager2022.IM22DataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_namsinh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_remove = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_sua = new FontAwesome.Sharp.IconButton();
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.cb_loaihanghoa = new System.Windows.Forms.ComboBox();
            this.tb_soluongnhap = new System.Windows.Forms.TextBox();
            this.tb_tenhanghoa = new System.Windows.Forms.TextBox();
            this.lb_chucvu = new System.Windows.Forms.Label();
            this.lb_tennhanvien = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.nhanVienInfoesTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.NhanVienInfoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienInfoesBindingSource, "Email", true));
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_email.Location = new System.Drawing.Point(163, 292);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(160, 31);
            this.tb_email.TabIndex = 145;
            this.tb_email.Text = "a@gmail.com";
            this.tb_email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nhanVienInfoesBindingSource
            // 
            this.nhanVienInfoesBindingSource.DataMember = "NhanVienInfoes";
            this.nhanVienInfoesBindingSource.DataSource = this.iM22DataSet;
            // 
            // iM22DataSet
            // 
            this.iM22DataSet.DataSetName = "IM22DataSet";
            this.iM22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(326, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 450);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.nhanVienInfoesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(824, 450);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(824, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_sdt.Location = new System.Drawing.Point(6, 255);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(150, 25);
            this.lb_sdt.TabIndex = 13;
            this.lb_sdt.Text = "Số điện thoại :";
            // 
            // lb_namsinh
            // 
            this.lb_namsinh.AutoSize = true;
            this.lb_namsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_namsinh.Location = new System.Drawing.Point(6, 211);
            this.lb_namsinh.Name = "lb_namsinh";
            this.lb_namsinh.Size = new System.Drawing.Size(120, 25);
            this.lb_namsinh.TabIndex = 11;
            this.lb_namsinh.Text = "Ngày sinh :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 81);
            this.panel2.TabIndex = 2;
            // 
            // btn_remove
            // 
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_remove.IconColor = System.Drawing.Color.Black;
            this.btn_remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove.IconSize = 30;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(115, 372);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(92, 28);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "  Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gb_ThongTin);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 450);
            this.panel1.TabIndex = 3;
            // 
            // bt_sua
            // 
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Black;
            this.bt_sua.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bt_sua.IconColor = System.Drawing.Color.Black;
            this.bt_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_sua.IconSize = 30;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(17, 410);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(92, 28);
            this.bt_sua.TabIndex = 11;
            this.bt_sua.Text = "  Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // gb_ThongTin
            // 
            this.gb_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.gb_ThongTin.Controls.Add(this.tb_matkhau);
            this.gb_ThongTin.Controls.Add(this.lb_matkhau);
            this.gb_ThongTin.Controls.Add(this.dateTimePicker1);
            this.gb_ThongTin.Controls.Add(this.textBox2);
            this.gb_ThongTin.Controls.Add(this.lb_email);
            this.gb_ThongTin.Controls.Add(this.tb_email);
            this.gb_ThongTin.Controls.Add(this.lb_sdt);
            this.gb_ThongTin.Controls.Add(this.lb_namsinh);
            this.gb_ThongTin.Controls.Add(this.cb_loaihanghoa);
            this.gb_ThongTin.Controls.Add(this.tb_soluongnhap);
            this.gb_ThongTin.Controls.Add(this.tb_tenhanghoa);
            this.gb_ThongTin.Controls.Add(this.lb_chucvu);
            this.gb_ThongTin.Controls.Add(this.lb_tennhanvien);
            this.gb_ThongTin.Controls.Add(this.lb_manv);
            this.gb_ThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_ThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_ThongTin.Location = new System.Drawing.Point(0, 0);
            this.gb_ThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(326, 369);
            this.gb_ThongTin.TabIndex = 0;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Quản lí nhân viên";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienInfoesBindingSource, "MatKhau", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_matkhau.Location = new System.Drawing.Point(164, 329);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(159, 31);
            this.tb_matkhau.TabIndex = 6;
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_matkhau.Location = new System.Drawing.Point(12, 332);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(113, 25);
            this.lb_matkhau.TabIndex = 18;
            this.lb_matkhau.Text = "Mật khẩu :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienInfoesBindingSource, "NgaySinh", true));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 38);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienInfoesBindingSource, "SoDienThoai", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox2.Location = new System.Drawing.Point(164, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 31);
            this.textBox2.TabIndex = 4;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_email.Location = new System.Drawing.Point(6, 292);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(77, 25);
            this.lb_email.TabIndex = 15;
            this.lb_email.Text = "Email :";
            // 
            // cb_loaihanghoa
            // 
            this.cb_loaihanghoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienInfoesBindingSource, "ChucVu", true));
            this.cb_loaihanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cb_loaihanghoa.FormattingEnabled = true;
            this.cb_loaihanghoa.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lí"});
            this.cb_loaihanghoa.Location = new System.Drawing.Point(163, 161);
            this.cb_loaihanghoa.Name = "cb_loaihanghoa";
            this.cb_loaihanghoa.Size = new System.Drawing.Size(160, 33);
            this.cb_loaihanghoa.TabIndex = 3;
            // 
            // tb_soluongnhap
            // 
            this.tb_soluongnhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienInfoesBindingSource, "TenNhanVien", true));
            this.tb_soluongnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_soluongnhap.Location = new System.Drawing.Point(164, 121);
            this.tb_soluongnhap.Name = "tb_soluongnhap";
            this.tb_soluongnhap.Size = new System.Drawing.Size(160, 31);
            this.tb_soluongnhap.TabIndex = 2;
            this.tb_soluongnhap.Text = "Nguyễn Kim A";
            // 
            // tb_tenhanghoa
            // 
            this.tb_tenhanghoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienInfoesBindingSource, "MaNhanVien", true));
            this.tb_tenhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_tenhanghoa.Location = new System.Drawing.Point(164, 76);
            this.tb_tenhanghoa.Name = "tb_tenhanghoa";
            this.tb_tenhanghoa.Size = new System.Drawing.Size(160, 31);
            this.tb_tenhanghoa.TabIndex = 1;
            this.tb_tenhanghoa.Text = "1202";
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.AutoSize = true;
            this.lb_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_chucvu.Location = new System.Drawing.Point(6, 164);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(103, 25);
            this.lb_chucvu.TabIndex = 3;
            this.lb_chucvu.Text = "Chức vụ :";
            // 
            // lb_tennhanvien
            // 
            this.lb_tennhanvien.AutoSize = true;
            this.lb_tennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_tennhanvien.Location = new System.Drawing.Point(6, 121);
            this.lb_tennhanvien.Name = "lb_tennhanvien";
            this.lb_tennhanvien.Size = new System.Drawing.Size(149, 25);
            this.lb_tennhanvien.TabIndex = 1;
            this.lb_tennhanvien.Text = "Tên nhân viên";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_manv.Location = new System.Drawing.Point(6, 76);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(154, 25);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã nhân viên :";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btn_save.IconColor = System.Drawing.Color.Black;
            this.btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_save.IconSize = 30;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(213, 372);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 28);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "  Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_add.IconColor = System.Drawing.Color.Black;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 30;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(17, 372);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 28);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "  Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // nhanVienInfoesTableAdapter
            // 
            this.nhanVienInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // formNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "formNhanVien";
            this.Text = "formNhanVien";
            this.Load += new System.EventHandler(this.formNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gb_ThongTin.ResumeLayout(false);
            this.gb_ThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_namsinh;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_remove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_ThongTin;
        private System.Windows.Forms.ComboBox cb_loaihanghoa;
        private System.Windows.Forms.TextBox tb_soluongnhap;
        private System.Windows.Forms.TextBox tb_tenhanghoa;
        private System.Windows.Forms.Label lb_chucvu;
        private System.Windows.Forms.Label lb_tennhanvien;
        private System.Windows.Forms.Label lb_manv;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.DataGridView dataGridView2;
        private IM22DataSet iM22DataSet;
        private System.Windows.Forms.BindingSource nhanVienInfoesBindingSource;
        private IM22DataSetTableAdapters.NhanVienInfoesTableAdapter nhanVienInfoesTableAdapter;
        private FontAwesome.Sharp.IconButton bt_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
    }
}