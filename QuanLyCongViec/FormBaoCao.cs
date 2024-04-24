using System;
using DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using DTO;

namespace QuanLyCongViec
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();

            dsch.CellFormatting += dsch_CellFormatting;
            dsyc.CellFormatting += dsyc_CellFormatting;
        }


        private void dsch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsch.EnableHeadersVisualStyles = false;
            dsch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsch.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsch.Columns[i].HeaderCell.Style.SelectionBackColor = dsch.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dsyc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsyc.EnableHeadersVisualStyles = false;
            dsyc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsyc.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsyc.Columns[i].HeaderCell.Style.SelectionBackColor = dsyc.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

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
        //
        private void FormBaoCao_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loadBaoCaoCanHo(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dsch.Columns.Clear();
            dsch.DataSource = DatabaseAccess.GetDuLieuBaoCaoCanHo(NgayBatDau, NgayKetThuc).Tables[0];

            dsch.Columns["CongNo"].Visible = checkBoxCongNo.Checked;
            dsch.Columns["TongChiPhiDienNuoc"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiQuanLy"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiDichVu"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["tinhTrangNguoiO"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangBanGiao"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangNoiThat"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["quoctich"].Visible = checkBoxQuocTich.Checked;

            dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsch.Columns["tenCH"].HeaderText = "Tên chủ hộ";
            dsch.Columns["CongNo"].HeaderText = "Công nợ";
            dsch.Columns["tinhTrangNguoiO"].HeaderText = "Tình trạng người ở";
            dsch.Columns["tinhTrangBanGiao"].HeaderText = "Tình trạng bàn giao";
            dsch.Columns["tinhTrangNoiThat"].HeaderText = "Tình trạng nội thất";
            dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";
            dsch.Columns["TongphiQuanLy"].HeaderText = "Tổng chi phí quản lý";
            dsch.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
            dsch.Columns["quoctich"].HeaderText = "Quốc tịch";
            UpdateLanguage1();
        }

        private void loadBaoCaoYeuCau(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dsyc.Columns.Clear();
            dsyc.DataSource = DatabaseAccess.GetDuLieuBaoCaoYeuCau(NgayBatDau, NgayKetThuc).Tables[0];

            dsyc.Columns["tenCH"].Visible = checkBoxNguoiYC.Checked;
            dsyc.Columns["hoten"].Visible = checkBoxNVPT.Checked;
            dsyc.Columns["ngayYC"].Visible = checkBoxThoiGian.Checked;
            dsyc.Columns["trangthai"].Visible = checkBoxTinhTrangXuLy.Checked;

            dsyc.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsyc.Columns["tenCH"].HeaderText = "Người yêu cầu";
            dsyc.Columns["DV_dinhky"].HeaderText = "Dịch vụ định kỳ";
            dsyc.Columns["ngayYC"].HeaderText = "Ngày yêu cầu";
            dsyc.Columns["ten"].HeaderText = "Nội dung";
            dsyc.Columns["trangthai"].HeaderText = "Tình trạng ";
            dsyc.Columns["hoten"].HeaderText = "Nhân viên phụ trách";
            UpdateLanguage2();
        }

        private void loadBaoCaoTimKiem(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            dsch.Columns.Clear();
            dsyc.Columns.Clear();

            dsch.DataSource = DatabaseAccess.GetDuLieuBaoCaoTimKiemCH(textBoxTimKiem.Text, NgayBatDau, NgayKetThuc).Tables[0];
            dsyc.DataSource = DatabaseAccess.GetDuLieuBaoCaoTimKiemYC(textBoxTimKiem.Text, NgayBatDau, NgayKetThuc).Tables[0];

            dsch.Columns["CongNo"].Visible = checkBoxCongNo.Checked;
            dsch.Columns["TongChiPhiDienNuoc"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiQuanLy"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["TongphiDichVu"].Visible = checkBoxTongChiPhi.Checked;
            dsch.Columns["tinhTrangNguoiO"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangBanGiao"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["tinhTrangNoiThat"].Visible = checkBoxTinhTrangCanHo.Checked;
            dsch.Columns["quoctich"].Visible = checkBoxQuocTich.Checked;

            dsyc.Columns["tenCH"].Visible = checkBoxNguoiYC.Checked;
            dsyc.Columns["hoten"].Visible = checkBoxNVPT.Checked;
            dsyc.Columns["ngayYC"].Visible = checkBoxThoiGian.Checked;
            dsyc.Columns["trangthai"].Visible = checkBoxTinhTrangXuLy.Checked;

            dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsch.Columns["tenCH"].HeaderText = "Tên chủ hộ";
            dsch.Columns["CongNo"].HeaderText = "Công nợ";
            dsch.Columns["tinhTrangNguoiO"].HeaderText = "Tình trạng người ở";
            dsch.Columns["tinhTrangBanGiao"].HeaderText = "Tình trạng bàn giao";
            dsch.Columns["tinhTrangNoiThat"].HeaderText = "Tình trạng nội thất";
            dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";
            dsch.Columns["TongphiQuanLy"].HeaderText = "Tổng chi phí quản lý";
            dsch.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
            dsch.Columns["quoctich"].HeaderText = "Quốc tịch";

            dsyc.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsyc.Columns["tenCH"].HeaderText = "Người yêu cầu";
            dsyc.Columns["DV_dinhky"].HeaderText = "Dịch vụ định kỳ";
            dsyc.Columns["ngayYC"].HeaderText = "Ngày yêu cầu";
            dsyc.Columns["ten"].HeaderText = "Nội dung";
            dsyc.Columns["trangthai"].HeaderText = "Tình trạng ";
            dsyc.Columns["hoten"].HeaderText = "Nhân viên phụ trách";
            UpdateLanguage3();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            UpdateLanguage();
        }
    

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            loadBaoCaoCanHo(dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
            loadBaoCaoYeuCau(dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);

        }

        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Tìm kiếm theo mã căn hộ" || textBoxTimKiem.Text == "Search apartment code")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Black;
            }
        }
        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "" && GlobalSettings.Language == "Vietnamese")
            {
                textBoxTimKiem.Text = "Tìm kiếm theo mã căn hộ";
                textBoxTimKiem.ForeColor = Color.DimGray;
            }
            if (textBoxTimKiem.Text == "" && GlobalSettings.Language == "English")
            {
                textBoxTimKiem.Text = "Search apartment code";
                textBoxTimKiem.ForeColor = Color.DimGray;
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            loadBaoCaoTimKiem(dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
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
                    ExportExcel(saveFileDialog.FileName, dsch);
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
                catch(Exception ex)
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
                    ExportExcel(saveFileDialog.FileName, dsyc);
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

        private void buttonXuatPDF_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dsch.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsch);
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

        private void buttonXuatPDF2_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dsyc.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsyc);
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
        //
        private void UpdateLanguage()
        {
            // Lấy ngôn ngữ được chọn từ biến global
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật các chuỗi văn bản tùy thuộc vào ngôn ngữ được chọn
            if (selectedLanguage == "Vietnamese")
            {

                // Cập nhật các văn bản cho form khác
                groupBox1.Text = "Danh sách căn hộ";
                groupBox2.Text = "Danh sách yêu cầu";
                groupBox3.Text = "Tùy chọn";

                checkBoxTongChiPhi.Text = "Tổng chi phí";
                checkBoxCongNo.Text = "Công nợ";
                checkBoxNVPT.Text = "Nhân viên phụ trách";
                checkBoxTinhTrangXuLy.Text = "Tình trạng xử lý";
                checkBoxNguoiYC.Text = "Người yêu cầu";
                checkBoxQuocTich.Text = "Quốc tịch";
                checkBoxThoiGian.Text = "Ngày yêu cầu";
                checkBoxTinhTrangCanHo.Text = "Tình trạng căn hộ";
                label2.Text = "Chọn ngày bắt đầu:";
                label3.Text = "Chọn ngày kết thúc";
                textBoxTimKiem.Text = "Tìm kiếm theo mã căn hộ";

                buttonXacNhan.Text = "Xác nhận";
                buttonExportExcel.Text = "Xuất Excel";
                buttonXuatPDF.Text = "Xuất PDF";
                buttonXuatPDF2.Text = "Xuất PDF";
                buttonExportExcel2.Text = "Xuất Excel";

            }
            else if (selectedLanguage == "English")
            {
                groupBox1.Text = "Apartment list";
                groupBox2.Text = "Request list";
                groupBox3.Text = "Options";

                checkBoxTongChiPhi.Text = "Total cost";
                checkBoxCongNo.Text = "Debt";
                checkBoxNVPT.Text = "Staff in charge";
                checkBoxTinhTrangXuLy.Text = "Processing status";
                checkBoxNguoiYC.Text = "Requester";
                checkBoxQuocTich.Text = "Nationality";
                checkBoxThoiGian.Text = "Request date";
                checkBoxTinhTrangCanHo.Text = "Apartment status";
                label2.Text = "Choose start date:";
                label3.Text = "Select end date";
                textBoxTimKiem.Text = "Search apartment code";

                buttonXacNhan.Text = "Confirm";
                buttonExportExcel.Text = "Export Excel";
                buttonXuatPDF.Text = "Export PDF";
                buttonXuatPDF2.Text = "Export PDF";
                buttonExportExcel2.Text = "Export Excel";

            }
        }
        private void UpdateLanguage1()
        {
            // Lấy ngôn ngữ được chọn từ biến global
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật các chuỗi văn bản tùy thuộc vào ngôn ngữ được chọn
            if (selectedLanguage == "Vietnamese")
            {

                // Cập nhật các văn bản cho form khác
                dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
                dsch.Columns["tenCH"].HeaderText = "Tên chủ hộ";
                dsch.Columns["CongNo"].HeaderText = "Công nợ";
                dsch.Columns["tinhTrangNguoiO"].HeaderText = "Tình trạng người ở";
                dsch.Columns["tinhTrangBanGiao"].HeaderText = "Tình trạng bàn giao";
                dsch.Columns["tinhTrangNoiThat"].HeaderText = "Tình trạng nội thất";
                dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";
                dsch.Columns["TongphiQuanLy"].HeaderText = "Tổng chi phí quản lý";
                dsch.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
                dsch.Columns["quoctich"].HeaderText = "Quốc tịch";

            }
            else if (selectedLanguage == "English")
            {

                dsch.Columns["maCH"].HeaderText = "Apartment code";
                dsch.Columns["tenCH"].HeaderText = "Household name";
                dsch.Columns["CongNo"].HeaderText = "Debt";
                dsch.Columns["tinhTrangNguoiO"].HeaderText = "Resident status";
                dsch.Columns["tinhTrangBanGiao"].HeaderText = "Hanover status";
                dsch.Columns["tinhTrangNoiThat"].HeaderText = "Interior condition";
                dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Total electricity and water costs";
                dsch.Columns["TongphiQuanLy"].HeaderText = "Total management costs";
                dsch.Columns["TongPhiDichVu"].HeaderText = "Total service fee";

            }
        }
        private void UpdateLanguage2()
        {
            // Lấy ngôn ngữ được chọn từ biến global
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật các chuỗi văn bản tùy thuộc vào ngôn ngữ được chọn
            if (selectedLanguage == "Vietnamese")
            {

                dsyc.Columns["maCH"].HeaderText = "Mã căn hộ";
                dsyc.Columns["tenCH"].HeaderText = "Người yêu cầu";
                dsyc.Columns["DV_dinhky"].HeaderText = "Dịch vụ định kỳ";
                dsyc.Columns["ngayYC"].HeaderText = "Ngày yêu cầu";
                dsyc.Columns["ten"].HeaderText = "Nội dung";
                dsyc.Columns["trangthai"].HeaderText = "Tình trạng ";
                dsyc.Columns["hoten"].HeaderText = "Nhân viên phụ trách";

            }
            else if (selectedLanguage == "English")
            {

                dsyc.Columns["maCH"].HeaderText = "Apartment ID";
                dsyc.Columns["tenCH"].HeaderText = "Requester";
                dsyc.Columns["DV_dinhky"].HeaderText = "Regular Services";
                dsyc.Columns["ngayYC"].HeaderText = "Request Date";
                dsyc.Columns["ten"].HeaderText = "Content";
                dsyc.Columns["trangthai"].HeaderText = "Status";
                dsyc.Columns["hoten"].HeaderText = "Staff in Charge";
            }
        }
        private void UpdateLanguage3()
        {
            // Lấy ngôn ngữ được chọn từ biến global
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật các chuỗi văn bản tùy thuộc vào ngôn ngữ được chọn
            if (selectedLanguage == "Vietnamese")
            {

                // Cập nhật các văn bản cho form khác
                dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
                dsch.Columns["tenCH"].HeaderText = "Tên chủ hộ";
                dsch.Columns["CongNo"].HeaderText = "Công nợ";
                dsch.Columns["tinhTrangNguoiO"].HeaderText = "Tình trạng người ở";
                dsch.Columns["tinhTrangBanGiao"].HeaderText = "Tình trạng bàn giao";
                dsch.Columns["tinhTrangNoiThat"].HeaderText = "Tình trạng nội thất";
                dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";
                dsch.Columns["TongphiQuanLy"].HeaderText = "Tổng chi phí quản lý";
                dsch.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
                dsch.Columns["quoctich"].HeaderText = "Quốc tịch";

                dsyc.Columns["maCH"].HeaderText = "Mã căn hộ";
                dsyc.Columns["tenCH"].HeaderText = "Người yêu cầu";
                dsyc.Columns["DV_dinhky"].HeaderText = "Dịch vụ định kỳ";
                dsyc.Columns["ngayYC"].HeaderText = "Ngày yêu cầu";
                dsyc.Columns["ten"].HeaderText = "Nội dung";
                dsyc.Columns["trangthai"].HeaderText = "Tình trạng ";
                dsyc.Columns["hoten"].HeaderText = "Nhân viên phụ trách";
            }
            else if (selectedLanguage == "English")
            {
                dsch.Columns["maCH"].HeaderText = "Apartment ID";
                dsch.Columns["tenCH"].HeaderText = "Owner's Name";
                dsch.Columns["CongNo"].HeaderText = "Debt";
                dsch.Columns["tinhTrangNguoiO"].HeaderText = "Occupancy Status";
                dsch.Columns["tinhTrangBanGiao"].HeaderText = "Handover Status";
                dsch.Columns["tinhTrangNoiThat"].HeaderText = "Furniture Status";
                dsch.Columns["TongChiPhiDienNuoc"].HeaderText = "Total Electricity and Water Cost";
                dsch.Columns["TongphiQuanLy"].HeaderText = "Total Management Fee";
                dsch.Columns["TongPhiDichVu"].HeaderText = "Total Service Fee";
                dsch.Columns["quoctich"].HeaderText = "Nationality";

                dsyc.Columns["maCH"].HeaderText = "Apartment ID";
                dsyc.Columns["tenCH"].HeaderText = "Requester";
                dsyc.Columns["DV_dinhky"].HeaderText = "Regular Services";
                dsyc.Columns["ngayYC"].HeaderText = "Request Date";
                dsyc.Columns["ten"].HeaderText = "Content";
                dsyc.Columns["trangthai"].HeaderText = "Status";
                dsyc.Columns["hoten"].HeaderText = "Staff in Charge";

            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FormBaoCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }
    }


}
