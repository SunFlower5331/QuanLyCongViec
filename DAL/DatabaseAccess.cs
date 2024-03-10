using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection connect()
        {
            string conStr = "Data Source=ONG;Initial Catalog=QuanLyCongViec;Integrated Security=True;integrated security=True";
            SqlConnection con = new SqlConnection(conStr);
            return con;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan tk)
        {
            string user = null;
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_logic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", tk.id);
            cmd.Parameters.AddWithValue("@pass", tk.mk);
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }

                reader.Close();
                con.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;

        }
        public static DataSet GetAllNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select * from NhanVien";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();    
            return data;
        }
        public static (NhanVien, TaiKhoan) layThongTin(string manv)
        {
            NhanVien nhanVien = null;
            TaiKhoan tk = null;
            string query = "SELECT NhanVien.*, TaiKhoan.* FROM NhanVien INNER JOIN TaiKhoan ON NhanVien.manv = TaiKhoan.id WHERE NhanVien.manv = @manv";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@manv", manv);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nhanVien = new NhanVien();
                        tk = new TaiKhoan();

                        nhanVien.manv = reader["manv"].ToString();
                        nhanVien.hoten = reader["hoten"].ToString();
                        nhanVien.ngaysinh = (DateTime)reader["ngaysinh"];
                        nhanVien.gioitinh = reader["gioitinh"].ToString();
                        nhanVien.diachi = reader["diachi"].ToString();
                        nhanVien.didong = reader["didong"].ToString();
                        nhanVien.email = reader["email"].ToString();
                        nhanVien.chucvu = reader["chucvu"].ToString();
                        nhanVien.phongban = reader["phongban"].ToString();
                        nhanVien.luong = Convert.ToDouble(reader["luong"]);
                        nhanVien.trangthai = reader["trangthai"].ToString();
                        nhanVien.trinhdohocvan = reader["trinhdohocvan"].ToString();
                        nhanVien.loaihinh = reader["loaihinh"].ToString();
                        nhanVien.quyenhan = Convert.ToInt32(reader["quyenhan"]);

                        tk.id = reader["id"].ToString();
                        tk.mk = reader["mk"].ToString();
                        tk.loaiTK = Convert.ToInt32(reader["loaiTK"]);
                    }
                }
            }

            return (nhanVien,tk);
        }




    }
}
