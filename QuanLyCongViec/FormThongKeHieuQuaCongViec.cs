using LiveCharts.Wpf;
using LiveCharts;
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
using DAL;
using System.Data.SqlClient;
using DTO;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing.Printing;

namespace QuanLyCongViec
{
    public partial class FormThongKeHieuQuaCongViec : Form
    {
        public FormThongKeHieuQuaCongViec()
        {
            InitializeComponent();
            labelDeMucBieuDo.Hide();
            labelDeMucBieuDo2.Hide();
            comboBoThongKe1.SelectedIndex = comboBoThongKe2.SelectedIndex = comboBoxPB.SelectedIndex = 0;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            //dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            //dataGridView2.CellFormatting += dataGridView2_CellFormatting;
        }

        //private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dataGridView1.EnableHeadersVisualStyles = false;
        //    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(246, 191, 2);
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dataGridView1.Columns[i].HeaderCell.Style.SelectionBackColor = dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(175, 2, 0);

        //            row.Cells[i].Style.BackColor = Color.White;
        //            row.Cells[i].Style.ForeColor = Color.Black;

        //        }
        //    }
        //}
        //private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dataGridView2.EnableHeadersVisualStyles = false;
        //    dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(246, 191, 2);
        //    foreach (DataGridViewRow row in dataGridView2.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dataGridView2.Columns[i].HeaderCell.Style.SelectionBackColor = dataGridView2.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(175, 2, 0);

        //            row.Cells[i].Style.BackColor = Color.White;
        //            row.Cells[i].Style.ForeColor = Color.Black;

        //        }
        //    }
        //}

        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormThongKeHieuQuaCongViec_MouseDown(object sender, MouseEventArgs e)
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

        private void loadThongKeHieuQuaCVNV(string maPB, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dataGridView1.Columns.Clear();
            if (comboBoThongKe1.Text == "Tổng quan")
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVTongQuan(maPB, NgayBatDau, NgayKetThuc).Tables[0];

            }
            else
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVChiTiet(maPB, NgayBatDau, NgayKetThuc).Tables[0];

