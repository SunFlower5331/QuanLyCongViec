using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace QuanLyCongViec
{
    public partial class FormThongKeKetQuaCongViec : Form
    {
        public FormThongKeKetQuaCongViec()
        {
            InitializeComponent();
            comboBoxTrangThai.SelectedIndex = 0;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
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

        private void loadThongKeKetQuaCV(string maNV, string trangthai)
        {
            dataGridView1.Columns.Clear();
            if (comboBoxTrangThai.Text != "Không hoàn thành")
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeKetQuaCVHoanThanh(maNV, trangthai).Tables[0];
                dataGridView1.Columns["maNV"].HeaderText = "Mã nhân viên";
            }
            else if (comboBoxTrangThai.Text == "Không hoàn thành")
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeKetQuaCVKhongHoanThanh(maNV).Tables[0];
                dataGridView1.Columns["maNV_moi"].HeaderText = "Mã nhân viên mới";
                dataGridView1.Columns["maNV_cu"].HeaderText = "Mã nhân viên cũ";
            }
            else
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thống kê dữ liệu!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.Columns["hoten"].HeaderText = "Tên nhân viên";
            dataGridView1.Columns["ten"].HeaderText = "Tên công việc";
            dataGridView1.Columns["thoigianlam"].HeaderText = "Thời gian làm";
        }


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

        private void button1_Click(object sender, EventArgs e)
        {
            loadThongKeKetQuaCV(textBoxMaNV.Text, comboBoxTrangThai.Text);
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dataGridView1);
                    Process.Start(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                }
            }
        }

        private void ExportExcel(string path, DataGridView data)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < data.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = data.Columns[i].HeaderText;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void buttonXuatPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dataGridView1);
                    var pdfFile = TransferHtmlToPdf(htmlContent, saveFileDialog.FileName);
                    Process.Start(pdfFile);
                    MessageBox.Show("Xuất dữ liệu sang PDF thành công!", "Info");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất ra PDF!", "Info");
            }
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
        private string GetHtmlFromDataGridView(DataGridView dataGridView)
        {
            string fileName = Path.Combine(Path.GetTempPath(), DateTime.Now.ToString("ddMMyyyyhhmmss") + ".html");
            string html = "<!DOCTYPE html><html><head><style>table { border-collapse: collapse; } th, td { border: 1px solid black; padding: 8px; }</style></head><body><table>";

            // Add headers
            html += "<tr>";
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                html += "<th>" + column.HeaderText + "</th>";
            }
            html += "</tr>";

            // Add data
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td>" + cell.Value.ToString() + "</td>";
                }
                html += "</tr>";
            }

            html += "</table></body></html>";

            System.IO.File.WriteAllText(fileName, html);
            return fileName;
        }

        private string TransferHtmlToPdf(string htmlContent, string pdfFilePath)
        {
            string pdfFile = pdfFilePath.Replace(".html", ".pdf");
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            info.Arguments = "--headless --disable-gpu --print-to-pdf=\"" + pdfFile + "\" \"" + htmlContent + "\"";
            info.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = info;
            process.Start();
            process.WaitForExit();

            return pdfFile;
        }
    }
}
