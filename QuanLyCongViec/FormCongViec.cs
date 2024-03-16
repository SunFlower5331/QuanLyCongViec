using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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






        private void FormCongViec_Load(object sender, EventArgs e)
        {
            loadDsNv();
            loadDsCongViec();
            loadCTCV();
            cbotrangthai.SelectedIndex = 0;

        }
        private void loadDsNv()
        {

            dsnv.DataSource = DatabaseAccess.GetNhanVien().Tables[0];
            dsnv.AutoGenerateColumns = false;
            dsnv.Columns["manv"].HeaderText = "Mã nhân viên";
            dsnv.Columns["hoten"].HeaderText = "Họ và tên";
            dsnv.Columns["phongban"].HeaderText = "Phòng ban";
        }
        private void loadDsCongViec()
        {
            dscv.DataSource = DatabaseAccess.GetAllDscv().Tables[0];
            dscv.AutoGenerateColumns = false;
            dscv.Columns["maCV"].HeaderText = "Mã công việc";
            dscv.Columns["ten"].HeaderText = "Tên công việc";

        }
        private void loadCTCV()
        {
            dsdpc.DataSource = DatabaseAccess.GetCTCV().Tables[0];
            dsdpc.AutoGenerateColumns = false;
            dsdpc.Columns["maCV"].HeaderText = "Mã công việc";
            dsdpc.Columns["ten"].HeaderText = "Tên công việc";
            dsdpc.Columns["maNV"].HeaderText = "Mã nhân viên";
            dsdpc.Columns["hoten"].HeaderText = "Tên nhân viên";
            dsdpc.Columns["phongban"].HeaderText = "Phòng ban";
            dsdpc.Columns["trangthai"].HeaderText = "Trạng thái";
            dsdpc.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dsdpc.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            
        }
        private void dscv_Click(Object sender, EventArgs e)
        {
            if (dscv.CurrentRow != null)
            {
                DataGridViewRow row1 = dscv.CurrentRow;
                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();

            }

        }
        private void dsnv_Click(Object sender, EventArgs e)
        {
            if (dsnv.CurrentRow != null)
            {
                DataGridViewRow row2 = dsnv.CurrentRow;
                tbobophan.Text = row2.Cells["phongban"].Value.ToString();
                tbotennv.Text = row2.Cells["hoten"].Value.ToString();
                tbomanv.Text = row2.Cells["maNV"].Value.ToString();
                btnphancong.Enabled = true;
            }
        }
        private void dsdpc_Click(object sender, EventArgs e)
        {
            if (dsdpc.CurrentRow != null)
            {
                //dscv.Enabled= false;
                //dsnv.Enabled= false;
                btnphancong.Enabled = false;
                DataGridViewRow row1 = dsdpc.CurrentRow;

                tbomacv.Text = row1.Cells["maCV"].Value.ToString();
                tbotencv.Text = row1.Cells["ten"].Value.ToString();
                tbobophan.Text = row1.Cells["phongban"].Value.ToString();
                tbotennv.Text = row1.Cells["hoten"].Value.ToString();
                tbomanv.Text = row1.Cells["maNV"].Value.ToString();
                dtpthoihan.Text = row1.Cells["thoiGianHoanThanh"].Value.ToString();
                cbotuychonchiase.Text = row1.Cells["Tuychonchiase"].Value.ToString();
                cbotrangthai.Text = row1.Cells["trangthai"].Value.ToString() ;

            }
        }
        private void btnphancong_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các ô dữ liệu không được để trống
                if (string.IsNullOrEmpty(tbomacv.Text) || string.IsNullOrEmpty(tbomanv.Text) || string.IsNullOrEmpty(cbotuychonchiase.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng việc lưu dữ liệu nếu có ô dữ liệu trống
                }

                // Lấy thông tin từ các ô dữ liệu
                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;

                // Thực hiện lưu dữ liệu vào database
                DatabaseAccess.InsertData("CTCV", new string[] { "maCV", "maNV", "trangthai", "thoiGianHoanThanh", "Tuychonchiase" },
                    new object[] { maCV, maNV, "Chưa hoàn thành", thoiGianHoanThanh, tuyChonChiaSe });

                // Load lại dữ liệu sau khi lưu
                loadCTCV();

                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void btnchinhsuaphancong_Click(object sender, EventArgs e)
        {
            try
            {
                dscv.Enabled = false;

                // Lấy dữ liệu từ các controls trên form
                string maCV = tbomacv.Text;
                string maNV = tbomanv.Text;
                DateTime thoiGianHoanThanh = dtpthoihan.Value;
                string tuyChonChiaSe = cbotuychonchiase.Text;

                // Xác định các điều kiện để cập nhật dữ liệu
                string[] conditionColumns = { "maCV" };
                object[] conditionValues = { maCV };

                // Cập nhật dữ liệu trong bảng "CTCV" với các điều kiện tương ứng
                DatabaseAccess.UpdateData("CTCV", new string[] { "maNV", "thoiGianHoanThanh", "Tuychonchiase" },
                    new object[] { maNV, thoiGianHoanThanh, tuyChonChiaSe }, conditionColumns, conditionValues);

                // Load lại dữ liệu sau khi cập nhật
                loadCTCV();

                // Hiển thị thông báo khi cập nhật thành công
                MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo khi có lỗi xảy ra
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật dữ liệu!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }





}