                dataGridView1.Columns["maCV"].HeaderText = "Mã công việc";
                dataGridView1.Columns["ten"].HeaderText = "Tên công việc";
                dataGridView1.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            }
            dataGridView1.Columns["solanchuahoanthanh"].HeaderText = "Chưa hoàn thành";
            dataGridView1.Columns["solantrehan"].HeaderText = "Trễ hạn";
            dataGridView1.Columns["solankhonghoanthanh"].HeaderText = "Không hoàn thành";
            dataGridView1.Columns["solanhoanthanhdunghan"].HeaderText = "Hoàn thành đúng hạn";
            dataGridView1.Columns["solanhoanthanhsom"].HeaderText = "Hoàn thành sớm";

        }

        private void loadThongKeHieuQuaCVPB(string maNV, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dataGridView2.Columns.Clear();
            if (comboBoThongKe2.Text == "Tổng quan")
            {
                dataGridView2.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBTongQuan(maNV, NgayBatDau, NgayKetThuc).Tables[0];

                dataGridView2.Columns["doanhthu"].HeaderText = "Doanh thu";
            }
            else
            {
                dataGridView2.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBChiTiet(maNV, NgayBatDau, NgayKetThuc).Tables[0];

                dataGridView2.Columns["maNV"].HeaderText = "Mã nhân viên";
                dataGridView2.Columns["hoten"].HeaderText = "Họ tên";
                dataGridView2.Columns["luong"].HeaderText = "Lương";
            }
            dataGridView2.Columns["solanchuahoanthanh"].HeaderText = "Chưa hoàn thành";
            dataGridView2.Columns["solantrehan"].HeaderText = "Trễ hạn";
            dataGridView2.Columns["solankhonghoanthanh"].HeaderText = "Không hoàn thành";
            dataGridView2.Columns["solanhoanthanhdunghan"].HeaderText = "Hoàn thành đúng hạn";
            dataGridView2.Columns["solanhoanthanhsom"].HeaderText = "Hoàn thành sớm";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show table
            loadThongKeHieuQuaCVNV(textboxMaNV.Text, dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);

            //show chart
            DataSet data = GetDataFromSQLNV(textboxMaNV.Text, dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
            if (data.Tables[0].Rows.Count > 0)
            {
                LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
                pieChart.Width = 225;
                pieChart.Height = 225;
                pieChart.BackColorTransparent = true;

                SeriesCollection seriesCollection = new SeriesCollection();

                DataRow row = data.Tables[0].Rows[0];
                seriesCollection.Add(new PieSeries
                {
                    Title = "Chưa hoàn thành",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanchuahoanthanh"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Trễ hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solantrehan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Không hoàn thành",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solankhonghoanthanh"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành đúng hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhdunghan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành sớm",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhsom"]) },
                    DataLabels = true
                });

                pieChart.Series = seriesCollection;
                this.panel1.Controls.Clear();
                this.panel1.Controls.Add(pieChart);
                labelDeMucBieuDo.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // show table
            loadThongKeHieuQuaCVPB(comboBoxPB.Text, dateTimePickerStart2.Value.AddDays(-1), dateTimePickerEnd2.Value);

            //show chart
            DataSet data = GetDataFromSQLPB(comboBoxPB.Text, dateTimePickerStart2.Value.AddDays(-1), dateTimePickerEnd2.Value);
            if (data.Tables[0].Rows.Count > 0)
            {
                LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
                pieChart.Width = 225;
                pieChart.Height = 225;
                pieChart.BackColorTransparent = true;

                SeriesCollection seriesCollection = new SeriesCollection();

                DataRow row = data.Tables[0].Rows[0];
                seriesCollection.Add(new PieSeries
                {
                    Title = "Chưa hoàn thành",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanchuahoanthanh"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Trễ hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solantrehan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Không hoàn thành",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solankhonghoanthanh"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành đúng hạn",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhdunghan"]) },
                    DataLabels = true
                });
                seriesCollection.Add(new PieSeries
                {
                    Title = "Hoàn thành sớm",
                    Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhsom"]) },
                    DataLabels = true
                });

                pieChart.Series = seriesCollection;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(pieChart);
                labelDeMucBieuDo2.Show();
            }
        }

        private DataSet GetDataFromSQLNV(string maNV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVTongQuan(maNV, ngayBatDau, ngayKetThuc);
        }

        private DataSet GetDataFromSQLPB(string maPB, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBTongQuan(maPB, ngayBatDau, ngayKetThuc);
        }

        private void buttonXuatPDF_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
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
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Xuất dữ liệu sang PDF thành công!", "Info");
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Export data to PDF successfully!", "Info");
                    }
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xuất ra PDF!", "Info");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("No data found to export to PDF!", "Info");
                }
            }
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

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dataGridView1);
                    Process.Start(saveFileDialog.FileName);
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Xuất file thành công!");
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Export file successfully!");
                    }
                }
                catch (Exception ex)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("An error occurred while exporting the file\n" + ex.Message);
                    }
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


        private void buttonExportExcel2_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dataGridView2);
                    Process.Start(saveFileDialog.FileName);
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Xuất file thành công!");
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Export file successfully!");
                    }
                }
                catch (Exception ex)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("An error occurred while exporting the file\n" + ex.Message);
                    }
                }
            }
        }

        private void buttonXuatPDF2_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dataGridView2);
                    var pdfFile = TransferHtmlToPdf(htmlContent, saveFileDialog.FileName);
                    Process.Start(pdfFile);
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Xuất dữ liệu sang PDF thành công!", "Info");
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Export data to PDF successfully!", "Info");
                    }
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xuất ra PDF!", "Info");
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("You do not have permission to access the application!");
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                tabControl1.TabPages[0].Text = "Nhân viên";
                tabControl1.TabPages[1].Text = "Bộ phận";
                minimize.Text = "Thu nhỏ";
                logout.Text = "Đăng xuất";
                labelNgayBatDau.Text = "Ngày bắt đầu";
                labelMaNV.Text = "Mã NV";
                button1.Text = "Thống kê";
                textboxMaNV.Text = "Mã NV";
                labelDeMucBieuDo.Text = "Đề mục biểu đồ";
                labelNgayKetThuc.Text = "Ngày kết thúc";
                groupBox1.Text = "Thống kê theo";
                groupBox2.Text = "Thống kê";


                buttonXuatPDF.Text = "Xuất PDF";
                buttonExportExcel.Text = "Xuất Excel";

                buttonXuatPDF2.Text = "Xuất PDF";
                buttonExportExcel2.Text = "Xuất Excel";

                // Cập nhật các thành phần khác tương ứng nếu cần
            }
            else if (selectedLanguage == "English")
            {
                labelDeMucBieuDo.Text = "Employee work completion rate";
                tabControl1.TabPages[0].Text = "Employee";
                tabControl1.TabPages[1].Text = "Department";
                minimize.Text = "Minimize";
                logout.Text = "Logout";

                labelNgayBatDau.Text = "Start Date";
                labelMaNV.Text = "Employee ID";
                button1.Text = "Statistic";
                textboxMaNV.Text = "Employee ID";
                labelDeMucBieuDo.Text = "Chart Title";
                labelNgayKetThuc.Text = "End Date";
                groupBox1.Text = "Statistics";

                buttonXuatPDF.Text = "Export PDF";
                buttonExportExcel.Text = "Export Excel";

                buttonXuatPDF2.Text = "Export PDF";
                buttonExportExcel2.Text = "Export Excel";

                // Cập nhật các thành phần khác tương ứng nếu cần
            }
        }

        private void FormThongKeHieuQuaCongViec_Load(object sender, EventArgs e)
        {
            UpdateLanguage();
        }
    }
}