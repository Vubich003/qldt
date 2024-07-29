using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDienThoai
{

    public partial class frmTonKho : Form
    {
        DataSet ds;
        SqlDataAdapter dap;
        SqlConnection con;
        SqlCommand cmd;

        public frmTonKho()
        {
            InitializeComponent();
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {


            this.rpvBCTKho.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = QuanLyDienThoai.Properties.Settings.Default.QuanLyDienThoaiConnetString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCTKTheoNgay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NgayThang", dtpNgayThang.Value.Date));

            //Khai bao dataset
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);

            //Thiet lap bao cao 
            rpvBCTKho.ProcessingMode = ProcessingMode.Local;
            rpvBCTKho.LocalReport.ReportPath = "rptBCTonKho.rdlc";

            MessageBox.Show(ds.Tables[0].Rows.Count.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsTonKho";
                rds.Value = ds.Tables[0];

                //Gan len mau bao cao 
                rpvBCTKho.LocalReport.DataSources.Clear();
                rpvBCTKho.LocalReport.DataSources.Add(rds);
                rpvBCTKho.RefreshReport();
            }
        }
    
    }
}



