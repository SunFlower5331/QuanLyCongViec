using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void FormBaoCao_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //
    }
}
