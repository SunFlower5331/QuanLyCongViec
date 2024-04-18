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
    public partial class FormThongKeKetQuaCongViec : Form
    {
        public FormThongKeKetQuaCongViec()
        {
            InitializeComponent();
            
            //dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dataGridView1.EnableHeadersVisualStyles = false;
        //    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dataGridView1.Columns[i].HeaderCell.Style.SelectionBackColor = dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);

        //            row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
        //            row.Cells[i].Style.ForeColor = Color.White;

        //        }
        //    }
        //}

        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormThongKeKetQuaCongViec_MouseDown(object sender, MouseEventArgs e)
        {  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //

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
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                labelMaNV.Text = "Mã nhân viên";
                labelThongKeTheo.Text = "Tiến độ";
                button1.Text = "Thống kê";
                dataGridView1.Columns["MaNV"].HeaderText = "Mã NV";
                dataGridView1.Columns["TenNV"].HeaderText = "Tên NV";
                dataGridView1.Columns["TenCongViec"].HeaderText = "Tên Công Việc";
                dataGridView1.Columns["TongTG"].HeaderText = "Tổng Thời Gian";
                dataGridView1.Columns["BanGiao"].HeaderText = "Bàn Giao";
            }
            else if (selectedLanguage == "English")
            {
                labelMaNV.Text = "Employee ID";
                labelThongKeTheo.Text = "Progress";
                button1.Text = "Statistics";
                dataGridView1.Columns["MaNV"].HeaderText = "Employee ID";
                dataGridView1.Columns["TenNV"].HeaderText = "Employee Name";
                dataGridView1.Columns["TenCongViec"].HeaderText = "Job Title";
                dataGridView1.Columns["TongTG"].HeaderText = "Total Time";
                dataGridView1.Columns["BanGiao"].HeaderText = "Handover";
            }
        }

        private void FormThongKeKetQuaCongViec_Load(object sender, EventArgs e)
        {
            UpdateLanguage();
        }
    }
}
