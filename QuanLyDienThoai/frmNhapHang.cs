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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {

            this.rpvBCHangNhap.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = QuanLyDienThoai.Properties.Settings.Default.QuanLyDienThoaiConnetString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCMHNhapTheoNgay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NgayGH", dtpNgayGH.Value.Date));

            //Khai bao dataset
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);

            //Thiet lap bao cao 
            rpvBCHangNhap.ProcessingMode = ProcessingMode.Local;
            rpvBCHangNhap.LocalReport.ReportPath = "rptBCHangNhap.rdlc";

            //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsHangNhap";
                rds.Value = ds.Tables[0];

                //Gan len mau bao cao 
                rpvBCHangNhap.LocalReport.DataSources.Clear();
                rpvBCHangNhap.LocalReport.DataSources.Add(rds);
                rpvBCHangNhap.RefreshReport();
            }
        }
    
    }
}
