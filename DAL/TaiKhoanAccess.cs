using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class TaiKhoanAccess : DatabaseAccess
    {
        public string CheckLogic(TaiKhoan tk)
        {
            string info = CheckLogicDTO(tk);
            return info;
        }
    }
}
