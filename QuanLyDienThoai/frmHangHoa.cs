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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {

            this.rpvBCHangHoa.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = QuanLyDienThoai.Properties.Settings.Default.QuanLyDienThoaiConnetString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCHHTheoNgay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NgayBan", dtpNgayBan.Value.Date));

            //Khai bao dataset
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);

            //Thiet lap bao cao 
            rpvBCHangHoa.ProcessingMode = ProcessingMode.Local;
            rpvBCHangHoa.LocalReport.ReportPath = "rptBCHangHoa.rdlc";

            MessageBox.Show(ds.Tables[0].Rows.Count.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsHangHoa";
                rds.Value = ds.Tables[0];

                //Gan len mau bao cao 
                rpvBCHangHoa.LocalReport.DataSources.Clear();
                rpvBCHangHoa.LocalReport.DataSources.Add(rds);
                rpvBCHangHoa.RefreshReport();
            }
        }
    
    }
}
