using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace QuanLyCongViec
{
    public partial class FormDuLieuCuDan : Form
    {

        public FormDuLieuCuDan()
        {
            InitializeComponent();

            dscudan.CellFormatting += dscudan_CellFormatting;
            dsch.CellFormatting += dsch_CellFormatting;
            dsqh.CellFormatting += dsqh_CellFormatting;
            dstk.CellFormatting += dstk_CellFormatting;
            dsnv.CellFormatting += dsnv_CellFormatting;
            dspb.CellFormatting += dspb_CellFormatting;
        }

        private void dscudan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dscudan.EnableHeadersVisualStyles = false;
            dscudan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dscudan.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dscudan.Columns[i].HeaderCell.Style.SelectionBackColor = dscudan.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166); ;

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dsch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsch.EnableHeadersVisualStyles = false;
            dsch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsch.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsch.Columns[i].HeaderCell.Style.SelectionBackColor = dsch.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166); ;

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dsqh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsqh.EnableHeadersVisualStyles = false;
            dsqh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsqh.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsqh.Columns[i].HeaderCell.Style.SelectionBackColor = dsqh.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166); ;

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dstk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dstk.EnableHeadersVisualStyles = false;
            dstk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dstk.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dstk.Columns[i].HeaderCell.Style.SelectionBackColor = dstk.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166); ;

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dsnv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dsnv.EnableHeadersVisualStyles = false;
            dsnv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dsnv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dsnv.Columns[i].HeaderCell.Style.SelectionBackColor = dsnv.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }
        private void dspb_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dspb.EnableHeadersVisualStyles = false;
            dspb.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dspb.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dspb.Columns[i].HeaderCell.Style.SelectionBackColor = dspb.Columns[i].HeaderCell.Style.BackColor = Color.FromArgb(18, 57, 166);

                    row.Cells[i].Style.BackColor = Color.White;
                    row.Cells[i].Style.ForeColor = Color.Black;

                }
            }
        }


        private void FormDuLieu_Load(object sender, EventArgs e)
        {
            loadDsCuDan();
            loadDsNv();
            loadDsPhongBan();
            loadDsTK();
            loadDsCanHo();
            loadDsQuyen();
            UpdateLanguage();
        }

        private void loadDsCuDan()
        {

            dscudan.DataSource = DatabaseAccess.GetAllCuDan().Tables[0];
            dscudan.AutoGenerateColumns = false;
            dscudan.Columns["maCD"].HeaderText = "Mã cư dân";
            dscudan.Columns["hinhthuc"].HeaderText = "Hình thức";
            dscudan.Columns["tenCH"].HeaderText = "Tên căn hộ";
            dscudan.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dscudan.Columns["cccd"].HeaderText = "CCCD";
            dscudan.Columns["sdt"].HeaderText = "Số điện thoại";
            dscudan.Columns["email"].HeaderText = "Email";
            dscudan.Columns["quoctich"].HeaderText = "Quốc tịch";
            dscudan.Columns["sothetamtru"].HeaderText = "Số thẻ tạm trú";
            dscudan.Columns["sdt_nguoithan"].HeaderText = "Số điện thoại người thân";
            dscudan.Columns["tinhtrangcongno"].HeaderText = "Tỉnh trạng công nợ";
            dscudan.Columns["dk_thucung"].HeaderText = "Đăng ký thú cưng";
        }


        private void loadDsNv()
        {

            dsnv.DataSource = DatabaseAccess.GetDangKyDoXe().Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["maDK"].HeaderText = "Mã đăng ký";
            dsnv.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsnv.Columns["bienso"].HeaderText = "Biển số";
            dsnv.Columns["chungloai"].HeaderText = "Chủng loại";
            dsnv.Columns["loai"].HeaderText = "Loại";


        }
        private void loadDsPhongBan()
        {

            dspb.DataSource = DatabaseAccess.GetChiphicanho().Tables[0];
            dspb.AutoGenerateColumns = false;
            dspb.Columns["maCD"].HeaderText = "Mã cư dân";
            dspb.Columns["maCH"].HeaderText = "Mã căn hộ";
            dspb.Columns["ngaybatdau"].HeaderText = "Ngày bắt đầu";
            dspb.Columns["ngayketthuc"].HeaderText = "Ngày kết thúc";
            dspb.Columns["sodien"].HeaderText = "Số điện";
            dspb.Columns["sonuoc"].HeaderText = "Số nước";
            dspb.Columns["phidien"].HeaderText = "Phí điện";
            dspb.Columns["phinuoc"].HeaderText = "Phí nước";
            dspb.Columns["CongNo"].HeaderText = "Công nợ";
            dspb.Columns["TongphiQuanLy"].HeaderText = "Tổng phí quản lý";
            dspb.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
            dspb.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";

        }
        private void loadDsCanHo()
        {
            dsch.DataSource = DatabaseAccess.GetAllCanHo().Tables[0];
            dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsch.Columns["maCD"].HeaderText = "Mã cư dân";
            dsch.Columns["ngaynhan"].HeaderText = "Ngày nhận";
            dsch.Columns["ngaychuyenvao"].HeaderText = "Ngày chuyển vào";
            dsch.Columns["ngaychuyendi"].HeaderText = "Ngày chuyển đi";
            dsch.Columns["phidv"].HeaderText = "Phí dịch vụ";
            dsch.Columns["phiql"].HeaderText = "Phí quản lý";
            dsch.Columns["dienngaynhan"].HeaderText = "Điện ngày nhận";
            dsch.Columns["nuocngaynhan"].HeaderText = "Điện ngày nhận";

        }
        private void loadDsQuyen()
        {
            dsqh.DataSource = DatabaseAccess.GetDVCH().Tables[0];
            dsqh.Columns["maCH"].HeaderText = "Mã căn hộ";
            dsqh.Columns["DV_dinhky"].HeaderText = "Dịch vụ định kỳ";
           


        }
        private void loadDsTK()
        {

            dstk.DataSource = DatabaseAccess.GetThanhVienCanHo().Tables[0];
            dstk.AutoGenerateColumns = false;
            dstk.Columns["maTV"].HeaderText = "Mã thành viên";
            dstk.Columns["maCD"].HeaderText = "Mã cư dân";
            dstk.Columns["tenTV"].HeaderText = "Tên thành viên";
            dstk.Columns["MoiQuanHe"].HeaderText = "Mối quan hệ";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataGridView dgv = null;
            btnluu.Enabled = true;

            // Xác định DataGridView tương ứng với tab đang được chọn
            if (tabDulieu.SelectedTab == CuDan)
                dgv = dscudan;
            else if (tabDulieu.SelectedTab == DangKyDoXe)
                dgv = dsnv;
            else if (tabDulieu.SelectedTab == Chiphicanho)
                dgv = dspb;
            else if (tabDulieu.SelectedTab == ThanhVienCanHo)
                dgv = dstk;
            else if (tabDulieu.SelectedTab == DVCanHo)
                dgv = dsqh;
            else if (tabDulieu.SelectedTab == CanHo)
                dgv = dsch;

            if (dgv != null)
            {
        
                dgv.ReadOnly = false;
            
            }
        }


        private void insertdscv(DataGridView dgv, string tableName)
        {
            if (dgv.Rows.Count > 0)
            {
           
                    DataGridViewRow lastRow = dgv.Rows[dgv.Rows.Count - 2];
                    string maCV = lastRow.Cells[0].Value?.ToString();
                    string ten = lastRow.Cells[2].Value?.ToString();
                    string ngayYC = lastRow.Cells[3].Value?.ToString();
                    DatabaseAccess.insertCV(maCV, ten, ngayYC);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cột Ngày Yêu Cầu trong DataGridView!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void updatedscv(DataGridView dgv, string tableName)
        {
            if (dgv.SelectedRows.Count >0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string maCV = selectedRow.Cells[0].Value?.ToString();
                string ten = selectedRow.Cells[2].Value?.ToString();
                string ngayYC = selectedRow.Cells[3].Value?.ToString();

                    DatabaseAccess.updateCV(maCV, ten, ngayYC);
                
                
            }
            
        }

        private void deldscv(DataGridView dgv, string tableName)
        {
         if (dgv.SelectedRows.Count >0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string maCV = selectedRow.Cells[0].Value?.ToString();
                    DatabaseAccess.deleteCV(maCV);
              
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            bool isDataValid = true;
            isDataValid &= CheckDataGridViewData(dsch);
            isDataValid &= CheckDataGridViewData(dscudan);
            isDataValid &= CheckDataGridViewData(dspb);
            isDataValid &= CheckDataGridViewData(dsnv);
            isDataValid &= CheckDataGridViewData(dstk);
            isDataValid &= CheckDataGridViewData(dsqh);

            if (isDataValid)
            {

                if (tabDulieu.SelectedTab == CuDan)
                {
                    SaveLastRowData(dscudan, "CuDan");
                }
                else if (tabDulieu.SelectedTab == DangKyDoXe)
                {
                    SaveLastRowData(dsnv, "DangKyDoXe");
                }
                else if (tabDulieu.SelectedTab == Chiphicanho)
                {
                    SaveLastRowData(dspb, "Chiphicanho");
                }
                else if (tabDulieu.SelectedTab == ThanhVienCanHo)
                {
                    SaveLastRowData(dstk, "ThanhVienCanHo");
                }
                else if (tabDulieu.SelectedTab == DVCanHo)
                {
                    SaveLastRowData(dsqh, "DVCanHo");
                    insertdscv(dsqh, "DVCanHo");

                }
                else if (tabDulieu.SelectedTab == CanHo)
                {
                    SaveLastRowData(dsch, "CanHo");
                }
            }
        }

        private void SaveLastRowData(DataGridView dgv, string tableName)
        {
            string selectedLanguage = GlobalSettings.Language;

            // Kiểm tra xem DataGridView có hàng nào không
            if (dgv.Rows.Count >=0)
            {
                // Lấy dữ liệu từ hàng cuối cùng của DataGridView
                DataGridViewRow lastRow = dgv.Rows[dgv.Rows.Count - 2];
                object[] rowData = new object[lastRow.Cells.Count];
                for (int i = 0; i < lastRow.Cells.Count; i++)
                {

                    rowData[i] = lastRow.Cells[i].Value;
                  
                }

                try
                {
                    // Thực hiện thêm dữ liệu vào cơ sở dữ liệu
                    DatabaseAccess.InsertData(tableName, dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.DataPropertyName).ToArray(), rowData);

                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Data has been saved to the database!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Giá trị đã tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("The value already exists in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show("Lỗi không xác định xảy ra. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show("An unknown error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("An error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Nếu không có hàng nào trong DataGridView, thông báo người dùng thêm dữ liệu trước
                MessageBox.Show("Please add data to the DataGridView first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private bool CheckDataGridViewData(DataGridView dgv)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dgv.CurrentRow != null && dgv.CurrentCell.RowIndex == dgv.Rows.Count - 1)
            {
              
                    foreach (DataGridViewCell cell in dgv.Rows[dgv.CurrentCell.RowIndex].Cells)
                    {

                        if (string.IsNullOrEmpty(cell.Value?.ToString()))

                        {
                            {
                                if (selectedLanguage == "Vietnamese")
                                {
                                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho hàng cuối cùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (selectedLanguage == "English")
                                {
                                    MessageBox.Show("Please enter complete information for the last row!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                dgv.CurrentCell = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0];
                                dgv.BeginEdit(true);
                                return false;
                            }
                        }
                    
                }
            }

            return true;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            DataGridView dgv = null;


            if (tabDulieu.SelectedTab == CuDan)
            {
                dgv = dscudan;
            }
            else if (tabDulieu.SelectedTab == DangKyDoXe)
            {
                dgv = dsnv;
            }
            else if (tabDulieu.SelectedTab == Chiphicanho)
            {
                dgv = dspb;
            }
            else if (tabDulieu.SelectedTab == ThanhVienCanHo)
            {
                dgv = dstk;
            }
            else if (tabDulieu.SelectedTab == DVCanHo)
            {
                dgv = dsqh;
            }
            else if (tabDulieu.SelectedTab == CanHo)
            {
                dgv = dsch;
            }

            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                object[] rowData = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowData[i] = selectedRow.Cells[i].Value;
                }

                string primaryKeyColumn = dgv.Columns[0].DataPropertyName;

                if (dgv == dsqh)
                {
                     primaryKeyColumn = dgv.Columns[0].DataPropertyName;

                }

                try
                {

                    DatabaseAccess.DeleteData(tabDulieu.SelectedTab.Name, new string[] { primaryKeyColumn }, new object[] { rowData[0]});
                    if (tabDulieu.SelectedTab == DVCanHo)
                    {
                   
                        deldscv(dsqh, "DVCanHo");
                        loadDsQuyen();
                    }

                    if (tabDulieu.SelectedTab == CuDan)
                    {
                        loadDsCuDan();
                    }
                    else if (tabDulieu.SelectedTab == DangKyDoXe)
                    {
                        loadDsNv();
                    }
                    else if (tabDulieu.SelectedTab == Chiphicanho)
                    {
                        loadDsPhongBan();
                    }
                    else if (tabDulieu.SelectedTab == ThanhVienCanHo)
                    {
                        loadDsTK();
                    }
                    else if (tabDulieu.SelectedTab == DVCanHo)
                    {
                        loadDsQuyen();
                    }
                    else if (tabDulieu.SelectedTab == CanHo)
                    {
                        loadDsCanHo();
                    }

                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("Data deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    if (selectedLanguage == "Vietnamese")
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (selectedLanguage == "English")
                    {
                        MessageBox.Show("An error occurred while deleting data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please select a row to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public static void deleteCV(string maCV)
        {
            // Gọi phương thức DeleteData từ lớp DatabaseAccess để thực hiện xóa dữ liệu
            try
            {
                DatabaseAccess.DeleteData("DsCongViec", new string[] { "maCV" }, new object[] { maCV });
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (nếu cần thiết)
                ex.ToString();
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            DataGridView dgv = null;

            if (tabDulieu.SelectedTab == CuDan)
            {
                dgv = dscudan;

            }
            else if (tabDulieu.SelectedTab == DangKyDoXe)
            {
                dgv = dsnv;

            }
            else if (tabDulieu.SelectedTab == Chiphicanho)
            {
                dgv = dspb;

            }
            else if (tabDulieu.SelectedTab == ThanhVienCanHo)
            {
                dgv = dstk;

            }
            else if (tabDulieu.SelectedTab == DVCanHo)
            {
                dgv = dsqh;
               

            }
            else if (tabDulieu.SelectedTab == CanHo)
            {
                dgv = dsch;


            }

            if (dgv != null)
            {
                List<int> changedRowsIndexes = GetChangedRowsIndexes(dgv);

                foreach (int rowIndex in changedRowsIndexes)
                {
                    DataGridViewRow row = dgv.Rows[rowIndex];
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }


                    string primaryKeyColumn = dgv.Columns[0].DataPropertyName;

                    try
                    {

                        string tableName = tabDulieu.SelectedTab.Name;


                        List<string> columnNames = new List<string>();
                        List<object> values = new List<object>();
                        for (int i = 1; i < dgv.Columns.Count; i++)
                        {
                            columnNames.Add(dgv.Columns[i].DataPropertyName);
                            values.Add(rowData[i]);
                        }


                        string[] conditionColumns = { primaryKeyColumn };

                        object[] conditionValues = { rowData[0] };


                        DatabaseAccess.UpdateData(tableName, columnNames.ToArray(), values.ToArray(), conditionColumns, conditionValues);
                        if (tabDulieu.SelectedTab == DVCanHo)
                        {
                            updatedscv(dsqh, "DVCanHo");
                        }

                            row.DataGridView.UpdateCellValue(row.Cells[0].ColumnIndex, row.Index);
                    }
                    catch (Exception ex)
                    {
                        if (selectedLanguage == "Vietnamese")
                        {
                            MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu hàng {rowIndex + 1}!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (selectedLanguage == "English")
                        {
                            MessageBox.Show($"An error occurred while updating row data {rowIndex + 1}!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


                dgv.ReadOnly = true;
                btnCapNhat.Enabled = false;
                btnluu.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = true;

                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Data updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("DataGridView not found to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private List<int> GetChangedRowsIndexes(DataGridView dataGridView)
        {
            List<int> changedRowsIndexes = new List<int>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool rowChanged = false;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && !row.Cells[i].Value.Equals(row.Cells[i].Tag))
                        {
                            rowChanged = true;
                            break;
                        }
                    }

                    if (rowChanged)
                    {
                        changedRowsIndexes.Add(row.Index);
                    }
                }
            }

            return changedRowsIndexes;
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = btnxoa.Enabled = btnthem.Enabled = false;
            btnCapNhat.Enabled = true;
            DataGridView dgv = null;


            if (tabDulieu.SelectedTab == CuDan)
            {
                dgv = dscudan;
                dscudan.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == DangKyDoXe)
            {
                dgv = dsnv;
                dsnv.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == Chiphicanho)
            {
                dgv = dspb;
                dspb.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == ThanhVienCanHo)
            {
                dgv = dstk;
                dstk.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == DVCanHo)
            {
                dgv = dsqh;
                dsqh.ReadOnly = false;
            }
            else if (tabDulieu.SelectedTab == CanHo)
            {
                dgv = dsch;
                dsch.ReadOnly = false;
            }



        }


        private void FormDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(selectedLanguage == "Vietnamese" ? "Bạn có muốn thoát chương trình không?" : "Do you want to exit the program?",
                                                      selectedLanguage == "Vietnamese" ? "Xác nhận" : "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CuDan_Click(object sender, EventArgs e)
        {

        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            string keyword = txbtimkiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("Please enter search keywords", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            DataGridView dgv = null;


            if (tabDulieu.SelectedTab == CuDan)
            {
                dgv = dscudan;
            }
            else if (tabDulieu.SelectedTab == DangKyDoXe)
            {
                dgv = dsnv;
            }
            else if (tabDulieu.SelectedTab == Chiphicanho)
            {
                dgv = dspb;
            }
            else if (tabDulieu.SelectedTab == ThanhVienCanHo)
            {
                dgv = dstk;
            }
            else if (tabDulieu.SelectedTab == DVCanHo)
            {
                dgv = dsqh;
            }
            else if (tabDulieu.SelectedTab == CanHo)
            {
                dgv = dsch;
            }

            if (dgv != null)
            {
                dgv.ClearSelection();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                        {
                            dgv.Rows[row.Index].Selected = true;
                            dgv.FirstDisplayedScrollingRowIndex = row.Index;
                            return;
                        }
                    }
                }

                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("No matches found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (selectedLanguage == "Vietnamese")
                {
                    MessageBox.Show("Không có DataGridView nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedLanguage == "English")
                {
                    MessageBox.Show("No DataGridView selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

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
        private void FormDuLieuCuDan_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dspb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dscudan);
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
                    ExportExcel(saveFileDialog.FileName, dscudan);
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

        private void buttonExportExcel3_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dsqh);
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

        private void buttonExportExcel4_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dstk);
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

        private void buttonExportExcel5_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dsnv);
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

        private void buttonExportExcel6_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DataGridViewExport.xlsx";
            saveFileDialog.Filter = "Excel (*xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName, dspb);
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
            string selectedLanguage = GlobalSettings.Language;
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

            if (dscudan.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dscudan);
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

        private void buttonXuatPDF3_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dsqh.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsqh);
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

        private void buttonXuatPDF4_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dstk.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dstk);
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

        private void buttonXuatPDF5_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dsnv.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dsnv);
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

        private void buttonXuatPDF6_Click(object sender, EventArgs e)
        {
            string selectedLanguage = GlobalSettings.Language;
            if (dspb.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DataGridViewExport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var htmlContent = GetHtmlFromDataGridView(dspb);
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
            // Lấy ngôn ngữ đã chọn từ biến global hoặc một cơ chế khác
            string selectedLanguage = GlobalSettings.Language;

            // Cập nhật ngôn ngữ cho các thành phần giao diện dựa trên ngôn ngữ đã chọn
            if (selectedLanguage == "Vietnamese")
            {
                DangKyDoXe.Text = "Đăng Ký Đỗ Xe";
                CuDan.Text = "Cư Dân";
                Chiphicanho.Text = "Chi Phí Căn Hộ";
                ThanhVienCanHo.Text = "Thành Viên Căn Hộ";
                CanHo.Text = "Căn Hộ";
                DVCanHo.Text = "Dịch Vụ Căn Hộ";

                btnthem.Text = "Thêm";
                btnxoa.Text = "Xóa";
                btnsua.Text = "Sửa";
                btnluu.Text = "Lưu";
                btnCapNhat.Text = "Cập Nhật";

                txbtimkiem.Text = "Nhập từ khóa...";
                

                // Datagrid "dscudan"
                dscudan.Columns["maCD"].HeaderText = "Mã cư dân";
                dscudan.Columns["hinhthuc"].HeaderText = "Hình thức";
                dscudan.Columns["tenCH"].HeaderText = "Tên căn hộ";
                dscudan.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dscudan.Columns["cccd"].HeaderText = "CCCD";
                dscudan.Columns["sdt"].HeaderText = "Số điện thoại";
                dscudan.Columns["email"].HeaderText = "Email";
                dscudan.Columns["quoctich"].HeaderText = "Quốc tịch";
                dscudan.Columns["sothetamtru"].HeaderText = "Số thẻ tạm trú";
                dscudan.Columns["sdt_nguoithan"].HeaderText = "Số điện thoại người thân";
                dscudan.Columns["tinhtrangcongno"].HeaderText = "Tình trạng công nợ";
                dscudan.Columns["dk_thucung"].HeaderText = "Đăng ký thú cưng";

                // Datagrid "dsnv"
                dsnv.Columns["maDK"].HeaderText = "Mã đăng ký";
                dsnv.Columns["maCH"].HeaderText = "Mã căn hộ";
                dsnv.Columns["bienso"].HeaderText = "Biển số";
                dsnv.Columns["chungloai"].HeaderText = "Chủng loại";
                dsnv.Columns["loai"].HeaderText = "Loại";

                // Datagrid "dspb"
                dspb.Columns["maCD"].HeaderText = "Mã cư dân";
                dspb.Columns["maCH"].HeaderText = "Mã căn hộ";
                dspb.Columns["ngaybatdau"].HeaderText = "Ngày bắt đầu";
                dspb.Columns["ngayketthuc"].HeaderText = "Ngày kết thúc";
                dspb.Columns["sodien"].HeaderText = "Số điện";
                dspb.Columns["sonuoc"].HeaderText = "Số nước";
                dspb.Columns["phidien"].HeaderText = "Phí điện";
                dspb.Columns["phinuoc"].HeaderText = "Phí nước";
                dspb.Columns["CongNo"].HeaderText = "Công nợ";
                dspb.Columns["TongphiQuanLy"].HeaderText = "Tổng phí quản lý";
                dspb.Columns["TongPhiDichVu"].HeaderText = "Tổng phí dịch vụ";
                dspb.Columns["TongChiPhiDienNuoc"].HeaderText = "Tổng chi phí điện nước";

                // Datagrid "dsch"
                dsch.Columns["maCH"].HeaderText = "Mã căn hộ";
                dsch.Columns["maCD"].HeaderText = "Mã cư dân";
                dsch.Columns["ngaynhan"].HeaderText = "Ngày nhận";
                dsch.Columns["ngaychuyenvao"].HeaderText = "Ngày chuyển vào";
                dsch.Columns["ngaychuyendi"].HeaderText = "Ngày chuyển đi";
                dsch.Columns["phidv"].HeaderText = "Phí dịch vụ";
                dsch.Columns["phiql"].HeaderText = "Phí quản lý";
                dsch.Columns["dienngaynhan"].HeaderText = "Điện ngày nhận";
                dsch.Columns["nuocngaynhan"].HeaderText = "Điện ngày nhận";

                // Datagrid "dsqh"
                dsqh.Columns["maCH"].HeaderText = "Mã căn hộ";
                dsqh.Columns["DV_dinhky"].HeaderText = "Dịch vụ định kỳ";
                dsqh.Columns["DV_dinhky"].HeaderText = "Dịch vụ ";
                dsqh.Columns["maCV"].HeaderText = "Mã công viec";
                dsqh.Columns["ngayYC"].HeaderText = "Ngày yêu cầu";


                dstk.Columns["maTV"].HeaderText = "Mã thành viên";
                dstk.Columns["maCD"].HeaderText = "Mã cư dân";
                dstk.Columns["tenTV"].HeaderText = "Tên thành viên";
                dstk.Columns["MoiQuanHe"].HeaderText = "Mối quan hệ";

                buttonXuatPDF.Text = "Xuất PDF";
                buttonExportExcel.Text = "Xuất Excel";

                buttonXuatPDF2.Text = "Xuất PDF";
                buttonExportExcel2.Text = "Xuất Excel";

                buttonXuatPDF3.Text = "Xuất PDF";
                buttonExportExcel3.Text = "Xuất Excel";

                buttonXuatPDF4.Text = "Xuất PDF";
                buttonExportExcel4.Text = "Xuất Excel";

            }
            else if (selectedLanguage == "English")
            {

                DangKyDoXe.Text = "Parking Registration";
                CuDan.Text = "Residents";
                Chiphicanho.Text = "Apartment Expenses";
                ThanhVienCanHo.Text = "Apartment Members";
                CanHo.Text = "Apartment";
                DVCanHo.Text = "Apartment Services";

                btnthem.Text = "Add";
                btnxoa.Text = "Delete";
                btnsua.Text = "Edit";
                btnluu.Text = "Save";
                btnCapNhat.Text = "Update";

                txbtimkiem.Text = "Enter keyword...";

                // Datagrid "dscudan"
                dscudan.Columns["maCD"].HeaderText = "Resident ID";
                dscudan.Columns["hinhthuc"].HeaderText = "Form";
                dscudan.Columns["tenCH"].HeaderText = "Apartment Name";
                dscudan.Columns["ngaysinh"].HeaderText = "Date of Birth";
                dscudan.Columns["cccd"].HeaderText = "ID Card";
                dscudan.Columns["sdt"].HeaderText = "Phone Number";
                dscudan.Columns["email"].HeaderText = "Email";
                dscudan.Columns["quoctich"].HeaderText = "Nationality";
                dscudan.Columns["sothetamtru"].HeaderText = "Temporary Residence Card Number";
                dscudan.Columns["sdt_nguoithan"].HeaderText = "Relative's Phone Number";
                dscudan.Columns["tinhtrangcongno"].HeaderText = "Debt Status";
                dscudan.Columns["dk_thucung"].HeaderText = "Pet Registration";

                // Datagrid "dsnv"
                dsnv.Columns["maDK"].HeaderText = "Registration ID";
                dsnv.Columns["maCH"].HeaderText = "Apartment ID";
                dsnv.Columns["bienso"].HeaderText = "License Plate";
                dsnv.Columns["chungloai"].HeaderText = "Category";
                dsnv.Columns["loai"].HeaderText = "Type";

                // Datagrid "dspb"
                dspb.Columns["maCD"].HeaderText = "Resident ID";
                dspb.Columns["maCH"].HeaderText = "Apartment ID";
                dspb.Columns["ngaybatdau"].HeaderText = "Start Date";
                dspb.Columns["ngayketthuc"].HeaderText = "End Date";
                dspb.Columns["sodien"].HeaderText = "Electricity";
                dspb.Columns["sonuoc"].HeaderText = "Water";
                dspb.Columns["phidien"].HeaderText = "Electricity Fee";
                dspb.Columns["phinuoc"].HeaderText = "Water Fee";
                dspb.Columns["CongNo"].HeaderText = "Debt";
                dspb.Columns["TongphiQuanLy"].HeaderText = "Total Management Fee";
                dspb.Columns["TongPhiDichVu"].HeaderText = "Total Service Fee";
                dspb.Columns["TongChiPhiDienNuoc"].HeaderText = "Total Electricity and Water Fee";

                // Datagrid "dsch"
                dsch.Columns["maCH"].HeaderText = "Apartment ID";
                dsch.Columns["maCD"].HeaderText = "Resident ID";
                dsch.Columns["ngaynhan"].HeaderText = "Receipt Date";
                dsch.Columns["ngaychuyenvao"].HeaderText = "Moving In Date";
                dsch.Columns["ngaychuyendi"].HeaderText = "Moving Out Date";
                dsch.Columns["phidv"].HeaderText = "Service Fee";
                dsch.Columns["phiql"].HeaderText = "Management Fee";
                dsch.Columns["dienngaynhan"].HeaderText = "Electricity on Receipt Date";
                dsch.Columns["nuocngaynhan"].HeaderText = "Water on Receipt Date";

                // Datagrid "dsqh"
                dsqh.Columns["maCH"].HeaderText = "Apartment ID";
                dsqh.Columns["DV_dinhky"].HeaderText = "Periodic Service";
                dsqh.Columns["maCV"].HeaderText = "Job ID";
                dsqh.Columns["ngayYC"].HeaderText = "Request date ";
              

                dstk.Columns["maTV"].HeaderText = "Member ID";
                dstk.Columns["maCD"].HeaderText = "Resident ID";
                dstk.Columns["tenTV"].HeaderText = "Member Name";
                dstk.Columns["MoiQuanHe"].HeaderText = "Relationship";

                buttonXuatPDF.Text = "Export PDF";
                buttonExportExcel.Text = "Export Excel";

                buttonXuatPDF2.Text = "Export PDF";
                buttonExportExcel2.Text = "Export Excel";

                buttonXuatPDF3.Text = "Export PDF";
                buttonExportExcel3.Text = "Export Excel";

                buttonXuatPDF4.Text = "Export PDF";
                buttonExportExcel4.Text = "Export Excel";



            }


        }
    }
}

