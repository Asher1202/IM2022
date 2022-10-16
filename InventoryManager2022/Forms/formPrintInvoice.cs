using InventoryManager2022.Classes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager2022.Forms
{
    public partial class formPrintInvoice : Form
    {
        public string ttTenKhach { get; set; }
        public string ttTongTien { get; set; }
        public string ttSL { get; set; }

        public string ttSanPham { get; set; }

        public string ttDiachi { get; set; }

        public string ttSDT { get; set; }
        public string ttDate { get; set; }
        public string ttSHD { get; set; }
        formThanhToan fkh = new formThanhToan();
        public formPrintInvoice()
        {
            
            InitializeComponent();
            
        }

        private void formPrintInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                //ReportParameter rp = new ReportParameter("MAHD");
                //rp.Values.Add(formHoaDon.instance.maHD);
                SqlConnection conn = new SqlConnection("Data Source=MSI\\BATRUONG;Initial Catalog=IM22;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getDataHDI";
                cmd.Parameters.Add("@orderID ", SqlDbType.Int).Value = formThanhToan.ttOrderIDD;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "CTHD");
                conn.Close();

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventoryManager2022.Report1.rdlc";
                ReportDataSource ds2 = new ReportDataSource();
                ds2.Name = "DataSet1";
                ds2.Value = ds.Tables["CTHD"];
                this.reportViewer1.LocalReport.DataSources.Add(ds2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
