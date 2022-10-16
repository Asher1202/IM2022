namespace InventoryManager2022.Forms
{
    partial class formBanHang
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
            this.nhanVienInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet = new InventoryManager2022.IM22DataSet();
            this.nhanVienInfoesTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.NhanVienInfoesTableAdapter();
            this.nhapHangHoasTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.NhapHangHoasTableAdapter();
            this.nhapHangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_thanhtoan = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_loaihang = new System.Windows.Forms.Label();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_soluongton = new System.Windows.Forms.TextBox();
            this.tb_tenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iM22DataSet1 = new InventoryManager2022.IM22DataSet();
            this.nhapHangHoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inHoaDonsTableAdapter1 = new InventoryManager2022.IM22DataSetTableAdapters.inHoaDonsTableAdapter();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaCungCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVienInfoesBindingSource
            // 
            this.nhanVienInfoesBindingSource.DataMember = "NhanVienInfoes";
            this.nhanVienInfoesBindingSource.DataSource = this.iM22DataSetBindingSource;
            this.nhanVienInfoesBindingSource.CurrentChanged += new System.EventHandler(this.nhanVienInfoesBindingSource_CurrentChanged);
            // 
            // iM22DataSetBindingSource
            // 
            this.iM22DataSetBindingSource.DataSource = this.iM22DataSet;
            this.iM22DataSetBindingSource.Position = 0;
            this.iM22DataSetBindingSource.CurrentChanged += new System.EventHandler(this.iM22DataSetBindingSource_CurrentChanged);
            // 
            // iM22DataSet
            // 
            this.iM22DataSet.DataSetName = "IM22DataSet";
            this.iM22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienInfoesTableAdapter
            // 
            this.nhanVienInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // nhapHangHoasTableAdapter
            // 
            this.nhapHangHoasTableAdapter.ClearBeforeFill = true;
            // 
            // nhapHangHoasBindingSource
            // 
            this.nhapHangHoasBindingSource.DataMember = "NhapHangHoas";
            this.nhapHangHoasBindingSource.DataSource = this.iM22DataSetBindingSource;
            this.nhapHangHoasBindingSource.CurrentChanged += new System.EventHandler(this.nhapHangHoasBindingSource_CurrentChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 554);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHangDataGridViewTextBoxColumn,
            this.soLuongNhapDataGridViewTextBoxColumn,
            this.nhaCungCapDataGridViewTextBoxColumn,
            this.loaiHangHoaDataGridViewTextBoxColumn,
            this.soTienDataGridViewTextBoxColumn,
            this.soTienBanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhapHangHoasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bt_thanhtoan);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cb_loaihang);
            this.panel1.Controls.Add(this.tb_giaban);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_soluongton);
            this.panel1.Controls.Add(this.tb_tenhang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 187);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bt_thanhtoan.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.bt_thanhtoan.IconColor = System.Drawing.Color.Black;
            this.bt_thanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thanhtoan.IconSize = 30;
            this.bt_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thanhtoan.Location = new System.Drawing.Point(791, 117);
            this.bt_thanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(179, 44);
            this.bt_thanhtoan.TabIndex = 13;
            this.bt_thanhtoan.Text = "     &Thanh toán";
            this.bt_thanhtoan.UseVisualStyleBackColor = true;
            this.bt_thanhtoan.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(640, 117);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(143, 44);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "   &Tìm kiếm";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nhapHangHoasBindingSource;
            this.comboBox1.DisplayMember = "LoaiHangHoa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 135);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "LoaiHangHoa";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_loaihang
            // 
            this.cb_loaihang.AutoSize = true;
            this.cb_loaihang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cb_loaihang.Location = new System.Drawing.Point(16, 134);
            this.cb_loaihang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cb_loaihang.Name = "cb_loaihang";
            this.cb_loaihang.Size = new System.Drawing.Size(130, 29);
            this.cb_loaihang.TabIndex = 10;
            this.cb_loaihang.Text = "Loại hàng :";
            this.cb_loaihang.Click += new System.EventHandler(this.cb_loaihang_Click);
            // 
            // tb_giaban
            // 
            this.tb_giaban.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "SoTienBan", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tb_giaban.Location = new System.Drawing.Point(185, 96);
            this.tb_giaban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(148, 22);
            this.tb_giaban.TabIndex = 5;
            this.tb_giaban.TextChanged += new System.EventHandler(this.tb_giaban_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá bán :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_soluongton
            // 
            this.tb_soluongton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "SoLuongNhap", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
            this.tb_soluongton.Location = new System.Drawing.Point(185, 54);
            this.tb_soluongton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_soluongton.Name = "tb_soluongton";
            this.tb_soluongton.Size = new System.Drawing.Size(148, 22);
            this.tb_soluongton.TabIndex = 3;
            this.tb_soluongton.TextChanged += new System.EventHandler(this.tb_soluongton_TextChanged);
            // 
            // tb_tenhang
            // 
            this.tb_tenhang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "TenHang", true));
            this.tb_tenhang.Location = new System.Drawing.Point(185, 16);
            this.tb_tenhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tenhang.Name = "tb_tenhang";
            this.tb_tenhang.Size = new System.Drawing.Size(148, 22);
            this.tb_tenhang.TabIndex = 2;
            this.tb_tenhang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng tồn :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iM22DataSet1
            // 
            this.iM22DataSet1.DataSetName = "IM22DataSet";
            this.iM22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhapHangHoasBindingSource1
            // 
            this.nhapHangHoasBindingSource1.DataMember = "NhapHangHoas";
            this.nhapHangHoasBindingSource1.DataSource = this.iM22DataSet1;
            this.nhapHangHoasBindingSource1.CurrentChanged += new System.EventHandler(this.nhapHangHoasBindingSource1_CurrentChanged);
            // 
            // inHoaDonsTableAdapter1
            // 
            this.inHoaDonsTableAdapter1.ClearBeforeFill = true;
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            this.soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.HeaderText = "SoLuongNhap";
            this.soLuongNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            // 
            // nhaCungCapDataGridViewTextBoxColumn
            // 
            this.nhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "NhaCungCap";
            this.nhaCungCapDataGridViewTextBoxColumn.HeaderText = "NhaCungCap";
            this.nhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhaCungCapDataGridViewTextBoxColumn.Name = "nhaCungCapDataGridViewTextBoxColumn";
            // 
            // loaiHangHoaDataGridViewTextBoxColumn
            // 
            this.loaiHangHoaDataGridViewTextBoxColumn.DataPropertyName = "LoaiHangHoa";
            this.loaiHangHoaDataGridViewTextBoxColumn.HeaderText = "LoaiHangHoa";
            this.loaiHangHoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiHangHoaDataGridViewTextBoxColumn.Name = "loaiHangHoaDataGridViewTextBoxColumn";
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            this.soTienDataGridViewTextBoxColumn.HeaderText = "SoTien";
            this.soTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            // 
            // soTienBanDataGridViewTextBoxColumn
            // 
            this.soTienBanDataGridViewTextBoxColumn.DataPropertyName = "SoTienBan";
            this.soTienBanDataGridViewTextBoxColumn.HeaderText = "SoTienBan";
            this.soTienBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienBanDataGridViewTextBoxColumn.Name = "soTienBanDataGridViewTextBoxColumn";
            // 
            // formBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formBanHang";
            this.Text = "formBanHang";
            this.Load += new System.EventHandler(this.formBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nhanVienInfoesBindingSource;
        private System.Windows.Forms.BindingSource iM22DataSetBindingSource;
        private IM22DataSet iM22DataSet;
        private IM22DataSetTableAdapters.NhanVienInfoesTableAdapter nhanVienInfoesTableAdapter;
        private IM22DataSetTableAdapters.NhapHangHoasTableAdapter nhapHangHoasTableAdapter;
        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cb_loaihang;
        private System.Windows.Forms.TextBox tb_giaban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_soluongton;
        private System.Windows.Forms.TextBox tb_tenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton bt_thanhtoan;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IM22DataSet iM22DataSet1;
        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource1;
        private IM22DataSetTableAdapters.inHoaDonsTableAdapter inHoaDonsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaCungCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienBanDataGridViewTextBoxColumn;
    }
}