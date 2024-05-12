using BLL;
using DAL;
using DTO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace QuanLyCongViec
{
    public partial class FormLogin : Form
    {
        TaiKhoan tk = new TaiKhoan();
        TaiKhoanBLL tkBLL= new TaiKhoanBLL();
        public FormLogin()
        {
            InitializeComponent();
            user.KeyDown += user_KeyDown;
            pass.KeyDown += pass_KeyDown;

        }
        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // check xem nếu checkbox đã được đánh hoặc để mặc định 
            if (checkBoxHTMK.Checked || pass.Text == "Password")
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxHTMK_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxHTMK.Checked || pass.Text == "Password")
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;

            }
        }

        private void dangnhap_Click_1(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                FormMain fm = new FormMain();
                fm.Show();
                this.Hide();
               
            }
                
           
            
        }


        private bool CheckLogin()
        {
            string selectedLanguage = GlobalSettings.Language;
            tk.id = user.Text;
            tk.mk = pass.Text;
            string getUser = tkBLL.CheckLogic(tk);
            switch (getUser)
            {
                case "Require_taikhoan":

                        // Dựa vào ngôn ngữ được chọn, trả về các chuỗi văn bản tương ứng
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Tài khoản không được để trống");
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("Account cannot be empty");
                        }
                    return false;

                case "Require_matkhau":
                    // Dựa vào ngôn ngữ được chọn, trả về các chuỗi văn bản tương ứng
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Mật khẩu không được để trống");
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("Password cannot be empty");
                        }
                    return false;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    // Dựa vào ngôn ngữ được chọn, trả về các chuỗi văn bản tương ứng
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("You do not have permission to access the applicationy!");
                        }
                    return false;
            }

            Program.UserID = tk.id;
            string trangthai = DatabaseAccess.getloaihinh(tk.id);
            if (string.Equals(trangthai, "Đã nghĩ việc", StringComparison.OrdinalIgnoreCase))
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào ứng dụng!!");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("You do not have access to the application!");
                }
                return false;
            }

            return true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ngonngu.SelectedIndex = 0;
            UpdateLanguage(); // Gọi hàm cập nhật ngôn ngữ khi form được khởi tạo

        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;

            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (selectedLanguage == "Vietnamese")
                {
                    result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (selectedLanguage == "English")
                {
                    result = MessageBox.Show("Do you want to exit the program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                   
                    e.Cancel = true;
                }
            }
        }

       
        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "User ID" || user.Text == "Tên người dùng")
            {
                user.Text = "";
                user.ForeColor = Color.White;
            }
        }
        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Mật khẩu" || pass.Text == "Password")
            {
                pass.Text = "";
                pass.ForeColor = Color.White;
            }
        }

      
        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                if (GlobalSettings.Language == "Vietnamese")
                {
                    user.Text = "Tên người dùng";
                }
                else
                {
                    user.Text = "User ID";
                }
                user.ForeColor = Color.LightGray;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                if (GlobalSettings.Language == "Vietnamese")
                {
                    pass.Text = "Mật khẩu";
                }
                else
                {
                    pass.Text = "Password";
                }
                pass.ForeColor = Color.LightGray;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void quenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau form = new FormQuenMatKhau();
            form.Show();
            this.Hide();
        }

        // Xử lý sự kiện khi chọn ngôn ngữ
        private void ngonngu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật ngôn ngữ thông qua biến global
            GlobalSettings.Language = ngonngu.SelectedItem.ToString();
            // Gọi hàm cập nhật ngôn ngữ
            UpdateLanguage();
        }

        // Hàm cập nhật ngôn ngữ
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ được chọn từ biến global
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật các chuỗi văn bản tùy thuộc vào ngôn ngữ được chọn
            if (selectedLanguage == "Vietnamese")
            {
                // Đặt lại tất cả các văn bản trong form thành tiếng Việt
                user.Text = "Tên người dùng";
                label4.Text = "Chào mừng trở lại!";
                //label5.Text = "với";
                pass.Text = "Mật khẩu";
                checkBoxHTMK.Text = "Hiện mật khẩu";
                dangnhap.Text = "Đăng nhập";
                quenPass.Text = "Quên mật khẩu";
                //label3.Text = "Đăng nhập";
                // Cập nhật các văn bản khác tương ứng nếu cần
            }
            else if (selectedLanguage == "English")
            {

                label4.Text = "Welcome Back!";
                //label5.Text = "To";
                // Đặt lại tất cả các văn bản trong form thành tiếng Anh
                user.Text = "User ID";
                pass.Text = "Password";
                checkBoxHTMK.Text = "Show password";
                dangnhap.Text = "Login";
                quenPass.Text = "Forget password";
                //label3.Text = "Sign In";
                // Cập nhật các văn bản khác tương ứng nếu cần
            }
        }
        private void user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                pass.Focus(); // Di chuyển tới textBox mật khẩu nếu phím mũi tên xuống được nhấn
            }
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                user.Focus(); // Di chuyển tới textBox tên người dùng nếu phím mũi tên lên được nhấn
            }
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}

