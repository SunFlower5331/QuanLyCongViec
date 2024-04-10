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
    public partial class FormUpload_Download : Form
    {
        public FormUpload_Download()
        {
            InitializeComponent();
            //dsTaiLieu.CellFormatting += dsTaiLieu_CellFormatting;
        }
        //private void dsTaiLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    dsTaiLieu.EnableHeadersVisualStyles = false;
        //    dsTaiLieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    foreach (DataGridViewRow row in dsTaiLieu.Rows)
        //    {
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            dsTaiLieu.Columns[i].HeaderCell.Style.SelectionBackColor = dsTaiLieu.Columns[i].HeaderCell.Style.BackColor = Color.Firebrick;

        //            row.Cells[i].Style.BackColor = Color.FromArgb(56, 56, 56);
        //            row.Cells[i].Style.ForeColor = Color.White;

        //        }
        //    }
        //}

        // Dùng để kéo thả cửa sổ
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormUpload_Download_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }

    }
}
