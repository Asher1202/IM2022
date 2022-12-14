namespace InventoryManager2022.Forms
{
    partial class formThanhToan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.inHoaDonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iM22DataSet = new InventoryManager2022.IM22DataSet();
            this.tb_loaihangmua = new System.Windows.Forms.TextBox();
            this.lb_loaihangmua = new System.Windows.Forms.Label();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.tb_slmua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_soluongmua = new System.Windows.Forms.Label();
            this.tb_diachi1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_ngaymua = new System.Windows.Forms.Label();
            this.bt_thanhtoan = new FontAwesome.Sharp.IconButton();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sphammua = new System.Windows.Forms.TextBox();
            this.tb_tenkhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangmuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHoaDonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inHoaDonsTableAdapter = new InventoryManager2022.IM22DataSetTableAdapters.inHoaDonsTableAdapter();
            this.nhapHangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tb_manv);
            this.panel1.Controls.Add(this.tb_loaihangmua);
            this.panel1.Controls.Add(this.lb_loaihangmua);
            this.panel1.Controls.Add(this.tb_tongtien);
            this.panel1.Controls.Add(this.tb_slmua);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_soluongmua);
            this.panel1.Controls.Add(this.tb_diachi1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lb_ngaymua);
            this.panel1.Controls.Add(this.bt_thanhtoan);
            this.panel1.Controls.Add(this.lb_diachi);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_sphammua);
            this.panel1.Controls.Add(this.tb_tenkhach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 182);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_manv
            // 
            this.tb_manv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "MaNV", true));
            this.tb_manv.Location = new System.Drawing.Point(984, 3);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(57, 20);
            this.tb_manv.TabIndex = 23;
            this.tb_manv.Visible = false;
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
            // tb_loaihangmua
            // 
            this.tb_loaihangmua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "loaihangmua", true));
            this.tb_loaihangmua.Enabled = false;
            this.tb_loaihangmua.Location = new System.Drawing.Point(153, 147);
            this.tb_loaihangmua.Name = "tb_loaihangmua";
            this.tb_loaihangmua.Size = new System.Drawing.Size(112, 20);
            this.tb_loaihangmua.TabIndex = 5;
            // 
            // lb_loaihangmua
            // 
            this.lb_loaihangmua.AutoSize = true;
            this.lb_loaihangmua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lb_loaihangmua.Location = new System.Drawing.Point(12, 145);
            this.lb_loaihangmua.Name = "lb_loaihangmua";
            this.lb_loaihangmua.Size = new System.Drawing.Size(138, 22);
            this.lb_loaihangmua.TabIndex = 22;
            this.lb_loaihangmua.Text = "Loại hàng mua :";
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "giatien", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tb_tongtien.Location = new System.Drawing.Point(554, 80);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.Size = new System.Drawing.Size(200, 20);
            this.tb_tongtien.TabIndex = 7;
            // 
            // tb_slmua
            // 
            this.tb_slmua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.tb_slmua.Location = new System.Drawing.Point(153, 110);
            this.tb_slmua.Name = "tb_slmua";
            this.tb_slmua.Size = new System.Drawing.Size(112, 20);
            this.tb_slmua.TabIndex = 4;
            this.tb_slmua.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.tb_slmua.Validated += new System.EventHandler(this.tb_slmua_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.Location = new System.Drawing.Point(418, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tổng giá tiền :";
            // 
            // lb_soluongmua
            // 
            this.lb_soluongmua.AutoSize = true;
            this.lb_soluongmua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lb_soluongmua.Location = new System.Drawing.Point(12, 109);
            this.lb_soluongmua.Name = "lb_soluongmua";
            this.lb_soluongmua.Size = new System.Drawing.Size(130, 22);
            this.lb_soluongmua.TabIndex = 17;
            this.lb_soluongmua.Text = "Số lượng mua :";
            // 
            // tb_diachi1
            // 
            this.tb_diachi1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "diachi", true));
            this.tb_diachi1.Location = new System.Drawing.Point(153, 77);
            this.tb_diachi1.Name = "tb_diachi1";
            this.tb_diachi1.Size = new System.Drawing.Size(112, 20);
            this.tb_diachi1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inHoaDonsBindingSource, "date", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(554, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // lb_ngaymua
            // 
            this.lb_ngaymua.AutoSize = true;
            this.lb_ngaymua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lb_ngaymua.Location = new System.Drawing.Point(418, 44);
            this.lb_ngaymua.Name = "lb_ngaymua";
            this.lb_ngaymua.Size = new System.Drawing.Size(101, 22);
            this.lb_ngaymua.TabIndex = 14;
            this.lb_ngaymua.Text = "Ngày mua :";
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bt_thanhtoan.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.bt_thanhtoan.IconColor = System.Drawing.Color.Black;
            this.bt_thanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_thanhtoan.IconSize = 30;
            this.bt_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thanhtoan.Location = new System.Drawing.Point(600, 119);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(134, 36);
            this.bt_thanhtoan.TabIndex = 13;
            this.bt_thanhtoan.Text = "     &Thanh toán";
            this.bt_thanhtoan.UseVisualStyleBackColor = true;
            this.bt_thanhtoan.Click += new System.EventHandler(this.bt_thanhtoan_Click);
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lb_diachi.Location = new System.Drawing.Point(12, 76);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(75, 22);
            this.lb_diachi.TabIndex = 10;
            this.lb_diachi.Text = "Địa chỉ :";
            // 
            // tb_sdt
            // 
            this.tb_sdt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "phone", true));
            this.tb_sdt.Location = new System.Drawing.Point(554, 17);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(112, 20);
            this.tb_sdt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(418, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại :";
            // 
            // tb_sphammua
            // 
            this.tb_sphammua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "hangmua", true));
            this.tb_sphammua.Location = new System.Drawing.Point(153, 13);
            this.tb_sphammua.Name = "tb_sphammua";
            this.tb_sphammua.Size = new System.Drawing.Size(112, 20);
            this.tb_sphammua.TabIndex = 1;
            // 
            // tb_tenkhach
            // 
            this.tb_tenkhach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inHoaDonsBindingSource, "customerID", true));
            this.tb_tenkhach.Location = new System.Drawing.Point(153, 44);
            this.tb_tenkhach.Name = "tb_tenkhach";
            this.tb_tenkhach.Size = new System.Drawing.Size(112, 20);
            this.tb_tenkhach.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản phẩm mua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 292);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.hangmuaDataGridViewTextBoxColumn,
            this.giatienDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inHoaDonsBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 182);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1044, 292);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Mã đơn hàng";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ khách hàng";
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
            this.dateDataGridViewTextBoxColumn.HeaderText = "Thời gian mua";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // hangmuaDataGridViewTextBoxColumn
            // 
            this.hangmuaDataGridViewTextBoxColumn.DataPropertyName = "hangmua";
            this.hangmuaDataGridViewTextBoxColumn.HeaderText = "Tên hàng mua";
            this.hangmuaDataGridViewTextBoxColumn.Name = "hangmuaDataGridViewTextBoxColumn";
            // 
            // giatienDataGridViewTextBoxColumn
            // 
            this.giatienDataGridViewTextBoxColumn.DataPropertyName = "giatien";
            this.giatienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.giatienDataGridViewTextBoxColumn.Name = "giatienDataGridViewTextBoxColumn";
            // 
            // inHoaDonsBindingSource1
            // 
            this.inHoaDonsBindingSource1.DataMember = "inHoaDons";
            this.inHoaDonsBindingSource1.DataSource = this.iM22DataSet;
            // 
            // inHoaDonsTableAdapter
            // 
            this.inHoaDonsTableAdapter.ClearBeforeFill = true;
            // 
            // nhapHangHoasBindingSource
            // 
            this.nhapHangHoasBindingSource.DataMember = "NhapHangHoas";
            // 
            // formThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 474);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "formThanhToan";
            this.Text = "formKhachHang";
            this.Load += new System.EventHandler(this.formKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iM22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapHangHoasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton bt_thanhtoan;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sphammua;
        private System.Windows.Forms.TextBox tb_tenkhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_ngaymua;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_diachi1;
        private System.Windows.Forms.Label lb_soluongmua;
        private System.Windows.Forms.DataGridView dataGridView2;
        private IM22DataSet iM22DataSet;
        private System.Windows.Forms.BindingSource inHoaDonsBindingSource;
        private IM22DataSetTableAdapters.inHoaDonsTableAdapter inHoaDonsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource nhapHangHoasBindingSource;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.TextBox tb_slmua;
        private System.Windows.Forms.TextBox tb_loaihangmua;
        private System.Windows.Forms.Label lb_loaihangmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangmuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inHoaDonsBindingSource1;
        private System.Windows.Forms.TextBox tb_manv;
    }
}