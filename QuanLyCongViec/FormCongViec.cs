using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class FormCongViec : Form
    {
        public FormCongViec()
        {
            InitializeComponent();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();

        }
        private void FormCongViec_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


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

        private void FormCongViec_Load(object sender, EventArgs e)
        {
            dtpthoihan.Format = DateTimePickerFormat.Short;
            dtpthoihan.CustomFormat = "dd/MM/yyyy";
            loadDsCongViec();
            cbotrangthai.SelectedIndex = 0;
            cbotuychonhienthi.SelectedIndex = 0;
            tuychonhienthi();

            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;


        }
        private void cbotuychonhienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tuychonhienthi();

        }
        private void tuychonhienthi()
        {
            switch (cbotuychonhienthi.SelectedIndex)
            {
                case 0:
                    loadDsNv();
                    loadCTCV();
                    break;
                case 1:
                    loadData("DV");
                    break;
                case 2:
                    loadData("TC");
                    break ;
                case 3:
                    loadData("VS");
                    break;
                case 4:
                    loadData("AN");
                    break;
                case 5:
                    loadData("KT");
                    break;
                case 6:
                    loadData("XD");
                    break;
               
            }
        }

        private void loadData(string phongBan)
        {
            dsnv.DataSource = DatabaseAccess.GetNhanVienTheoPhongBan(phongBan).Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["chucvu"].HeaderText = "Chức vụ";
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";

            dsdpc.DataSource = DatabaseAccess.GetCTCVTheoPhongBan(phongBan).Tables[0];
            dsdpc.AutoGenerateColumns = false;
           
            dsdpc.Columns["chucvu"].HeaderText = "Chức vụ";
            dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
            dsdpc.Columns["ten"].HeaderText = "Tên công việc";
            dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
            dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";
            dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
            dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
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

        }
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
            dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";

        }
        private void dscv_Click(Object sender, EventArgs e)
        {
           
            btnchinhsuaphancong.Enabled = false;
            if (dscv.CurrentRow != null && dscv.CurrentRow.Index >0)
            {
                DataGridViewRow row1 = dscv.CurrentRow;
                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();


            }

        }
        private void dsnv_Click(object sender, EventArgs e)
        {
            if (dsnv.CurrentRow != null && dsnv.CurrentRow.Index >0)
            {
                DataGridViewRow row2 = dsnv.CurrentRow;
                tbobophan.Text = row2.Cells["phongban"].Value.ToString();
                tbotennv.Text = row2.Cells["hoten"].Value.ToString();
                tbomanv.Text = row2.Cells["maNV"].Value.ToString();
            }
        }

        private void dsdpc_Click(object sender, EventArgs e)
        {
            dscv.CurrentCell = null;
            if (dsdpc.CurrentRow != null && dsdpc.CurrentRow.Index >0)
            {
                btnchinhsuaphancong.Enabled = true;
                DataGridViewRow row1 = dsdpc.CurrentRow;

                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();
                tbobophan.Text = row1.Cells["phongban"].Value.ToString();
                tbotennv.Text = row1.Cells["hoten"].Value.ToString();
                tbomanv.Text = row1.Cells["maNV"].Value.ToString();
                dtpthoihan.Text = row1.Cells["thoiGianHoanThanh"].Value.ToString();
                cbotuychonchiase.Text = row1.Cells["Tuychonchiase"].Value.ToString();
                cbotrangthai.Text = row1.Cells["trangthai"].Value.ToString();

            }
        }
        private void btnphancong_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(tbomacv.Text) || string.IsNullOrEmpty(tbomanv.Text) || string.IsNullOrEmpty(cbotuychonchiase.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;


                if (DatabaseAccess.IsDuplicateData("CTCV", new string[] { "maCV", "maNV" }, new object[] { maCV, maNV }))
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DatabaseAccess.InsertData("CTCV", new string[] { "maCV", "maNV", "trangthai", "thoiGianHoanThanh", "Tuychonchiase" },
                    new object[] { maCV, maNV, "Chưa hoàn thành", thoiGianHoanThanh, tuyChonChiaSe });

                loadCTCV();
                
                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }
        private void btnchinhsuaphancong_Click(object sender, EventArgs e)
        {
            try
            {

                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;

                string[] conditionColumns = { "maCV" };
                object[] conditionValues = { maCV };

                DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase" },
                    new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe }, conditionColumns, conditionValues);
                loadCTCV();
               tbomacv.Text = "";
                tbotencv.Text = "";
                tbobophan.Text = "";
                tbotennv.Text = "";
                tbomanv.Text = "";
                dtpthoihan.Text = "";
                cbotuychonchiase.Text = "";
                cbotrangthai.Text = "";
                dsnv.CurrentCell = null;
                dscv.CurrentCell = null;
                dsdpc.CurrentCell = null;
                dsnv.CurrentCell = null;
                dscv.CurrentCell = null;
                dsdpc.CurrentCell = null;
                MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;


        }

 

        private void btnthem_Click(object sender, EventArgs e)
        {
            dscv.AllowUserToAddRows = true;
            btnluu.Enabled = true;

            dscv.CurrentCell = dscv.Rows[dscv.Rows.Count - 1].Cells[0];
            dscv.BeginEdit(true);
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                dscv.Enabled = true;
                if (dscv.CurrentRow != null && dscv.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dscv.CurrentRow;
                    string maCV = selectedRow.Cells["maCV"].Value.ToString();
                    string ten = selectedRow.Cells["ten"].Value.ToString();

                    string[] conditionColumns = { "maCV", "ten" };
                    object[] conditionValues = { maCV, ten };

                    DatabaseAccess.DeleteData("DsCongViec", conditionColumns, conditionValues);

                    loadDsCongViec();
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dsdpc.CurrentRow != null && dsdpc.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dsdpc.CurrentRow;
                    int maCV = Convert.ToInt32(selectedRow.Cells["maCV"].Value);
                    DatabaseAccess.delCTCV(maCV);

                    loadCTCV();
                   
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
               
                DataGridViewRow newRow = dscv.Rows[dscv.Rows.Count - 2];
                foreach (DataGridViewCell cell in newRow.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string maCV = newRow.Cells["maCV"].Value.ToString();
                string ten = newRow.Cells["ten"].Value.ToString();

                // Kiểm tra xem dữ liệu đã tồn tại trong cơ sở dữ liệu chưa
                bool dataExists = DatabaseAccess.CheckDataExists("DsCongViec", "maCV", maCV);
                if (dataExists)
                {
                    MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu|Bạn chưa nhập dữ liệu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu dữ liệu chưa tồn tại, thêm vào cơ sở dữ liệu
                DatabaseAccess.InsertData("DsCongViec",
                    new string[] { "maCV", "ten" },
                    new object[] { maCV, ten });
               
                MessageBox.Show("Đã thêm dữ liệu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDsCongViec();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm dữ liệu mới!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
           
            // Lấy thông tin từ hàng được chọn trong DataGridView
            if (dscv.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dscv.CurrentRow;
                string maCV = selectedRow.Cells["maCV"].Value.ToString(); // Giả sử cột maCV là cột chứa mã công việc
                                                                          // Lấy thông tin cập nhật từ các điều khiển khác trên form
                string tenMoi = selectedRow.Cells["ten"].Value.ToString(); // Ví dụ, txtTenMoi là TextBox chứa tên mới cần cập nhật

                // Cập nhật dữ liệu trong cơ sở dữ liệu
                try
                {
                    // Gọi phương thức UpdateData để cập nhật dữ liệu
                    DatabaseAccess.UpdateData("DsCongViec", new string[] { "ten" }, new object[] { tenMoi }, new string[] { "maCV" }, new object[] { maCV });
                    MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                    loadDsCongViec(); // Gọi phương thức loadDsCongViec để làm mới dữ liệu trong DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dsnv.CurrentCell = null;
            dscv.CurrentCell = null;
            dsdpc.CurrentCell = null;
        }


    }
}


