using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CuDan
    {
        public int maCD { get; set; }
        public string hinhthuc { get; set; }
        public string tenCH { get; set; }
        public DateTime ngaysinh { get; set; }
        public string cccd { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string quoctich { get; set; }
        public string sothetamtru { get; set; }
        public string sdt_nguoithan { get; set; }
        public float tinhtrangcongno { get; set; }
        public string dk_thucung { get; set; }
        public bool IsValid()
        {
            // Kiểm tra các trường bắt buộc
            if (maCD <= 0 || string.IsNullOrWhiteSpace(hinhthuc) || string.IsNullOrWhiteSpace(tenCH) || ngaysinh == default(DateTime) || string.IsNullOrWhiteSpace(cccd) || string.IsNullOrWhiteSpace(sdt_nguoithan) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(quoctich) || string.IsNullOrWhiteSpace(sothetamtru) || string.IsNullOrWhiteSpace(sdt_nguoithan))
            {
                return false;
            }

            // Kiểm tra tính hợp lệ của email
            if (!IsValidEmail(email))
            {
                return false;
            }

            // Các kiểm tra khác có thể thêm ở đây

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
