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
using System.Text.RegularExpressions;
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
                cbogioitinh.Text = nv.gioitinh;
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
            UpdateLanguage();
        }

        private void sua(object sender, EventArgs e)
        {
            button1.Enabled = true;
            txtHoTen.ReadOnly = txtDiaChi.ReadOnly = txtDienThoai.ReadOnly = false;
            mk.ReadOnly = false;      
        }
        private bool KiemTraDuLieuNhap()
        {
            string selectedLanguage = GlobalSettings.Language;
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
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin vào các ô!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please enter all information in the boxes!");
                }
                return false;
            }
            return true;
        }
        private void luu(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (!KiemTraDuLieuNhap())
            {
                return; // Nếu thông tin không đầy đủ, không thực hiện cập nhật
            }

            double luong;
            if (!double.TryParse(txtLuong.Text, out luong))
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Please enter a valid number for salary!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please enter all information in the boxes!");
                }

                return;
            }
            // check sđt
            string didong = txtDienThoai.Text;
            didong = new string(didong.Where(char.IsDigit).ToArray()); // Loại bỏ các ký tự không phải số
            if (didong.Length != 10) // Kiểm tra độ dài phải là 10 (ví dụ cho số điện thoại di động)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Invalid phone number!");
                }

                return;
            }
            if (!int.TryParse(didong, out _))
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Vui lòng nhập một số điện thoại hợp lệ!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please enter a valid phone number!");
                }

                return;
            }
            //check email
            string email = txtEmail.Text;
            if (!IsValidEmail(email))
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin vào các ô!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please enter a valid email address!");
                }
                return;
            }

            //check quyenhan
            int quyenhan = Convert.ToInt32(cboquyenhan.Text);

            if (quyenhan < 1 || quyenhan > 3)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("quyền hạn chỉ có thể là 1, 2 hoặc 3.");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("powers can only be 1, 2 or 3.");
                }

                return;
            }
            // Tiếp tục với quá trình cập nhật dữ liệu
            string manv = txbmnv.Text;
            string hoten = txtHoTen.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string gioitinh = cbogioitinh.Text;
            string diachi = txtDiaChi.Text;

            string chucvu = txtChucVu.Text;
            string phongban = txtPhongBan.Text;
            string trangthai = txtTrangThai.Text;
            string trinhdohocvan = txtTrinhDoHocVan.Text;
            string loaihinh = txtLoaiHinh.Text;
            string tendangnhap = txbtentk.Text;
            string matkhau = mk.Text;

            int loaitaikhoan = Convert.ToInt32(cboquyenhan.Text);
            // Gọi phương thức cập nhật dữ liệu trong cơ sở dữ liệu
            bool result = DatabaseAccess.CapNhatThongTinNhanVien(manv, hoten, ngaysinh, gioitinh, diachi, didong, email, chucvu, phongban, luong, trangthai, trinhdohocvan, loaihinh, quyenhan);
            bool result2 = DatabaseAccess.CapNhatThongTinTaiKhoan(tendangnhap, matkhau, loaitaikhoan);

            // Kiểm tra kết quả và hiển thị thông báo
            if (result && result2)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Successfully updated!");
                }

                button1.Enabled = false;
                txtHoTen.Enabled = dtpNgaySinh.Enabled = txtDiaChi.Enabled = cbogioitinh.Enabled = txtDienThoai.Enabled = txtEmail.Enabled = false;
                txbmnv.Enabled = txtChucVu.Enabled = txtLuong.Enabled = txtLoaiHinh.Enabled = txtPhongBan.Enabled = txtTrangThai.Enabled = txtTrinhDoHocVan.Enabled = cboquyenhan.Enabled = false;
                mk.Enabled = false;
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Cập nhật thông tin thất bại!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Update information failed!");
                }

            }
        }

        // check format email
        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            // Kiểm tra sự khớp của email với biểu thức chính quy
            return Regex.IsMatch(email, pattern);
        }
        private void Form_FormThongTinCaNhanClosing(object sender, FormClosingEventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            // Kiểm tra nếu người dùng chọn đóng cửa sổ bằng nút "X" (nút đóng cửa sổ)
            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Hiển thị hộp thoại xác nhận
                if (selectedLanguage == "Vietnamese")
                {
                    result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (selectedLanguage == "English")
                {
                    result = MessageBox.Show("Do you want to exit the program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

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

        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                groupBox3.Text = "Thông tin tài khoản";
                groupBox1.Text = "Thông tin cá nhân";
                groupBox2.Text = "Thông tin hợp đồng";


                didong.Text = "Di động:";
                ngaysinh.Text = "Ngày sinh:";
                hoten.Text = "Họ tên:";
                email.Text = "Email:";
                diachi.Text = "Địa chỉ:";
                trinhdohocvan.Text = "Trình độ học vấn:";
                gioitinh.Text = "Giới tính:";
                loaihinh.Text = "Loại hình:";

                phongban.Text = "Phòng ban:";
                luong.Text = "Lương:";
                trangthai.Text = "Trạng thái:";
                chucvu.Text = "Chức vụ:";
                manv.Text = "Mã nhân viên:";
                button1.Text = "Lưu";
                capquyenhan.Text = "Cấp quyền hạn:";
                matkhau.Text = "Mật khẩu:";
                tendangnhap.Text = "Tên đăng nhập:";
                button3.Text = "Sửa";
                hienmk.Text = "Hiện mật khẩu";
            }
            else if (selectedLanguage == "English")
            {
                groupBox3.Text = "Account Information";
                groupBox1.Text = "Personal Information";
                groupBox2.Text = "Contract Information";

                didong.Text = "Mobile:";
                ngaysinh.Text = "Date of Birth:";
                hoten.Text = "Full Name:";
                email.Text = "Email:";
                diachi.Text = "Address:";
                trinhdohocvan.Text = "Education Level:";
                gioitinh.Text = "Gender:";
                loaihinh.Text = "Type:";

                phongban.Text = "Department:";
                luong.Text = "Salary:";
                trangthai.Text = "Status:";
                chucvu.Text = "Position:";
                manv.Text = "Employee Code:";
                button1.Text = "Save";
                capquyenhan.Text = "Permission:";
                matkhau.Text = "Password:";
                tendangnhap.Text = "UserID:";
                button3.Text = "Edit";
                hienmk.Text = "Show password";
            }

        }
    }
}

