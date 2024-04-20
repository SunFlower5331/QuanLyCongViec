using System;
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

namespace QuanLyCongViec
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();

            //dsch.CellFormatting += dsch_CellFormatting;
            //dsyc.CellFormatting += dsyc_CellFormatting;
        }


        //private void dsch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dsch.EnableHeadersVisualStyles = false;
        //    dsch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dsch.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dsch.Columns[i].HeaderCell.Style.SelectionBackColor = dsch.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);

        //            row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
        //                row.Cells[i].Style.ForeColor = Color.White;

        //        }
        //    }
        //}
        //private void dsyc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dsyc.EnableHeadersVisualStyles = false;
        //    dsyc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dsyc.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dsyc.Columns[i].HeaderCell.Style.SelectionBackColor = dsyc.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(160, 0, 0);

        //                row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
        //                row.Cells[i].Style.ForeColor = Color.White;

        //        }
        //    }
        //}

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
            if (textBoxTimKiem.Text == "Tìm kiếm theo mã căn hộ")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Black;
            }
        }
        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "")
            {
                textBoxTimKiem.Text = "Tìm kiếm theo mã căn hộ";
                textBoxTimKiem.ForeColor = Color.DimGray;
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            loadBaoCaoTimKiem(dateTimePickerStart.Value.AddDays(-1), dateTimePickerEnd.Value);
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
                    ExportExcel(saveFileDialog.FileName, dsch);
                    Process.Start(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình xuất file\n" + ex.Message);
                }
            }
        }

        private void buttonExportExcel2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dsyc);
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
                    MessageBox.Show("Xuất dữ liệu sang PDF thành công!", "Info");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất ra PDF!", "Info");
            }
        }

        private void buttonXuatPDF2_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Xuất dữ liệu sang PDF thành công!", "Info");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất ra PDF!", "Info");
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
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            //if (selectedLanguage == "Vietnamese")
            //{
            //    label1.Text = "Tìm kiếm:";
            //    label2.Text = "Kết quả:";
            //    groupBox1.Text = "Danh sách căn hộ";
            //    groupBox2.Text = "Yêu cầu dịch vụ";
            //    buttonTimKiem1.Text = "Tìm kiếm";
            //    buttonTiemKiem2.Text = "Tìm kiếm";

            //    dsch.Columns["MaCH"].HeaderText = "Mã căn hộ";
            //    dsch.Columns["TenCH"].HeaderText = "Tên căn hộ";
            //    dsch.Columns["TinhTrang"].HeaderText = "Tình trạng";
            //    dsch.Columns["CongNo"].HeaderText = "Công nợ";
            //    dsch.Columns["CPDienNuoc"].HeaderText = "Chi phí điện nước";
            //    dsch.Columns["CPQuanLy"].HeaderText = "Chi phí quản lý";
            //    dsch.Columns["CPKhac"].HeaderText = "Chi phí khác";
            //    dsch.Columns["XemThongTin"].HeaderText = "Xem thông tin";

            //    dsyc.Columns["MaCH_YC"].HeaderText = "Mã căn hộ";
            //    dsyc.Columns["NguoiYC"].HeaderText = "Người yêu cầu";
            //    dsyc.Columns["DichVuDinhKy"].HeaderText = "Dịch vụ định kỳ";
            //    dsyc.Columns["NgayYC"].HeaderText = "Ngày yêu cầu";
            //    dsyc.Columns["NDYC"].HeaderText = "Nội dung yêu cầu";
            //    dsyc.Columns["TinhTrang_YC"].HeaderText = "Tình trạng";
            //    dsyc.Columns["NVPhuTrach"].HeaderText = "Nhân viên phụ trách";
            //    dsyc.Columns["GhiChu"].HeaderText = "Ghi chú";
            //}
            //else if (selectedLanguage == "English")
            //{
            //    label1.Text = "Search:";
            //    label2.Text = "Result:";
            //    groupBox1.Text = "Apartment List";
            //    groupBox2.Text = "Service Requests";
            //    buttonTimKiem1.Text = "Search";
            //    buttonTiemKiem2.Text = "Search";

            //    dsch.Columns["MaCH"].HeaderText = "Apartment ID";
            //    dsch.Columns["TenCH"].HeaderText = "Apartment Name";
            //    dsch.Columns["TinhTrang"].HeaderText = "Status";
            //    dsch.Columns["CongNo"].HeaderText = "Debt";
            //    dsch.Columns["CPDienNuoc"].HeaderText = "Electricity and Water Costs";
            //    dsch.Columns["CPQuanLy"].HeaderText = "Management Costs";
            //    dsch.Columns["CPKhac"].HeaderText = "Other Costs";
            //    dsch.Columns["XemThongTin"].HeaderText = "View Details";

            //    dsyc.Columns["MaCH_YC"].HeaderText = "Apartment ID";
            //    dsyc.Columns["NguoiYC"].HeaderText = "Requester";
            //    dsyc.Columns["DichVuDinhKy"].HeaderText = "Regular Services";
            //    dsyc.Columns["NgayYC"].HeaderText = "Request Date";
            //    dsyc.Columns["NDYC"].HeaderText = "Request Content";
            //    dsyc.Columns["TinhTrang_YC"].HeaderText = "Status";
            //    dsyc.Columns["NVPhuTrach"].HeaderText = "Assigned Staff";
            //    dsyc.Columns["GhiChu"].HeaderText = "Note";
            //}
        }
    }
    
    
}
