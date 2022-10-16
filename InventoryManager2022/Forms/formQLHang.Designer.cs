namespace InventoryManager2022.Forms
{
    partial class formQLHang
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhapHangHoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet2 = new InventoryManager2022.IM22DataSet2();
            this.nhapHangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet = new InventoryManager2022.IM22DataSet();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tb_tenhangtim = new System.Windows.Forms.TextBox();
            this.lb_timhang = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_mahanghoa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sotien = new System.Windows.Forms.TextBox();
            this.lb_sotien = new System.Windows.Forms.Label();
            this.cb_loaihanghoa = new System.Windows.Forms.ComboBox();
            this.tb_nhacungcap = new System.Windows.Forms.TextBox();
            this.tb_soluongnhap = new System.Windows.Forms.TextBox();
            this.tb_tenhanghoa = new System.Windows.Forms.TextBox();
            this.lb_loaihanghoa = new System.Windows.Forms.Label();
            this.lb_nhacungcap = new System.Windows.Forms.Label();
            this.lb_slnhap = new System.Windows.Forms.Label();
            this.nhapHangHoasTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.NhapHangHoasTableAdapter();
            this.lb_tenhanghoa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_remove = new FontAwesome.Sharp.IconButton();
            this.nhapHangHoasTableAdapter1 = new InventoryManager2022.IM22DataSet2TableAdapters.NhapHangHoasTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(427, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 718);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHangDataGridViewTextBoxColumn,
            this.soLuongNhapDataGridViewTextBoxColumn,
            this.nhaCungCapDataGridViewTextBoxColumn,
            this.loaiHangHoaDataGridViewTextBoxColumn,
            this.soTienDataGridViewTextBoxColumn,
            this.soTienBanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhapHangHoasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 718);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.Width = 159;
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            this.soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.HeaderText = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            this.soLuongNhapDataGridViewTextBoxColumn.Width = 159;
            // 
            // nhaCungCapDataGridViewTextBoxColumn
            // 
            this.nhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "NhaCungCap";
            this.nhaCungCapDataGridViewTextBoxColumn.HeaderText = "NhaCungCap";
            this.nhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhaCungCapDataGridViewTextBoxColumn.Name = "nhaCungCapDataGridViewTextBoxColumn";
            this.nhaCungCapDataGridViewTextBoxColumn.Width = 160;
            // 
            // loaiHangHoaDataGridViewTextBoxColumn
            // 
            this.loaiHangHoaDataGridViewTextBoxColumn.DataPropertyName = "LoaiHangHoa";
            this.loaiHangHoaDataGridViewTextBoxColumn.HeaderText = "LoaiHangHoa";
            this.loaiHangHoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiHangHoaDataGridViewTextBoxColumn.Name = "loaiHangHoaDataGridViewTextBoxColumn";
            this.loaiHangHoaDataGridViewTextBoxColumn.Width = 159;
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            this.soTienDataGridViewTextBoxColumn.HeaderText = "SoTien";
            this.soTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            this.soTienDataGridViewTextBoxColumn.Width = 159;
            // 
            // soTienBanDataGridViewTextBoxColumn
            // 
            this.soTienBanDataGridViewTextBoxColumn.DataPropertyName = "SoTienBan";
            this.soTienBanDataGridViewTextBoxColumn.HeaderText = "SoTienBan";
            this.soTienBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienBanDataGridViewTextBoxColumn.Name = "soTienBanDataGridViewTextBoxColumn";
            this.soTienBanDataGridViewTextBoxColumn.Width = 159;
            // 
            // nhapHangHoasBindingSource1
            // 
            this.nhapHangHoasBindingSource1.DataMember = "NhapHangHoas";
            this.nhapHangHoasBindingSource1.DataSource = this.iM22DataSet2;
            // 
            // iM22DataSet2
            // 
            this.iM22DataSet2.DataSetName = "IM22DataSet2";
            this.iM22DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhapHangHoasBindingSource
            // 
            this.nhapHangHoasBindingSource.DataMember = "NhapHangHoas";
            this.nhapHangHoasBindingSource.DataSource = this.iM22DataSetBindingSource;
            // 
            // iM22DataSetBindingSource
            // 
            this.iM22DataSetBindingSource.DataSource = this.iM22DataSet;
            this.iM22DataSetBindingSource.Position = 0;
            // 
            // iM22DataSet
            // 
            this.iM22DataSet.DataSetName = "IM22DataSet";
            this.iM22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(16, 602);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(384, 44);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "   &Tìm kiếm";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // tb_tenhangtim
            // 
            this.tb_tenhangtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_tenhangtim.Location = new System.Drawing.Point(213, 476);
            this.tb_tenhangtim.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tenhangtim.Name = "tb_tenhangtim";
            this.tb_tenhangtim.Size = new System.Drawing.Size(212, 36);
            this.tb_tenhangtim.TabIndex = 17;
            // 
            // lb_timhang
            // 
            this.lb_timhang.AutoSize = true;
            this.lb_timhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_timhang.Location = new System.Drawing.Point(11, 476);
            this.lb_timhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_timhang.Name = "lb_timhang";
            this.lb_timhang.Size = new System.Drawing.Size(176, 30);
            this.lb_timhang.TabIndex = 17;
            this.lb_timhang.Text = "Tên hàng tìm :";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "id", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox2.Location = new System.Drawing.Point(217, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 36);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lb_mahanghoa
            // 
            this.lb_mahanghoa.AutoSize = true;
            this.lb_mahanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_mahanghoa.Location = new System.Drawing.Point(8, 74);
            this.lb_mahanghoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mahanghoa.Name = "lb_mahanghoa";
            this.lb_mahanghoa.Size = new System.Drawing.Size(175, 30);
            this.lb_mahanghoa.TabIndex = 15;
            this.lb_mahanghoa.Text = "Mã hàng hóa :";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "SoTienBan", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox1.Location = new System.Drawing.Point(217, 410);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 36);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(7, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Giá bán: ";
            // 
            // tb_sotien
            // 
            this.tb_sotien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "SoTien", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tb_sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_sotien.Location = new System.Drawing.Point(217, 353);
            this.tb_sotien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sotien.Name = "tb_sotien";
            this.tb_sotien.Size = new System.Drawing.Size(212, 36);
            this.tb_sotien.TabIndex = 12;
            this.tb_sotien.TextChanged += new System.EventHandler(this.tb_sotien_TextChanged);
            // 
            // lb_sotien
            // 
            this.lb_sotien.AutoSize = true;
            this.lb_sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_sotien.Location = new System.Drawing.Point(7, 353);
            this.lb_sotien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sotien.Name = "lb_sotien";
            this.lb_sotien.Size = new System.Drawing.Size(106, 30);
            this.lb_sotien.TabIndex = 11;
            this.lb_sotien.Text = "Số tiền :";
            // 
            // cb_loaihanghoa
            // 
            this.cb_loaihanghoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "LoaiHangHoa", true));
            this.cb_loaihanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cb_loaihanghoa.FormattingEnabled = true;
            this.cb_loaihanghoa.Items.AddRange(new object[] {
            "Hàng khô",
            "Hàng thịt",
            "Hàng đông lạnh",
            "Hàng giải khát"});
            this.cb_loaihanghoa.Location = new System.Drawing.Point(217, 297);
            this.cb_loaihanghoa.Margin = new System.Windows.Forms.Padding(4);
            this.cb_loaihanghoa.Name = "cb_loaihanghoa";
            this.cb_loaihanghoa.Size = new System.Drawing.Size(212, 37);
            this.cb_loaihanghoa.TabIndex = 7;
            // 
            // tb_nhacungcap
            // 
            this.tb_nhacungcap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "NhaCungCap", true));
            this.tb_nhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_nhacungcap.Location = new System.Drawing.Point(217, 244);
            this.tb_nhacungcap.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nhacungcap.Name = "tb_nhacungcap";
            this.tb_nhacungcap.Size = new System.Drawing.Size(212, 36);
            this.tb_nhacungcap.TabIndex = 6;
            this.tb_nhacungcap.TextChanged += new System.EventHandler(this.tb_nhacungcap_TextChanged);
            // 
            // tb_soluongnhap
            // 
            this.tb_soluongnhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "SoLuongNhap", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.tb_soluongnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_soluongnhap.Location = new System.Drawing.Point(217, 186);
            this.tb_soluongnhap.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soluongnhap.Name = "tb_soluongnhap";
            this.tb_soluongnhap.Size = new System.Drawing.Size(212, 36);
            this.tb_soluongnhap.TabIndex = 5;
            this.tb_soluongnhap.TextChanged += new System.EventHandler(this.tb_soluongnhap_TextChanged);
            // 
            // tb_tenhanghoa
            // 
            this.tb_tenhanghoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "TenHang", true));
            this.tb_tenhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tb_tenhanghoa.Location = new System.Drawing.Point(217, 130);
            this.tb_tenhanghoa.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tenhanghoa.Name = "tb_tenhanghoa";
            this.tb_tenhanghoa.Size = new System.Drawing.Size(212, 36);
            this.tb_tenhanghoa.TabIndex = 4;
            this.tb_tenhanghoa.TextChanged += new System.EventHandler(this.tb_tenhanghoa_TextChanged);
            // 
            // lb_loaihanghoa
            // 
            this.lb_loaihanghoa.AutoSize = true;
            this.lb_loaihanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_loaihanghoa.Location = new System.Drawing.Point(7, 300);
            this.lb_loaihanghoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_loaihanghoa.Name = "lb_loaihanghoa";
            this.lb_loaihanghoa.Size = new System.Drawing.Size(187, 30);
            this.lb_loaihanghoa.TabIndex = 3;
            this.lb_loaihanghoa.Text = "Loại hàng hóa :";
            // 
            // lb_nhacungcap
            // 
            this.lb_nhacungcap.AutoSize = true;
            this.lb_nhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_nhacungcap.Location = new System.Drawing.Point(7, 244);
            this.lb_nhacungcap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nhacungcap.Name = "lb_nhacungcap";
            this.lb_nhacungcap.Size = new System.Drawing.Size(184, 30);
            this.lb_nhacungcap.TabIndex = 2;
            this.lb_nhacungcap.Text = "Nhà cung cấp :";
            // 
            // lb_slnhap
            // 
            this.lb_slnhap.AutoSize = true;
            this.lb_slnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_slnhap.Location = new System.Drawing.Point(7, 186);
            this.lb_slnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_slnhap.Name = "lb_slnhap";
            this.lb_slnhap.Size = new System.Drawing.Size(190, 30);
            this.lb_slnhap.TabIndex = 1;
            this.lb_slnhap.Text = "Số lượng nhập :";
            // 
            // nhapHangHoasTableAdapter
            // 
            this.nhapHangHoasTableAdapter.ClearBeforeFill = true;
            // 
            // lb_tenhanghoa
            // 
            this.lb_tenhanghoa.AutoSize = true;
            this.lb_tenhanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lb_tenhanghoa.Location = new System.Drawing.Point(7, 130);
            this.lb_tenhanghoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenhanghoa.Name = "lb_tenhanghoa";
            this.lb_tenhanghoa.Size = new System.Drawing.Size(183, 30);
            this.lb_tenhanghoa.TabIndex = 0;
            this.lb_tenhanghoa.Text = "Tên hàng hóa :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 465);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 253);
            this.panel2.TabIndex = 2;
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
            this.btn_save.Location = new System.Drawing.Point(279, 545);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 34);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "  Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_tenhangtim);
            this.panel1.Controls.Add(this.gb_ThongTin);
            this.panel1.Controls.Add(this.lb_timhang);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 718);
            this.panel1.TabIndex = 3;
            // 
            // gb_ThongTin
            // 
            this.gb_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.gb_ThongTin.Controls.Add(this.textBox2);
            this.gb_ThongTin.Controls.Add(this.lb_mahanghoa);
            this.gb_ThongTin.Controls.Add(this.textBox1);
            this.gb_ThongTin.Controls.Add(this.label1);
            this.gb_ThongTin.Controls.Add(this.tb_sotien);
            this.gb_ThongTin.Controls.Add(this.lb_sotien);
            this.gb_ThongTin.Controls.Add(this.cb_loaihanghoa);
            this.gb_ThongTin.Controls.Add(this.tb_nhacungcap);
            this.gb_ThongTin.Controls.Add(this.tb_soluongnhap);
            this.gb_ThongTin.Controls.Add(this.tb_tenhanghoa);
            this.gb_ThongTin.Controls.Add(this.lb_loaihanghoa);
            this.gb_ThongTin.Controls.Add(this.lb_nhacungcap);
            this.gb_ThongTin.Controls.Add(this.lb_slnhap);
            this.gb_ThongTin.Controls.Add(this.lb_tenhanghoa);
            this.gb_ThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_ThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_ThongTin.Location = new System.Drawing.Point(0, 0);
            this.gb_ThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ThongTin.Size = new System.Drawing.Size(427, 465);
            this.gb_ThongTin.TabIndex = 0;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Quản lí hàng hóa";
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
            this.btn_add.Location = new System.Drawing.Point(17, 545);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 34);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "  Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.btn_remove.Location = new System.Drawing.Point(148, 545);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(123, 34);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "  Xóa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // nhapHangHoasTableAdapter1
            // 
            this.nhapHangHoasTableAdapter1.ClearBeforeFill = true;
            // 
            // formQLHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 718);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formQLHang";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_ThongTin.ResumeLayout(false);
            this.gb_ThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox tb_tenhangtim;
        private System.Windows.Forms.Label lb_timhang;
        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource;
        private System.Windows.Forms.BindingSource iM22DataSetBindingSource;
        private IM22DataSet iM22DataSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_mahanghoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_sotien;
        private System.Windows.Forms.Label lb_sotien;
        private System.Windows.Forms.ComboBox cb_loaihanghoa;
        private System.Windows.Forms.TextBox tb_nhacungcap;
        private System.Windows.Forms.TextBox tb_soluongnhap;
        private System.Windows.Forms.TextBox tb_tenhanghoa;
        private System.Windows.Forms.Label lb_loaihanghoa;
        private System.Windows.Forms.Label lb_nhacungcap;
        private System.Windows.Forms.Label lb_slnhap;
        private IM22DataSetTableAdapters.NhapHangHoasTableAdapter nhapHangHoasTableAdapter;
        private System.Windows.Forms.Label lb_tenhanghoa;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_ThongTin;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_remove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienBanDataGridViewTextBoxColumn;
        private IM22DataSet2 iM22DataSet2;
        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource1;
        private IM22DataSet2TableAdapters.NhapHangHoasTableAdapter nhapHangHoasTableAdapter1;
    }
}