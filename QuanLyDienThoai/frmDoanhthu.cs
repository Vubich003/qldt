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
using Microsoft.Reporting.WinForms;
namespace QuanLyDienThoai
{
    public partial class frmDoanhthu : Form
    {
        public frmDoanhthu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            this.rpvBCDThu.RefreshReport();
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= QuanLyDienThoai.Properties.Settings.Default.QuanLyDienThoaiConnetString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCDTTheoNgay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NgayBan", dtpNgayBan.Value.Date));

            //Khai bao dataset
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);

            //Thiet lap bao cao 
            rpvBCDThu.ProcessingMode = ProcessingMode.Local;
            rpvBCDThu.LocalReport.ReportPath = "rptBCDThu.rdlc";

            //MessageBox.Show(ds.Tables[0].Rows.Count.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds= new ReportDataSource();
                rds.Name = "dsDThu";
                rds.Value = ds.Tables[0];

                //Gan len mau bao cao 
                rpvBCDThu.LocalReport.DataSources.Clear();
                rpvBCDThu.LocalReport.DataSources.Add(rds);
                rpvBCDThu.RefreshReport();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

