using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyCongViec
{
    public partial class FormCongViec : Form
    {
        public FormCongViec()
        {
            InitializeComponent();
            dscv.CellFormatting += dscv_CellFormatting;
            dsnv.CellFormatting += dsnv_CellFormatting;
            dsdpc.CellFormatting += dsdpc_CellFormatting;


        }
        // Chỉnh sửa màu của 3 dataGridView
        private void LoadDataIntoComboBox()
        {
            List<string> data = DatabaseAccess.GetPhongBanData();
            foreach (string item in data)
            {

                cbotuychonhienthi.Items.Add(item);
            }
        }
        private void dscv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dscv.EnableHeadersVisualStyles = false;
            dscv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dscv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dscv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dscv.Columns[i].HeaderCell.Style.SelectionBackColor = dscv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.White;
                        row.Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }
        }
        private void dsnv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsnv.EnableHeadersVisualStyles = false;
            dsnv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dsnv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsnv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsnv.Columns[i].HeaderCell.Style.SelectionBackColor = dsnv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.White;
                        row.Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }
        }
        private void dsdpc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsdpc.EnableHeadersVisualStyles = false;
            dsdpc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dsdpc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsdpc.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsdpc.Columns[i].HeaderCell.Style.SelectionBackColor = dsdpc.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.White;
                        row.Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void FormCongViec_Load(object sender, EventArgs e)
        {
            dtpthoihan.Format = DateTimePickerFormat.Short;
            dtpthoihan.CustomFormat = "dd/MM/yyyy";
            loadDsCongViec();
            loadCTCV();
            loadDsNv();
            tuychonhienthi();
            comboBoxLanguage_SelectedIndexChanged();
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
            UpdateLanguage();
            LoadDataIntoComboBox();


        }



        private void loadData(string phongBan)
        {
            dsnv.DataSource = DatabaseAccess.GetNhanVienTheoPhongBan(phongBan).Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["phongban"].HeaderText = "Phòng ban";
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";

            dsdpc.DataSource = DatabaseAccess.GetCTCVTheoPhongBan(phongBan).Tables[0];
            dsdpc.AutoGenerateColumns = false;

            dsdpc.Columns["phongban"].HeaderText = "Phòng ban";
            dsdpc.Columns["chucvu"].HeaderText = "Chức vụ";
            dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
            dsdpc.Columns["ten"].HeaderText = "Tên công việc";
            dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
            dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";
            dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
            dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dsdpc.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";
        }

        private void loadDsNv()
        {

            dsnv.DataSource = DatabaseAccess.GetNhanVien().Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["phongban"].HeaderText = "Phòng ban";
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";
        }

        private void loadDsCongViec()
        {
            dscv.DataSource = DatabaseAccess.GetAllDscv().Tables[0];
            dscv.Columns["maCV"].HeaderText = "Mã công việc";
            dscv.Columns["ten"].HeaderText = "Tên công việc";
            dscv.Columns["ngayYC"].HeaderText = "Ngày yêu cầu";
        }
        UyQuyen uy1;
        UyQuyen uy2;
        private void loadCTCV()
        {
            dsdpc.DataSource = DatabaseAccess.GetCTCV().Tables[0];
            dsdpc.AutoGenerateColumns = false;
            dsdpc.Columns["phongban"].HeaderText = "Phòng ban";
            dsdpc.Columns["chucvu"].HeaderText = "Chức vụ";
            dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
            dsdpc.Columns["ten"].HeaderText = "Tên công việc";
            dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
            dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";

            dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
            dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsdpc.Columns["songayhethan"].HeaderText = "Thời gian còn lại";
            dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            dsdpc.Columns["ngaycapnhat"].HeaderText = "Ngày cập nhật";
            foreach (DataGridViewRow dgvRow in dsdpc.Rows)
            {
                if (dgvRow.Cells["songayhethan"].Value != null && dgvRow.Cells["trangthai"].Value != null)
                {
                    int soNgayHetHan;

                    if (int.TryParse(dgvRow.Cells["songayhethan"].Value.ToString(), out soNgayHetHan))
                    {
                        if (soNgayHetHan < 0 && string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Trễ hạn", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Hoàn thành đúng hạn ", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Green;
                        }
                        else if (string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Hoàn thành sớm ", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Blue;
                        }
                        else if (soNgayHetHan < 3 && string.Equals(dgvRow.Cells["trangthai"].Value.ToString(), "Chưa hoàn thành", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvRow.DefaultCellStyle.BackColor = Color.Orange;
                        }
                    }
                }
            }


        }
        private void dscv_Click(Object sender, EventArgs e)
        {

            btnchinhsuaphancong.Enabled = false;
            btnphancong.Enabled = true;
            if (dscv.CurrentRow != null && dscv.CurrentRow.Index >= 0)
            {
                DataGridViewRow row1 = dscv.CurrentRow;
                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();


            }

        }


        private void dsnv_Click(object sender, EventArgs e)
        {
            if (dsnv.CurrentRow != null && dsnv.CurrentRow.Index >= 0)
            {
                DataGridViewRow row1 = dsnv.CurrentRow;

                // Kiểm tra từng giá trị trước khi lấy dữ liệu
                tbobophan.Text = row1.Cells["phongban"].Value != null ? row1.Cells["phongban"].Value.ToString() : string.Empty;
                tbotennv.Text = row1.Cells["hoten"].Value != null ? row1.Cells["hoten"].Value.ToString() : string.Empty;
                tbomanv.Text = row1.Cells["maNV"].Value != null ? row1.Cells["maNV"].Value.ToString() : string.Empty;

                // Khởi tạo đối tượng UyQuyen nếu các giá trị không null
                if (!string.IsNullOrEmpty(tbomacv.Text) && !string.IsNullOrEmpty(tbotencv.Text) && !string.IsNullOrEmpty(tbobophan.Text) &&
                    !string.IsNullOrEmpty(tbotennv.Text) && !string.IsNullOrEmpty(tbomanv.Text) && !string.IsNullOrEmpty(dtpthoihan.Text) &&
                    !string.IsNullOrEmpty(cbotuychonchiase.Text) && !string.IsNullOrEmpty(cbotrangthai.Text))
                {
                    uy2 = new UyQuyen(tbomacv.Text, tbotencv.Text, tbobophan.Text, tbotennv.Text, tbomanv.Text, dtpthoihan.Text, cbotuychonchiase.Text, cbotrangthai.Text, DateTime.Now.Date);
                }
            }
        }


        private void dsdpc_Click(object sender, EventArgs e)
        {
            dscv.CurrentCell = null;
            btnphancong.Enabled = false;

            if (dsdpc.CurrentRow != null && dsdpc.CurrentRow.Index >= 0)
            {
                btnchinhsuaphancong.Enabled = true;
                DataGridViewRow row1 = dsdpc.CurrentRow;

                // Kiểm tra từng giá trị trước khi lấy dữ liệu
                tbomacv.Text = row1.Cells["maCV"].Value != null ? row1.Cells["maCV"].Value.ToString() : string.Empty;
                tbotencv.Text = row1.Cells["ten"].Value != null ? row1.Cells["ten"].Value.ToString() : string.Empty;
                tbobophan.Text = row1.Cells["phongban"].Value != null ? row1.Cells["phongban"].Value.ToString() : string.Empty;
                tbotennv.Text = row1.Cells["hoten"].Value != null ? row1.Cells["hoten"].Value.ToString() : string.Empty;
                tbomanv.Text = row1.Cells["maNV"].Value != null ? row1.Cells["maNV"].Value.ToString() : string.Empty;
                dtpthoihan.Text = row1.Cells["thoiGianHoanThanh"].Value != null ? row1.Cells["thoiGianHoanThanh"].Value.ToString() : string.Empty;
                cbotuychonchiase.Text = row1.Cells["Tuychonchiase"].Value != null ? row1.Cells["Tuychonchiase"].Value.ToString() : string.Empty;
                cbotrangthai.Text = row1.Cells["trangthai"].Value != null ? row1.Cells["trangthai"].Value.ToString() : string.Empty;
            }
        }


        private void guiEmail(string to, string content)
        {
            string selectedLanguage = GlobalSettings.Language;
            string from, pass;
            from = "zantlytm@gmail.com";
            pass = "rxaypqcmtmtxerbq";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "[THÔNG BÁO ỨNG DỤNG QUẢN LÍ CÔNG VIỆC] CÔNG VIỆC";
                mail.Body = content;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(mail);
                }
                catch (Exception)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Lỗi Cacth, không gửi đc");
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Cacth error, unable to send");
                    }
                }
            }
            catch
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("System error!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dscv.AllowUserToAddRows = true;
            btnluu.Enabled = true;

            DataTable dataTable = (DataTable)dscv.DataSource;

            // Thêm một hàng mới vào DataTable
            DataRow newRow = dataTable.NewRow();
            newRow["ngayYC"] = DateTime.Now.Date;

            dataTable.Rows.Add(newRow);
            dscv.BeginEdit(true);
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            try
            {
                dscv.Enabled = true;
                if (dscv.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = dscv.SelectedRows[0];
                    string maCV = selectedRow.Cells["maCV"].Value.ToString();
                    string ten = selectedRow.Cells["ten"].Value.ToString();
                    string ngayYC = selectedRow.Cells["ngayYC"].Value.ToString();

                    // Kiểm tra xem mã công việc có bắt đầu bằng "CD" hay không

                    string[] conditionColumns = { "maCV", "ten", "ngayYC" };
                    object[] conditionValues = { maCV, ten, ngayYC };
                    if (maCV.StartsWith("CD"))
                    {
                        DatabaseAccess.DeleteDVCanHo(maCV);

                    }
                    DatabaseAccess.DeleteData("DsCongViec", conditionColumns, conditionValues);

                    loadDsCongViec();
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Data deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (dsdpc.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dsdpc.SelectedRows[0];
                    string maCV = selectedRow.Cells["maCV"].Value.ToString();
                    DatabaseAccess.delCTCV(maCV);

                    loadCTCV();
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Data deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Vui lòng chọn hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Please select rows to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi xóa dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show($"An error occurred while deleting data!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }

        private void dscv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnluu_Click(sender, e);
                dscv.CurrentCell = dscv.Rows[dscv.Rows.Count - 1].Cells[0];
                dscv.BeginEdit(true);

            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            try
            {

                DataGridViewRow newRow = dscv.Rows[dscv.Rows.Count - 2];
                foreach (DataGridViewCell cell in newRow.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("Please enter enough information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return;
                    }
                }

                string maCV = newRow.Cells["maCV"].Value.ToString();
                if (!maCV.StartsWith("CD"))
                {


                    string ten = newRow.Cells["ten"].Value.ToString();
                    DateTime ngayYC = DateTime.Now.Date;

                    // Kiểm tra xem dữ liệu đã tồn tại trong cơ sở dữ liệu chưa
                    bool dataExists = DatabaseAccess.CheckDataExists("DsCongViec", "maCV", maCV);
                    if (dataExists)
                    {
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu|Bạn chưa nhập dữ liệu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("Data already exists in the database|You have not entered new data yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return;
                    }

                    // Kiểm tra xem mã công việc có phải là một số hay không
                    if (!int.TryParse(maCV, out _))
                    {
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Mã công việc phải là một số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("Job code must be a number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return;
                    }

                    if (!int.TryParse(maCV, out _) || int.Parse(maCV) <= 0)
                    {
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Mã công việc phải là một số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("Job code must be a positive integer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return;
                    }

                    // Nếu dữ liệu chưa tồn tại, thêm vào cơ sở dữ liệu
                    DatabaseAccess.InsertData("DsCongViec",
                        new string[] { "maCV", "ten", "ngayYC" },
                        new object[] { maCV, ten, ngayYC });
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã thêm dữ liệu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Đã thêm dữ liệu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    loadDsCongViec();
                }

                else
                {
                    MessageBox.Show("Vui lòng thêm dữ liệu này ở bảng dữ liệu cư dân ,đẻ thêm được đầy đủ thông tin | Please add this data to the resident data sheet to get more complete information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadDsCongViec();
                }
            }


            catch (Exception ex)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi thêm dữ liệu mới!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show($"An error occurred while adding new data!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }


        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;

            // Kiểm tra xem dòng được chọn có tồn tại không
            if (dscv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dscv.SelectedRows[0];

                // Kiểm tra xem cột "maCV", "ngayYC", "ten" có tồn tại và không null
                if (selectedRow.Cells["maCV"] != null && selectedRow.Cells["ngayYC"].Value != null && selectedRow.Cells["ten"].Value != null)
                {
                    string maCV = selectedRow.Cells["maCV"].Value.ToString();
                    string tenMoi = selectedRow.Cells["ten"].Value.ToString();
                    string ngayYC = selectedRow.Cells["ngayYC"].Value.ToString();

                    try
                    {
                        if (maCV.StartsWith("CD"))
                        {
                            DatabaseAccess.UpdateDVCanHo(maCV, tenMoi, ngayYC);
                        }
                        else
                        {
                            DatabaseAccess.UpdateData("DsCongViec", new string[] { "ten", "ngayYC" }, new object[] { tenMoi, ngayYC }, new string[] { "maCV" }, new object[] { maCV });
                        }

                        // Hiển thị thông báo thành công
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("Data updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        loadDsCongViec();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show($"An error occurred while updating data!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Ngày yêu cầu không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Invalid date format for request date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Tên công việc không tồn tại hoặc giá trị rỗng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Job name does not exist or is null!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    // Hiển thị thông báo nếu không có hàng nào được chọn
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Please select a row to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Xóa bôi đen các ô trên các DataGridView khác
                dsnv.CurrentCell = null;
                dscv.CurrentCell = null;
                dsdpc.CurrentCell = null;
            }
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
                    ExportExcel(saveFileDialog.FileName, dsdpc);
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
            if (dsdpc.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsdpc);
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
            string selectedLanguage = GlobalSettings.Language;

            // Use selectedLanguage instead of getting language from GlobalSettings or other source
            if (selectedLanguage == "Vietnamese")
            {
                //UpdateLanguageInComboBox(selectedLanguage == "Vietnamese");
                groupBox2.Text = "Danh sách nhân viên";
                label3.Text = "Mã công việc:";
                label1.Text = "Thời hạn:";
                label4.Text = "Tên công việc";
                label2.Text = "Bộ phận:";
                label5.Text = "Tên nhân viên:";
                groupBox3.Text = "Danh sách công việc đã phân công";
                label6.Text = "Mã nhân viên:";
                label7.Text = "Tùy chọn chia sẻ:";
                btnphancong.Text = "Phân công";
                xoacv.Text = "Xóa công việc";
                btnchinhsuaphancong.Text = "Chỉnh sửa phân công";
                label8.Text = "Trạng thái:";
                groupBox1.Text = "Danh sách công việc";
                label9.Text = "Tùy chọn hiển thị:";
                //xoacv.Text = "Xóa công việc";

                dsnv.Columns["phongban"].HeaderText = "Phòng ban";
                dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
                dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
                dsnv.Columns["hoten"].HeaderText = "Họ và tên";

                dsdpc.Columns["chucvu"].HeaderText = "Chức vụ";
                dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
                dsdpc.Columns["ten"].HeaderText = "Tên công việc";
                dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
                dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";
                dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
                dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

                dsdpc.Columns["phongban"].HeaderText = "Phòng ban";
                dsdpc.Columns["chucvu"].HeaderText = "Chức vụ";
                dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
                dsdpc.Columns["ten"].HeaderText = "Tên công việc";
                dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
                dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";

                dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
                dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                dsdpc.Columns["songayhethan"].HeaderText = "Thời gian còn lại";
                dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

                dscv.Columns["maCV"].HeaderText = "Mã công việc";
                dscv.Columns["ten"].HeaderText = "Tên công việc";

                buttonXuatPDF.Text = "Xuất PDF";
                buttonExportExcel.Text = "Xuất Excel";
            }
            else
            {

                //UpdateLanguageInComboBox(selectedLanguage == "English");
                groupBox2.Text = "List of employee";
                label3.Text = "Task ID:";
                label4.Text = "Task Name:";
                label1.Text = "Deadline:";
                label2.Text = "Department:";
                label5.Text = "Employee Name:";
                groupBox3.Text = "List of assigned work";
                label6.Text = "Employee ID:";
                label7.Text = "Share option:";
                btnphancong.Text = "Assign";
                btnchinhsuaphancong.Text = "Edit Assignment";
                xoacv.Text = "Delete job";
                label8.Text = "Status:";
                groupBox1.Text = "Task List";
                label9.Text = "Display options:";
                //  xoacv.Text = "Delete job";

                dsnv.Columns["phongban"].HeaderText = "Department";
                dsnv.Columns["chucvu"].HeaderText = "Position";
                dsnv.Columns["manv"].HeaderText = "Employee ID";
                dsnv.Columns["hoten"].HeaderText = "Full Name";

                dsdpc.Columns["chucvu"].HeaderText = "Position";
                dsdpc.Columns["maCV"].HeaderText = "Job ID";
                dsdpc.Columns["ten"].HeaderText = "Job Name";
                dsdpc.Columns["maNV"].HeaderText = "Employee ID";
                dsdpc.Columns["hoten"].HeaderText = "Employee Name";
                dsdpc.Columns["trangthai"].HeaderText = "Status";
                dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Completion Time";
                dsdpc.Columns["Tuychonchiase"].HeaderText = "Share Options";

                dsdpc.Columns["phongban"].HeaderText = "Department";
                dsdpc.Columns["chucvu"].HeaderText = "Position";
                dsdpc.Columns["maCV"].HeaderText = "Job ID";
                dsdpc.Columns["ten"].HeaderText = "Job Name";
                dsdpc.Columns["maNV"].HeaderText = "Employee ID";
                dsdpc.Columns["hoten"].HeaderText = "Employee Name";

                dsdpc.Columns["trangthai"].HeaderText = "Status";
                dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Completion Time";
                dsdpc.Columns["songayhethan"].HeaderText = "Remaining Time";
                dsdpc.Columns["Tuychonchiase"].HeaderText = "Sharing Options";

                dscv.Columns["maCV"].HeaderText = "Job ID";
                dscv.Columns["ten"].HeaderText = "Job Name";
                dscv.Columns["ngayYC"].HeaderText = "Request Date";

                buttonXuatPDF.Text = "Export PDF";
                buttonExportExcel.Text = "Export Excel";


            }
        }
        private void comboBoxLanguage_SelectedIndexChanged()
        {
            string selectedLanguage = GlobalSettings.Language;

            if (selectedLanguage == "Vietnamese")
            {
                // Cập nhật ngôn ngữ của các mục trong ComboBox sang tiếng Anh
                cbotuychonhienthi.Items.Clear();
                cbotrangthai.Items.Clear();
                cbotuychonchiase.Items.Clear();
                cbotuychonhienthi.Items.Add("Tất cả nhân viên");



                cbotuychonchiase.Items.Add("Công việc chung");
                cbotuychonchiase.Items.Add("Bộ phận");

                cbotrangthai.Items.Add("Chưa hoàn thành");
                cbotrangthai.Items.Add("Hoàn thành");
                // Cập nhật các thành phần khác tương ứng nếu cần
                cbotrangthai.SelectedIndex = 0;
                cbotuychonchiase.SelectedIndex = 0;

                cbotuychonhienthi.SelectedIndex = 0;

            }
            else if (selectedLanguage == "English")
            {
                // Cập nhật ngôn ngữ của các mục trong ComboBox sang tiếng Việt
                cbotuychonhienthi.Items.Clear();
                cbotrangthai.Items.Clear();
                cbotuychonchiase.Items.Clear();
                cbotuychonhienthi.Items.Add("All Employees");


                cbotuychonchiase.Items.Add("Joint work");
                cbotuychonchiase.Items.Add("Part");

                cbotrangthai.Items.Add("Unfinished");
                cbotrangthai.Items.Add("Accomplished");
                cbotrangthai.SelectedIndex = 0;
                cbotuychonchiase.SelectedIndex = 0;
                cbotuychonhienthi.SelectedIndex = 0;

                // Cập nhật các thành phần khác tương ứng nếu cần
            }
        }
        private void comboBoxLanguage_SelectedIndexChanged1()
        {
            string selectedLanguage = GlobalSettings.Language;

            if (selectedLanguage == "Vietnamese")
            {

                // Cập nhật ngôn ngữ của các mục trong ComboBox sang tiếng Anh

                cbotuychonchiase.Items.Clear();

                cbotuychonchiase.Items.Add("Công việc chung");
                cbotuychonchiase.Items.Add("Bộ phận");


                cbotuychonchiase.SelectedIndex = 0;


                // Cập nhật các thành phần khác tương ứng nếu cần
            }
            else if (selectedLanguage == "English")
            {
                // Cập nhật ngôn ngữ của các mục trong ComboBox sang tiếng Việt

                cbotuychonchiase.Items.Clear();

                cbotuychonchiase.Items.Add("Joint work");
                cbotuychonchiase.Items.Add("Part");


                cbotuychonchiase.SelectedIndex = 0;



                // Cập nhật các thành phần khác tương ứng nếu cần
            }
        }
        private void comboBoxLanguage_SelectedIndexChanged2()
        {
            string selectedLanguage = GlobalSettings.Language;

            if (selectedLanguage == "Vietnamese")
            {

                cbotrangthai.Items.Clear();


                cbotrangthai.Items.Add("Chưa hoàn thành");
                cbotrangthai.Items.Add("Hoàn thành");
                cbotrangthai.SelectedIndex = 0;


                // Cập nhật các thành phần khác tương ứng nếu cần
            }
            else if (selectedLanguage == "English")
            {
                // Cập nhật ngôn ngữ của các mục trong ComboBox sang tiếng Việt

                cbotrangthai.Items.Clear();

                cbotrangthai.Items.Add("Unfinished");
                cbotrangthai.Items.Add("Accomplished");
                cbotrangthai.SelectedIndex = 0;


                // Cập nhật các thành phần khác tương ứng nếu cần
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

        private void FormCongViec_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }

        private void btnphancong_Click_1(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            try
            {

                if (string.IsNullOrEmpty(tbomacv.Text) || string.IsNullOrEmpty(tbomanv.Text) || string.IsNullOrEmpty(cbotuychonchiase.Text))
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Please fill in all information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return;
                }


                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;
                string trangthai = cbotrangthai.Text;
                DateTime ngaycapnhat = DateTime.Now.Date;

                // phân loại hoàn thành trễ, đúng, sớm
                if (trangthai == "Đã hoàn thành")
                {
                    if (ngaycapnhat < thoiGianHoanThanh)
                    {
                        trangthai = "Hoàn thành sớm";
                    }
                    else if (ngaycapnhat == thoiGianHoanThanh)
                    {
                        trangthai = "Hoàn thành đúng hạn";
                    }
                    else
                    {
                        trangthai = "Trễ hạn";
                    }

                }



                if (DatabaseAccess.IsDuplicateData("CTCV", new string[] { "maCV" }, new object[] { maCV }))
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Công việc này đã được phân công cho nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("This job has already been assigned to an employee!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }


                DatabaseAccess.InsertData("CTCV", new string[] { "maCV", "maNV", "trangthai", "thoiGianHoanThanh", "Tuychonchiase", "ngaycapnhat" },
                    new object[] { maCV, maNV, trangthai, thoiGianHoanThanh, tuyChonChiaSe, ngaycapnhat });

                loadCTCV();
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Data saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string email = DatabaseAccess.getEmail(maNV);
                string content = "PHÂN CÔNG CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;

                if (selectedLanguage == "Vietnamese")
                {
                    content = "PHÂN CÔNG CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                }
                else if (selectedLanguage == "English")
                {
                    content = "WORK ASSIGNMENT \nJob code: " + maCV + "\nEmployee code: " + maNV + "\nCompletion time: " + thoiGianHoanThanh + "\nSharing options: " + tuyChonChiaSe + " \nStatus: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                }
                guiEmail(email, content);
            }
            catch (Exception ex)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi lưu dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show($"An error occurred while saving data!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }

        private void btnchinhsuaphancong_Click_1(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            try
            {

                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;
                string trangthai = cbotrangthai.Text;
                DateTime ngaycapnhat = DateTime.Now.Date;
                string[] conditionColumns = { "maCV" };
                object[] conditionValues = { maCV };

                if (trangthai == "Đã hoàn thành")
                {
                    if (ngaycapnhat < thoiGianHoanThanh)
                    {
                        trangthai = "Hoàn thành sớm";
                    }
                    else if (ngaycapnhat == thoiGianHoanThanh)
                    {
                        trangthai = "Hoàn thành đúng hạn";
                    }
                    else
                    {
                        trangthai = " Đã hoàn thành trễ hạn";
                    }

                }


                if (DatabaseAccess.CheckCV(maCV, maNV) == false && maNV != null)

                {
                    string maNV_cu = DatabaseAccess.getManv(maCV);
                    DatabaseAccess.insertDsUyQuyenCV(maNV_cu, maCV, maNV, trangthai, thoiGianHoanThanh, tuyChonChiaSe, ngaycapnhat);
                    DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai", "ngaycapnhat" },
                       new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai, ngaycapnhat }, conditionColumns, conditionValues);
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Data updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.FormCongViec_Load(null, null);

                    string emailll = DatabaseAccess.getEmail(maNV);
                    string contenttt = "ỦY QUYỀN CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;

                    if (selectedLanguage == "Vietnamese")
                    {
                        contenttt = "ỦY QUYỀN CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                    }
                    else if (selectedLanguage == "English")
                    {
                        contenttt = "JOB AUTHORIZATION \nJob code: " + maCV + "\nEmployee code: " + maNV + "\nCompletion time: " + thoiGianHoanThanh + "\nSharing options: " + tuyChonChiaSe + " \nStatus: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                    }
                    guiEmail(emailll, contenttt);

                }
                else
                {

                    DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase", "trangthai", "ngaycapnhat" },
                       new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe, trangthai, ngaycapnhat }, conditionColumns, conditionValues);


                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Data updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.FormCongViec_Load(null, null);

                    string content = "CẬP NHẬT CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;

                    if (selectedLanguage == "Vietnamese")
                    {
                        content = "CẬP NHẬT CÔNG VIỆC  \nMã công việc: " + maCV + "\nMã nhân viên: " + maNV + "\nThời gian hoàn thành: " + thoiGianHoanThanh + "\nTùy chọn chia sẽ: " + tuyChonChiaSe + "\nTrạng thái: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                    }
                    else if (selectedLanguage == "English")
                    {
                        content = "UPDATE JOB \nJob code: " + maCV + "\nEmployee code: " + maNV + "\nCompletion time: " + thoiGianHoanThanh + "\nSharing options: " + tuyChonChiaSe + "\nStatus: " + trangthai + "\nNgày cập nhật: " + ngaycapnhat;
                    }

                    List<string> emails = DatabaseAccess.getEmailsByRole(1);
                    foreach (string email in emails)
                    {
                        guiEmail(email, content);
                    }

                }



            }
            catch (Exception ex)
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show($"An error occurred while updating data!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }



            tbomacv.Text = "";
            tbotencv.Text = "";

            tbotennv.Text = "";
            tbomanv.Text = "";
            dtpthoihan.Text = "";
            cbotuychonchiase.Text = "";
            cbotrangthai.Text = "";
            btnluu.Enabled = false;
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string maCV = tbomacv.Text;




            if (maCV != null)

            {
                DatabaseAccess.delCTCV(maCV);

                MessageBox.Show("Xóa công việc thành công! | Deleted job successfully! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCTCV();


            }
        }

        private void cbotuychonhienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tuychonhienthi();
        }
        private void tuychonhienthi()
        {
            string selectedOption = cbotuychonhienthi.Text;
            loadData(selectedOption);
            UpdateLanguage();

            if (cbotuychonhienthi.SelectedIndex == 0)
            {
                loadCTCV();
                loadDsNv();
            }
        }



    }
}


