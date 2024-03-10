using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public string CheckLogic(TaiKhoan tk)
        {
            if (tk.id == "")
            {
                return "Require_taikhoan";
            }
            if (tk.mk == "")
            {
                return "Require_matkhau";
            }
            string info = tkAccess.CheckLogic(tk);
            return info;
        }
    }
}
