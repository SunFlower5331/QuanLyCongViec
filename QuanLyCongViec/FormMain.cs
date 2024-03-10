using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace QuanLyCongViec
{
    
    public partial class FormMain : Form
    {
        public bool isExit = true;
        public event EventHandler logout;
        public FormMain()
        {
            InitializeComponent();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {

        }

        private void chưaHoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout(this,new EventArgs());


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStrip1.Enabled = false;
            timkiem.Enabled = true;
            dsnv.DataSource = GetAllNhanVien();
            dsnv.DataMenber=
        }
 
        private void them(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan f=new FormThongTinCaNhan();
            f.Show();
            this.Hide();
            f.logout += F_logout;

        }

        private void F_logout(object sender, EventArgs e)
        {
            (sender as FormThongTinCaNhan).isExit = false;
            (sender as FormThongTinCaNhan).Close();
            this.Show();
        }

        private void dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
