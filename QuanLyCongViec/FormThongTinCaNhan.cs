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
    public partial class FormThongTinCaNhan : Form
    {
        public bool isExit = true;
        public event EventHandler logout;
        public FormThongTinCaNhan()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hienmk.Checked){
                mk.UseSystemPasswordChar = false;
            }
            else
            {
                mk.UseSystemPasswordChar = true;
            }
        }

        private void FormThongTinCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void FormThongTinCaNhan_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            (NhanVien nv, TaiKhoan tk) = DatabaseAccess.layThongTin(Program.UserID);
            if (nv != null)
            {
                // Gắn dữ liệu vào các ô
                txtHoTen.Text = nv.hoten;
                dtpNgaySinh.Value = nv.ngaysinh;
                cboGioiTinh.SelectedItem = nv.gioitinh;
                txtDiaChi.Text = nv.diachi;
                txtDienThoai.Text = nv.didong;
                txtEmail.Text = nv.email;
                txtChucVu.Text = nv.chucvu;
                txtPhongBan.Text = nv.phongban;
                txtLuong.Text = nv.luong.ToString();
                txtTrangThai.Text = nv.trangthai;
                txtTrinhDoHocVan.Text = nv.trinhdohocvan;
                txtLoaiHinh.Text = nv.loaihinh;
                txbmnv.Text = nv.manv;

                cboloaitk.SelectedItem = tk.loaiTK;
                txbtentk.Text = tk.id;
                mk.Text = tk.mk;
                
                

            }



        }

        private void sua(object sender, EventArgs e)
        {
            groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled = true;
            txbtentk.Enabled = false;
            cboloaitk.Enabled=false;

        }

        private void luu(object sender, EventArgs e)
        {

        }

        private void thoat(object sender, EventArgs e)
        {
            logout(this, new EventArgs());
        }
    }
}
