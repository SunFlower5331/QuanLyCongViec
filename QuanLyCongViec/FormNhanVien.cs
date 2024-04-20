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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            UpdateLanguage();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                // Cập nhật các nhãn và các điều khiển khác trong giao diện với ngôn ngữ tiếng Việt
                macanho.Text = "Mã căn hộ";
                maphanquyen.Text = "Mã phân quyền";
                manhanvien.Text = "Mã nhân viên";

                gioitinh.Text = "Giới tính";

            }
            else if (selectedLanguage == "English")
            {
                // Cập nhật các nhãn và các điều khiển khác trong giao diện với ngôn ngữ tiếng Anh
                macanho.Text = "Apartment ID";
                maphanquyen.Text = "Permission ID";
                manhanvien.Text = "Employee ID";

                gioitinh.Text = "Gender";

            }
        }

    }
}
