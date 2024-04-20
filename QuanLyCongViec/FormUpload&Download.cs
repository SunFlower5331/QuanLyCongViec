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
    public partial class FormUpload_Download : Form
    {
        public FormUpload_Download()
        {
            InitializeComponent();
            LoadPdfList();
            //dsTaiLieu.CellFormatting += dsTaiLieu_CellFormatting;
        }
        //private void dsTaiLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dsTaiLieu.EnableHeadersVisualStyles = false;
        //    dsTaiLieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dsTaiLieu.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dsTaiLieu.Columns[i].HeaderCell.Style.SelectionBackColor = dsTaiLieu.Columns[i].HeaderCell.Style.BackColor = Color.Firebrick;

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
        private void FormUpload_Download_MouseDown(object sender, MouseEventArgs e)
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
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }

        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                minimize.Text = "Thu nhỏ";
                logout.Text = "Đăng xuất";
                groupBox2.Text = "Tài liệu";
                FileName.HeaderText = "Tên tập tin";
                NguoiDang.HeaderText = "Người đăng";
                Download.HeaderText = "Tải về";
                groupBox1.Text = "Tìm kiếm";
                button2.Text = "Đặt lại";
                button1.Text = "Tìm kiếm";
                // Cập nhật các thành phần khác tương ứng nếu cần
            }
            else if (selectedLanguage == "English")
            {
                minimize.Text = "Minimize";
                logout.Text = "Log out";
                groupBox2.Text = "Documents";
                FileName.HeaderText = "File Name";
                NguoiDang.HeaderText = "Uploader";
                Download.HeaderText = "Download";
                groupBox1.Text = "Search";
                button2.Text = "Reset";
                button1.Text = "Search";
                // Cập nhật các thành phần khác tương ứng nếu cần
            }
        }

        private void LoadPdfList()
        {
            dsTaiLieu.Columns.Clear();
            dsTaiLieu.DataSource = DatabaseAccess.LoadPdfDataToDataGridView();
            dsTaiLieu.Columns["FileName"].HeaderText = "Tên file";
        }

        private void buttonChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName;
            }
        }

        private void buttonTaiLen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFilePath.Text))
            {
                string filePath = textBoxFilePath.Text;
                bool uploadResult = DatabaseAccess.UploadPdfToDatabase(filePath);
                if (uploadResult)
                {
                    MessageBox.Show("File PDF đã được tải lên cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxFilePath.Clear();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi tải lên file PDF!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadPdfList();
        }

        private void buttonTaiXuong_Click(object sender, EventArgs e)
        {
            if (dsTaiLieu.SelectedRows.Count > 0)
            {
                int selectedPdfId = Convert.ToInt32(dsTaiLieu.SelectedRows[0].Cells["Id"].Value);
                string selectedPdfFileName = dsTaiLieu.SelectedRows[0].Cells["FileName"].Value.ToString();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = selectedPdfFileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    bool downloadResult = DatabaseAccess.DownloadPdfFromDatabase(selectedPdfId, savePath);
                    if (downloadResult)
                    {
                        MessageBox.Show("File PDF đã được tải xuống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi tải xuống file PDF!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tệp PDF để tải xuống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FormUpload_Download_Load(object sender, EventArgs e)
        {
            UpdateLanguage();
        }
    }
}