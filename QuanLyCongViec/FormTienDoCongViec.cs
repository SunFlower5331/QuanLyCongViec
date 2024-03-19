using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class FormTienDoCongViec : Form
    {
        public FormTienDoCongViec()
        {
            InitializeComponent();
        }

        private void FormTienDoCongViec_Load(object sender, EventArgs e)
        {
            loadTienDoCongViec();
            
        }
        private void tuychonhienthi()
        {
            switch ("KT")
            {
                
                case "DV":
                    loadData("DV");
                    break;
                case "TC":
                    loadData("TC");
                    break;
                case "VS":
                    loadData("VS");
                    break;
                case "AN":
                    loadData("AN");
                    break;
                case "KT":
                    loadData("KT");
                    break;
                case "XD":
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

            dscv.DataSource = DatabaseAccess.GetCTCVTheoPhongBan(phongBan).Tables[0];
            dscv.AutoGenerateColumns = false;

            dscv.Columns["chucvu"].HeaderText = "Chức vụ";
            dscv.Columns["maCV"].HeaderText = "Mã công việc";
            dscv.Columns["ten"].HeaderText = "Tên công việc";
            dscv.Columns["maNV"].HeaderText = "Mã nhân viên";
            dscv.Columns["hoten"].HeaderText = "Tên nhân viên";
            dscv.Columns["trangthai"].HeaderText = "Trạng thái";
            dscv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
            dscv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
        }
        private void loadTienDoCongViec()
        {
            try
            {
                dscv.DataSource = DatabaseAccess.GetTienDoCongViec(Program.UserID);
                dscv.AutoGenerateColumns = false;
                dscv.Columns["maCV"].HeaderText = "Mã công việc";
                dscv.Columns["ten"].HeaderText = "Tên công việc";
                dscv.Columns["maCH"].HeaderText = "Mã căn hộ";
                dscv.Columns["trangthai"].HeaderText = "Trạng thái";
                dscv.Columns["thoiGianHoanThanh"].HeaderText = "Thời gian hoàn thành";
                dscv.Columns["songayhethan"].HeaderText = "Số ngày còn lại";
                dscv.Columns["Tuychonchiase"].HeaderText = "Tùy chọn chia sẻ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void cbotuychonchiase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbotuychonchiase.SelectedIndex == 2) {
                dsmanv.Visible = true;
            }
            else
            {
                dsmanv.Visible = false;
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            cbotrangthai.Enabled = true;
            cbotuychonchiase.Enabled = true;
        }

        private bool isThongTinKhVisible = false;

        private void btnthongtinkh_Click(object sender, EventArgs e)
        {
            isThongTinKhVisible = !isThongTinKhVisible;

            thongtinkh.Visible = isThongTinKhVisible;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            dsmanv.Visible = false;
            cbotuychonchiase.SelectedIndex = -1;
            cbotrangthai.SelectedIndex = -1;
        }

        private void dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tuychonhienthi();
        }
    }
}
