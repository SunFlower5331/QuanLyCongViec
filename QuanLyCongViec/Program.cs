using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public static class Program
    {
        public static string UserID { get; set; }
        public static string getUserIDPB()
        {
            if (!string.IsNullOrEmpty(UserID))
            {
                int index = UserID.IndexOf('-');
                if (index != -1)
                {
                    return UserID.Substring(0, index);
                }
            }
            return UserID;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDuLieuCuDan());
        }
    }
}
