namespace InventoryManager2022.Forms
{
    partial class formXemHoaDon
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
            this.nhapHangHoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet1 = new InventoryManager2022.IM22DataSet();
            this.nhapHangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet = new InventoryManager2022.IM22DataSet();
            this.tb_tenkhach = new System.Windows.Forms.TextBox();
            this.lb_tenkhach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_xuathoadon = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.nhapHangHoasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staticidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangmuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHoaDonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhapHangHoasTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.NhapHangHoasTableAdapter();
            this.nhanVienInfoesTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.NhanVienInfoesTableAdapter();
            this.nhanVienInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inHoaDonsTableAdapter1 = new InventoryManager2022.IM22DataSetTableAdapters.inHoaDonsTableAdapter();
            this.inHoaDonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhapHangHoasBindingSource1
            // 
            this.nhapHangHoasBindingSource1.DataMember = "NhapHangHoas";
            this.nhapHangHoasBindingSource1.DataSource = this.iM22DataSet1;
            // 
            // iM22DataSet1
            // 
            this.iM22DataSet1.DataSetName = "IM22DataSet";
            this.iM22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tb_tenkhach
            // 
            this.tb_tenkhach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhapHangHoasBindingSource, "TenHang", true));
            this.tb_tenkhach.Location = new System.Drawing.Point(185, 16);
            this.tb_tenkhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tenkhach.Name = "tb_tenkhach";
            this.tb_tenkhach.Size = new System.Drawing.Size(148, 22);
            this.tb_tenkhach.TabIndex = 2;
            // 
            // lb_tenkhach
            // 
            this.lb_tenkhach.AutoSize = true;
            this.lb_tenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lb_tenkhach.Location = new System.Drawing.Point(16, 11);
            this.lb_tenkhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenkhach.Name = "lb_tenkhach";
            this.lb_tenkhach.Size = new System.Drawing.Size(137, 29);
            this.lb_tenkhach.TabIndex = 0;
            this.lb_tenkhach.Text = "Tên khách :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bt_xuathoadon);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.tb_tenkhach);
            this.panel1.Controls.Add(this.lb_tenkhach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 187);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_xuathoadon
            // 
            this.bt_xuathoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bt_xuathoadon.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.bt_xuathoadon.IconColor = System.Drawing.Color.Black;
            this.bt_xuathoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_xuathoadon.IconSize = 30;
            this.bt_xuathoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xuathoadon.Location = new System.Drawing.Point(791, 117);
            this.bt_xuathoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_xuathoadon.Name = "bt_xuathoadon";
            this.bt_xuathoadon.Size = new System.Drawing.Size(179, 44);
            this.bt_xuathoadon.TabIndex = 13;
            this.bt_xuathoadon.Text = "     &Xuất hóa đơn";
            this.bt_xuathoadon.UseVisualStyleBackColor = true;
            this.bt_xuathoadon.Click += new System.EventHandler(this.bt_xuathoadon_Click);
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
            // nhapHangHoasBindingSource2
            // 
            this.nhapHangHoasBindingSource2.DataMember = "NhapHangHoas";
            this.nhapHangHoasBindingSource2.DataSource = this.iM22DataSetBindingSource;
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
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.staticidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.hangmuaDataGridViewTextBoxColumn,
            this.giatienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inHoaDonsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // staticidDataGridViewTextBoxColumn
            // 
            this.staticidDataGridViewTextBoxColumn.DataPropertyName = "staticid";
            this.staticidDataGridViewTextBoxColumn.HeaderText = "staticid";
            this.staticidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staticidDataGridViewTextBoxColumn.Name = "staticidDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // hangmuaDataGridViewTextBoxColumn
            // 
            this.hangmuaDataGridViewTextBoxColumn.DataPropertyName = "hangmua";
            this.hangmuaDataGridViewTextBoxColumn.HeaderText = "hangmua";
            this.hangmuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hangmuaDataGridViewTextBoxColumn.Name = "hangmuaDataGridViewTextBoxColumn";
            // 
            // giatienDataGridViewTextBoxColumn
            // 
            this.giatienDataGridViewTextBoxColumn.DataPropertyName = "giatien";
            this.giatienDataGridViewTextBoxColumn.HeaderText = "giatien";
            this.giatienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giatienDataGridViewTextBoxColumn.Name = "giatienDataGridViewTextBoxColumn";
            // 
            // inHoaDonsBindingSource1
            // 
            this.inHoaDonsBindingSource1.DataMember = "inHoaDons";
            this.inHoaDonsBindingSource1.DataSource = this.iM22DataSetBindingSource;
            // 
            // nhapHangHoasTableAdapter
            // 
            this.nhapHangHoasTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienInfoesTableAdapter
            // 
            this.nhanVienInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienInfoesBindingSource
            // 
            this.nhanVienInfoesBindingSource.DataMember = "NhanVienInfoes";
            this.nhanVienInfoesBindingSource.DataSource = this.iM22DataSetBindingSource;
            // 
            // inHoaDonsTableAdapter1
            // 
            this.inHoaDonsTableAdapter1.ClearBeforeFill = true;
            // 
            // inHoaDonsBindingSource
            // 
            this.inHoaDonsBindingSource.DataMember = "inHoaDons";
            this.inHoaDonsBindingSource.DataSource = this.iM22DataSetBindingSource;
            // 
            // formXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formXemHoaDon";
            this.Text = "formXemHoaDon";
            this.Load += new System.EventHandler(this.formXemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource1;
        private IM22DataSet iM22DataSet1;
        private FontAwesome.Sharp.IconButton bt_xuathoadon;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource;
        private System.Windows.Forms.BindingSource iM22DataSetBindingSource;
        private IM22DataSet iM22DataSet;
        private System.Windows.Forms.TextBox tb_tenkhach;
        private System.Windows.Forms.Label lb_tenkhach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private IM22DataSetTableAdapters.NhapHangHoasTableAdapter nhapHangHoasTableAdapter;
        private IM22DataSetTableAdapters.NhanVienInfoesTableAdapter nhanVienInfoesTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienInfoesBindingSource;
        private IM22DataSetTableAdapters.inHoaDonsTableAdapter inHoaDonsTableAdapter1;
        private System.Windows.Forms.BindingSource inHoaDonsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangmuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inHoaDonsBindingSource1;
        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource2;
    }
}