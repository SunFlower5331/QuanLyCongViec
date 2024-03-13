using DTO;
using System;
using System.Collections;
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
            string conStr = "Data Source=BAOHAN;Initial Catalog=QuanLyCongViec;Integrated Security=True;integrated security=True";
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
        public static DataSet GetAllCuDan()
        {
            DataSet data=new DataSet();
            string query = "select * from CuDan";
            SqlConnection con = SqlConnectionData.connect(); con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter( query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetAllPhongBan()
        {
            DataSet data = new DataSet();
            string query = "select * from PhongBan";
            SqlConnection con = SqlConnectionData.connect(); con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }

        public static DataSet GetAllTK()
        {
            DataSet data = new DataSet();
            string query = "select * from TaiKhoan";
            SqlConnection con=SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;

        }
        public static DataSet GetAllQuyen()
        {
            DataSet data = new DataSet();
            string query = "select * from Quyen";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;

        }
        public static DataSet GetAllCanHo()
        {
            DataSet data = new DataSet();
            string query = "select * from CanHo";
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
            string query = "SELECT NhanVien.*, TaiKhoan.* FROM NhanVien,TaiKhoan WHERE NhanVien.manv = TaiKhoan.id AND NhanVien.manv = @manv";

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

                        // Kiểm tra và gán giá trị cho các trường
                        nhanVien.manv = reader["manv"].ToString();
                        nhanVien.hoten = reader["hoten"].ToString();
                        nhanVien.ngaysinh = reader.IsDBNull(reader.GetOrdinal("ngaysinh")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("ngaysinh"));
                        nhanVien.gioitinh = reader["gioitinh"].ToString();
                        nhanVien.diachi = reader["diachi"].ToString();
                        nhanVien.didong = reader["didong"].ToString();
                        nhanVien.email = reader["email"].ToString();
                        nhanVien.chucvu = reader["chucvu"].ToString();
                        nhanVien.phongban = reader["phongban"].ToString();
                        nhanVien.luong = reader.IsDBNull(reader.GetOrdinal("luong")) ? 0 : Convert.ToDouble(reader["luong"]);
                        nhanVien.trangthai = reader["trangthai"].ToString();
                        nhanVien.trinhdohocvan = reader["trinhdohocvan"].ToString();
                        nhanVien.loaihinh = reader["loaihinh"].ToString();
                        nhanVien.quyenhan = reader.IsDBNull(reader.GetOrdinal("quyenhan")) ? 0 : Convert.ToInt32(reader["quyenhan"]);

                        tk.id = reader["id"].ToString();
                        tk.mk = reader["mk"].ToString();
                        
                    }
                }
            }

            return (nhanVien, tk);
        }
        public static bool CapNhatThongTinNhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string didong, string email, string chucvu, string phongban, double luong, string trangthai, string trinhdohocvan, string loaihinh)
        {
            string query = "UPDATE NhanVien SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, didong = @didong, email = @email, ";
            query += "chucvu = @chucvu, phongban = @phongban, luong = @luong, trangthai = @trangthai, trinhdohocvan = @trinhdohocvan, loaihinh = @loaihinh WHERE manv = @manv";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@hoten", hoten);
                cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@didong", didong);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@chucvu", chucvu);
                cmd.Parameters.AddWithValue("@phongban", phongban);
                cmd.Parameters.AddWithValue("@luong", luong);
                cmd.Parameters.AddWithValue("@trangthai", trangthai);
                cmd.Parameters.AddWithValue("@trinhdohocvan", trinhdohocvan);
                cmd.Parameters.AddWithValue("@loaihinh", loaihinh);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public static bool CapNhatThongTinTaiKhoan(string id, string mk, int loaiTK)
        {
            string query = "UPDATE TaiKhoan SET mk = @mk, loaiTK = @loaiTK WHERE id = @id";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@mk", mk);
                cmd.Parameters.AddWithValue("@loaiTK", loaiTK);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public static void InsertData(string tableName, string[] columnNames, object[] values)
        {
            string[] parameterNames = new string[columnNames.Length];
            for (int i = 0; i < columnNames.Length; i++)
            {
                parameterNames[i] = $"@{columnNames[i]}"; // Tạo tên tham số cho mỗi cột
            }

            string sql = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", parameterNames)})";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                for (int i = 0; i < columnNames.Length; i++)
                {
                    command.Parameters.AddWithValue(parameterNames[i], values[i]); // Sử dụng tên tham số
                }

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý exception tại đây
                    
                    throw ex;
                }
            }
        }
        public static void DeleteData(string tableName, string[] columnNames, object[] values)
        {
            // Tạo điều kiện cho lệnh DELETE
            string[] conditions = new string[columnNames.Length];
            for (int i = 0; i < columnNames.Length; i++)
            {
                conditions[i] = $"{columnNames[i]} = @{columnNames[i]}"; // Tạo điều kiện cho mỗi cột
            }

            // Tạo câu lệnh DELETE SQL
            string sql = $"DELETE FROM {tableName} WHERE {string.Join(" AND ", conditions)}";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                for (int i = 0; i < columnNames.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{columnNames[i]}", values[i]); // Sử dụng tên tham số
                }

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý exception tại đây

                    throw ex;
                }
            }
        }
        public static void UpdateData(string tableName, string[] columnNames, object[] values, string[] conditionColumns, object[] conditionValues)
        {
            // Tạo danh sách các câu lệnh SET cần cập nhật
            string[] setStatements = new string[columnNames.Length];
            for (int i = 0; i < columnNames.Length; i++)
            {
                setStatements[i] = $"{columnNames[i]} = @{columnNames[i]}"; // Tạo câu lệnh SET cho mỗi cột
            }

            // Tạo điều kiện cho lệnh UPDATE
            string[] conditions = new string[conditionColumns.Length];
            for (int i = 0; i < conditionColumns.Length; i++)
            {
                conditions[i] = $"{conditionColumns[i]} = @{conditionColumns[i]}"; // Tạo điều kiện cho mỗi cột
            }

            // Tạo câu lệnh SQL UPDATE hoàn chỉnh
            string sql = $"UPDATE {tableName} SET {string.Join(", ", setStatements)} WHERE {string.Join(" AND ", conditions)}";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                // Thêm các tham số cho phần SET
                for (int i = 0; i < columnNames.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{columnNames[i]}", values[i]);
                }

                // Thêm các tham số cho phần WHERE (điều kiện)
                for (int i = 0; i < conditionColumns.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{conditionColumns[i]}", conditionValues[i]);
                }

                try
                {
                    con.Open();
                    command.ExecuteNonQuery(); // Thực thi lệnh UPDATE
                }
                catch (Exception ex)
                {
                    // Xử lý exception tại đây
                    throw ex; // Ném lại exception để xử lý ở lớp gọi phương thức
                }
            }
        }



    }
}
