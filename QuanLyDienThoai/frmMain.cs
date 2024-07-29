using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuHangDienThoai_Click(object sender, EventArgs e)
        {
            frmDMHangDienThoai frm = new frmDMHangDienThoai(); //Khởi tạo đối tượng
            frm.ShowDialog(); //Hiển thị
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien(); //Khởi tạo đối tượng
            frm.Show(); //Hiển thị
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa(); //Khởi tạo đối tượng
            frm.Show(); //Hiển thị
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang(); //Khởi tạo đối tượng
            frm.Show(); //Hiển thị
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan(); //Khởi tạo đối tượng
            frm.Show(); //Hiển thị
   
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHDBan frm = new frmTimKiemHDBan(); //Khởi tạo đối tượng
            frm.Show(); //Hiển thị
        }

        private void mnuBCDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhthu frm = new frmDoanhthu();
            frm.Show();
        }

        private void mnuBCHangTon_Click(object sender, EventArgs e)
        {
            frmTonKho frm = new frmTonKho();
            frm.Show();
        }

        private void mnuBCHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            frm.Show();
        }

        private void mnuBCHangNhap_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();    
            frm.Show(); 

        }
    }
}
