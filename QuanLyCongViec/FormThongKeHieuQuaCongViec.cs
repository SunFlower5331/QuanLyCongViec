using DAL;
using DTO;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyCongViec
{
    public partial class FormThongKeHieuQuaCongViec : Form
    {
        public FormThongKeHieuQuaCongViec()
        {
            InitializeComponent();
            labelDeMucBieuDo.Hide();
            labelDeMucBieuDo2.Hide();
            
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dataGridView1.Columns[i].HeaderCell.Style.SelectionBackColor = dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166); ;

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dataGridView2.Columns[i].HeaderCell.Style.SelectionBackColor = dataGridView2.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166); ;

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }

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
            string selectedLanguage = GlobalSettings.Language;
            dataGridView1.Columns.Clear();
            if (comboBoThongKe1.Text == "Tổng quan" || comboBoThongKe1.Text == "Overview")
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVTongQuan(maPB, NgayBatDau, NgayKetThuc).Tables[0];

            }
            else
            {
                dataGridView1.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVNVChiTiet(maPB, NgayBatDau, NgayKetThuc).Tables[0];
                if (selectedLanguage == "Vietnamese")
                {
                    dataGridView1.Columns["maCV"].HeaderText = "Mã công việc";
                    dataGridView1.Columns["ten"].HeaderText = "Tên công việc";
                    dataGridView1.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                }
                else if (selectedLanguage == "English")
                {
                    dataGridView1.Columns["maCV"].HeaderText = "Task ID";
                    dataGridView1.Columns["ten"].HeaderText = "Task name";
                    dataGridView1.Columns["thoiGianHoanThanh"].HeaderText = "Completion time";
                }
            }
            if (selectedLanguage == "Vietnamese")
            {
                dataGridView1.Columns["solanchuahoanthanh"].HeaderText = "Chưa hoàn thành";
                dataGridView1.Columns["solantrehan"].HeaderText = "Trễ hạn";
                dataGridView1.Columns["solankhonghoanthanh"].HeaderText = "Không hoàn thành";
                dataGridView1.Columns["solanhoanthanhdunghan"].HeaderText = "Hoàn thành đúng hạn";
                dataGridView1.Columns["solanhoanthanhsom"].HeaderText = "Hoàn thành sớm";
            }
            else if (selectedLanguage == "English")
            {
                dataGridView1.Columns["solanchuahoanthanh"].HeaderText = "Not completed";
                dataGridView1.Columns["solantrehan"].HeaderText = "Delayed";
                dataGridView1.Columns["solankhonghoanthanh"].HeaderText = "Incompleted";
                dataGridView1.Columns["solanhoanthanhdunghan"].HeaderText = "On time";
                dataGridView1.Columns["solanhoanthanhsom"].HeaderText = "Early completion";
            }
        }

        private void loadThongKeHieuQuaCVPB(string maNV, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            string selectedLanguage = GlobalSettings.Language;
            dataGridView2.Columns.Clear();
            if (comboBoThongKe2.Text == "Tổng quan" || comboBoThongKe2.Text == "Overview")
            {
                dataGridView2.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBTongQuan(maNV, NgayBatDau, NgayKetThuc).Tables[0];
                if (selectedLanguage == "Vietnamese")
                {
                    dataGridView2.Columns["doanhthu"].HeaderText = "Doanh thu";
                }
                else if (selectedLanguage == "English")
                {
                    dataGridView2.Columns["doanhthu"].HeaderText = "Revenue";
                }

            }
            else
            {
                dataGridView2.DataSource = DatabaseAccess.GetDuLieuThongKeHieuQuaCVPBChiTiet(maNV, NgayBatDau, NgayKetThuc).Tables[0];
                if (selectedLanguage == "Vietnamese")
                {
                    dataGridView2.Columns["maNV"].HeaderText = "Mã nhân viên";
                    dataGridView2.Columns["hoten"].HeaderText = "Họ tên";
                    dataGridView2.Columns["luong"].HeaderText = "Lương";
                }
                else if (selectedLanguage == "English")
                {
                    dataGridView2.Columns["maNV"].HeaderText = "Employee ID";
                    dataGridView2.Columns["hoten"].HeaderText = "Name";
                    dataGridView2.Columns["luong"].HeaderText = "Salary";
                }
            }
            if (selectedLanguage == "Vietnamese")
            {
                dataGridView2.Columns["solanchuahoanthanh"].HeaderText = "Chưa hoàn thành";
                dataGridView2.Columns["solantrehan"].HeaderText = "Trễ hạn";
                dataGridView2.Columns["solankhonghoanthanh"].HeaderText = "Không hoàn thành";
                dataGridView2.Columns["solanhoanthanhdunghan"].HeaderText = "Hoàn thành đúng hạn";
                dataGridView2.Columns["solanhoanthanhsom"].HeaderText = "Hoàn thành sớm";
            }
            else if (selectedLanguage == "English")
            {
                dataGridView2.Columns["solanchuahoanthanh"].HeaderText = "Not completed";
                dataGridView2.Columns["solantrehan"].HeaderText = "Delayed";
                dataGridView2.Columns["solankhonghoanthanh"].HeaderText = "Incompleted";
                dataGridView2.Columns["solanhoanthanhdunghan"].HeaderText = "On time";
                dataGridView2.Columns["solanhoanthanhsom"].HeaderText = "Early completion";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show table
            loadThongKeHieuQuaCVNV(textboxMaNV.Text, dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
            string selectedLanguage = GlobalSettings.Language;
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
                if (selectedLanguage == "Vietnamese")
                {
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Chưa hoàn thành",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanchuahoanthanh"]) },
                        DataLabels = true
                    }); ;
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
                }
                else if (selectedLanguage == "English")
                {
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Not completed",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanchuahoanthanh"]) },
                        DataLabels = true
                    }); ;
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Delayed",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solantrehan"]) },
                        DataLabels = true
                    });
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Incompleted",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solankhonghoanthanh"]) },
                        DataLabels = true
                    });
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "On time",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhdunghan"]) },
                        DataLabels = true
                    });
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Early completion",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhsom"]) },
                        DataLabels = true
                    });
                }

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
            string selectedLanguage = GlobalSettings.Language;
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
                if (selectedLanguage == "Vietnamese")
                {
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Chưa hoàn thành",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanchuahoanthanh"]) },
                        DataLabels = true
                    }); ;
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
                }
                else if (selectedLanguage == "English")
                {
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Not completed",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanchuahoanthanh"]) },
                        DataLabels = true
                    }); ;
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Delayed",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solantrehan"]) },
                        DataLabels = true
                    });
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Incompleted",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solankhonghoanthanh"]) },
                        DataLabels = true
                    });
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "On time",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhdunghan"]) },
                        DataLabels = true
                    });
                    seriesCollection.Add(new PieSeries
                    {
                        Title = "Early completion",
                        Values = new ChartValues<int> { Convert.ToInt32(row["solanhoanthanhsom"]) },
                        DataLabels = true
                    });
                }

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
                    MessageBox.Show("No data found to export to PDF!");
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
                labelNgayBatDau.Text = "Ngày bắt đầu";
                labelNgayBatDau2.Text = "Ngày bắt đầu";
                labelMaNV.Text = "Mã nhân viên";
                labelMaPB.Text = "Mã phòng ban";
                button1.Text = "Thống kê";
                button2.Text = "Thống kê";
                labelDeMucBieuDo.Text = "Tỉ lệ hoàn thành công việc của nhân viên";
                labelDeMucBieuDo2.Text = "Tỉ lệ hoàn thành công việc của phòng ban";
                labelNgayKetThuc.Text = "Ngày kết thúc";
                labelNgayKetThuc2.Text = "Ngày kết thúc";
                labelThongKe.Text = "Thống kê theo";
                labelThongKe2.Text = "Thống kê theo";
                groupBox1.Text = "Thống kê";
                groupBox2.Text = "Thống kê";

                comboBoThongKe1.Items.Add("Tổng quan");
                comboBoThongKe1.Items.Add("Chi tiết");
                comboBoThongKe2.Items.Add("Tổng quan");
                comboBoThongKe2.Items.Add("Chi tiết");


                buttonXuatPDF.Text = "Xuất PDF";
                buttonExportExcel.Text = "Xuất Excel";

                buttonXuatPDF2.Text = "Xuất PDF";
                buttonExportExcel2.Text = "Xuất Excel";

                // Cập nhật các thành phần khác tương ứng nếu cần
            }
            else if (selectedLanguage == "English")
            {
                labelDeMucBieuDo.Text = "Employee work completion rate";
                labelDeMucBieuDo2.Text = "Department work completion rate";
                tabControl1.TabPages[0].Text = "Employee";
                tabControl1.TabPages[1].Text = "Department";
                labelNgayBatDau.Text = "Start Date";
                labelNgayBatDau2.Text = "Start Date";
                labelMaNV.Text = "Employee ID";
                labelMaPB.Text = "Department ID";
                button1.Text = "Statistic";
                button2.Text = "Statistic";
                labelNgayKetThuc.Text = "End Date";
                labelNgayKetThuc2.Text = "End Date";
                groupBox1.Text = "Statistics";
                groupBox2.Text = "Statistics";
                labelThongKe.Text = "Statistics by";
                labelThongKe2.Text = "Statistics by";

                comboBoThongKe1.Items.Add("Overview");
                comboBoThongKe1.Items.Add("Detail");
                comboBoThongKe2.Items.Add("Overview");
                comboBoThongKe2.Items.Add("Detail");

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
            LoadDataIntoComboBox();
            comboBoThongKe1.SelectedIndex = comboBoThongKe2.SelectedIndex = comboBoxPB.SelectedIndex = 0;
        }
        private void LoadDataIntoComboBox()
        {
            List<string> data = DatabaseAccess.GetPhongBanData();
            foreach (string item in data)
            {

                comboBoxPB.Items.Add(item);
            }
        }
    }
}