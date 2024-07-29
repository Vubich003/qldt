using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using QuanLyDienThoai.Class;
namespace QuanLyDienThoai
{
    public partial class frmDMHangDienThoai : Form
    {
        DataTable tblHangDT;
        public frmDMHangDienThoai()
        {
            InitializeComponent();
        }

        private void frmDMHangDienThoai_Load(object sender, EventArgs e)
        {
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblHangDT
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaHangDT, TenHangDT FROM tblHangDT";
            tblHangDT = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvHangDienThoai.DataSource = tblHangDT; //Nguồn dữ liệu            
            dgvHangDienThoai.Columns[0].HeaderText = "Mã Hãng Điện Thoại";
            dgvHangDienThoai.Columns[1].HeaderText = "Tên Hãng Điện Thoại";
            dgvHangDienThoai.Columns[0].Width = 100;
            dgvHangDienThoai.Columns[1].Width = 300;
            dgvHangDienThoai.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvHangDienThoai.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvHangDienThoai_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (tblHangDT.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHang.Text = dgvHangDienThoai.CurrentRow.Cells["MaHangDT"].Value.ToString();
            txtTenHang.Text = dgvHangDienThoai.CurrentRow.Cells["TenHangDT"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

       
        private void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaHang.Enabled = true; //cho phép nhập mới
            txtMaHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaHang.Text.Trim().Length == 0) //Nếu chưa nhập mã hãng điện thoại
            {
                MessageBox.Show("Bạn phải nhập mã hãng điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên hãng điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            sql = "Select MaHangDT From tblHangDT where MaHangDT=N'" + txtMaHang.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hãng  này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                return;
            }

            sql = "INSERT INTO tblHangDT VALUES(N'" +
                txtMaHang.Text + "',N'" + txtTenHang.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblHangDT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên hãng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblHangDT SET TenHangDT=N'" +
                txtTenHang.Text.ToString() +
                "' WHERE MaHangDT=N'" + txtMaHang.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHangDT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHangDT WHERE MaHangDT=N'" + txtMaHang.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void txtMaHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    
