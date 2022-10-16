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
            this.tb_tenkhach = new System.Windows.Forms.TextBox();
            this.lb_tenkhach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_xuathoadon = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangmuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihangmuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHoaDonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet = new InventoryManager2022.IM22DataSet();
            this.inHoaDonsTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.inHoaDonsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tenkhach
            // 
            this.tb_tenkhach.Location = new System.Drawing.Point(139, 13);
            this.tb_tenkhach.Name = "tb_tenkhach";
            this.tb_tenkhach.Size = new System.Drawing.Size(112, 20);
            this.tb_tenkhach.TabIndex = 2;
            // 
            // lb_tenkhach
            // 
            this.lb_tenkhach.AutoSize = true;
            this.lb_tenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lb_tenkhach.Location = new System.Drawing.Point(12, 9);
            this.lb_tenkhach.Name = "lb_tenkhach";
            this.lb_tenkhach.Size = new System.Drawing.Size(105, 22);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 152);
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
            this.bt_xuathoadon.Location = new System.Drawing.Point(593, 95);
            this.bt_xuathoadon.Name = "bt_xuathoadon";
            this.bt_xuathoadon.Size = new System.Drawing.Size(134, 36);
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
            this.iconButton1.Location = new System.Drawing.Point(480, 95);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(107, 36);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "   &Tìm kiếm";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.hangmuaDataGridViewTextBoxColumn,
            this.loaihangmuaDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.giatienDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inHoaDonsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 298);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hangmuaDataGridViewTextBoxColumn
            // 
            this.hangmuaDataGridViewTextBoxColumn.DataPropertyName = "hangmua";
            this.hangmuaDataGridViewTextBoxColumn.HeaderText = "Tên hàng";
            this.hangmuaDataGridViewTextBoxColumn.Name = "hangmuaDataGridViewTextBoxColumn";
            // 
            // loaihangmuaDataGridViewTextBoxColumn
            // 
            this.loaihangmuaDataGridViewTextBoxColumn.DataPropertyName = "loaihangmua";
            this.loaihangmuaDataGridViewTextBoxColumn.HeaderText = "Loại hàng mua";
            this.loaihangmuaDataGridViewTextBoxColumn.Name = "loaihangmuaDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng mua";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày mua";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // giatienDataGridViewTextBoxColumn
            // 
            this.giatienDataGridViewTextBoxColumn.DataPropertyName = "giatien";
            this.giatienDataGridViewTextBoxColumn.HeaderText = "Gía tiền";
            this.giatienDataGridViewTextBoxColumn.Name = "giatienDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // inHoaDonsBindingSource
            // 
            this.inHoaDonsBindingSource.DataMember = "inHoaDons";
            this.inHoaDonsBindingSource.DataSource = this.iM22DataSet;
            // 
            // iM22DataSet
            // 
            this.iM22DataSet.DataSetName = "IM22DataSet";
            this.iM22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inHoaDonsTableAdapter
            // 
            this.inHoaDonsTableAdapter.ClearBeforeFill = true;
            // 
            // formXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Name = "formXemHoaDon";
            this.Text = "formXemHoaDon";
            this.Load += new System.EventHandler(this.formXemHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton bt_xuathoadon;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox tb_tenkhach;
        private System.Windows.Forms.Label lb_tenkhach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IM22DataSet iM22DataSet;
        private System.Windows.Forms.BindingSource inHoaDonsBindingSource;
        private IM22DataSetTableAdapters.inHoaDonsTableAdapter inHoaDonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangmuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaihangmuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
    }
}