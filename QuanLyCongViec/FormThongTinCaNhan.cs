using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class FormThongTinCaNhan : Form
    {
        public bool isExit = true;

        public FormThongTinCaNhan()
        {
            InitializeComponent();

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hienmk.Checked)
            {
                mk.UseSystemPasswordChar = false;
            }
            else
            {
                mk.UseSystemPasswordChar = true;
            }
        }


        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            (NhanVien nv, TaiKhoan tk) = DatabaseAccess.layThongTin(Program.UserID);
            if (nv != null)
            {
                // Gắn dữ liệu vào các ô
                txtHoTen.Text = nv.hoten;
                dtpNgaySinh.Value = nv.ngaysinh;
                cboGioiTinh.SelectedItem = nv.gioitinh;
                txtDiaChi.Text = nv.diachi;
                txtDienThoai.Text = nv.didong;
                txtEmail.Text = nv.email;
                txtChucVu.Text = nv.chucvu;
                txtPhongBan.Text = nv.phongban;
                txtLuong.Text = nv.luong.ToString();
                txtTrangThai.Text = nv.trangthai;
                txtTrinhDoHocVan.Text = nv.trinhdohocvan;
                txtLoaiHinh.Text = nv.loaihinh;
                txbmnv.Text = nv.manv;
                cboquyenhan.Text = nv.quyenhan.ToString();
                txbtentk.Text = tk.id;
                mk.Text = tk.mk;


            }
        }

        private void sua(object sender, EventArgs e)
        {
            button1.Enabled = true;
            txtHoTen.ReadOnly = txtDiaChi.ReadOnly = txtDienThoai.ReadOnly = false;
            mk.ReadOnly = false;      
        }
        private bool KiemTraDuLieuNhap()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtDienThoai.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtChucVu.Text) ||
                string.IsNullOrEmpty(txtPhongBan.Text) ||
                string.IsNullOrEmpty(txtLuong.Text) ||
                string.IsNullOrEmpty(txtTrangThai.Text) ||
                string.IsNullOrEmpty(txtTrinhDoHocVan.Text) ||
                string.IsNullOrEmpty(txtLoaiHinh.Text) ||
                string.IsNullOrEmpty(txbmnv.Text) ||
                    string.IsNullOrEmpty(mk.Text))

            {
                MessageBox.Show("Vui lòng nhập đủ thông tin vào các ô!");
                return false;
            }
            return true;
        }
        private void luu(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
            {
                return; // Nếu thông tin không đầy đủ, không thực hiện cập nhật
            }

            double luong;
            if (!double.TryParse(txtLuong.Text, out luong))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ cho lương!");
                return;
            }
            // Tiếp tục với quá trình cập nhật dữ liệu
            string manv = txbmnv.Text;
            string hoten = txtHoTen.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string gioitinh = cboGioiTinh.SelectedItem.ToString();
            string diachi = txtDiaChi.Text;
            string didong = txtDienThoai.Text;
            string email = txtEmail.Text;
            string chucvu = txtChucVu.Text;
            string phongban = txtPhongBan.Text;
            string trangthai = txtTrangThai.Text;
            string trinhdohocvan = txtTrinhDoHocVan.Text;
            string loaihinh = txtLoaiHinh.Text;
            string tendangnhap = txbtentk.Text;
            string matkhau = mk.Text;
            int quyenhan = Convert.ToInt32(cboquyenhan.Text);
            int loaitaikhoan = Convert.ToInt32(cboquyenhan.Text);
            // Gọi phương thức cập nhật dữ liệu trong cơ sở dữ liệu
            bool result = DatabaseAccess.CapNhatThongTinNhanVien(manv, hoten, ngaysinh, gioitinh, diachi, didong, email, chucvu, phongban, luong, trangthai, trinhdohocvan, loaihinh, quyenhan);
            bool result2 = DatabaseAccess.CapNhatThongTinTaiKhoan(tendangnhap, matkhau, loaitaikhoan);

            // Kiểm tra kết quả và hiển thị thông báo
            if (result && result2)
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                button1.Enabled = false;
                txtHoTen.Enabled = dtpNgaySinh.Enabled = txtDiaChi.Enabled = cboGioiTinh.Enabled = txtDienThoai.Enabled = txtEmail.Enabled = false;
                txbmnv.Enabled = txtChucVu.Enabled = txtLuong.Enabled = txtLoaiHinh.Enabled = txtPhongBan.Enabled = txtTrangThai.Enabled = txtTrinhDoHocVan.Enabled = cboquyenhan.Enabled = false;
                mk.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!");
            }
        }
        private void Form_FormThongTinCaNhanClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu người dùng chọn đóng cửa sổ bằng nút "X" (nút đóng cửa sổ)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn "Có", đóng chương trình
                if (result == DialogResult.Yes)
                {
                    // Đóng chương trình
                    Application.Exit();
                }
                else
                {
                    // Hủy sự kiện đóng cửa sổ
                    e.Cancel = true;
                }
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }
        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormThongTinCaNhan_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    
    }
}
