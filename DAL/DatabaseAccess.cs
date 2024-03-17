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
        public static DataSet GetTienDoCongViec(string maNV)
        {
            DataSet data = new DataSet();
            string query = "select C.maCV,DSCV.ten,DVCH.maCH,C.trangthai,C.thoiGianHoanThanh\r\n,C.songayhethan,C.Tuychonchiase \r\nfrom CTCV C,DsCongViec DSCV,DVCanHo DVCH \r\nwhere C.maNV=@maNV AND C.maCV=DSCV.maCV AND DVCH.maCV=C.maCV  ";
            SqlConnection con = SqlConnectionData.connect();
            SqlCommand command = con.CreateCommand();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            command.Parameters.AddWithValue("@maNV", maNV);
            try
            {
                con.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            return data;
        }
        public static bool CheckDataExists(string tableName, string columnName, string value)
        {
            string conStr = "Data Source=ONG;Initial Catalog=QuanLyCongViec;Integrated Security=True;integrated security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();

                    // Truy vấn SQL để kiểm tra xem dữ liệu đã tồn tại trong bảng hay chưa
                    string query = $"SELECT COUNT(1) FROM {tableName} WHERE {columnName} = @value";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@value", value);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception)
                {
                   
                    return false;
                }
            }
        }
        public static bool IsDuplicateData(string tableName, string[] columns, object[] values)
        {
            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = $"SELECT COUNT(*) FROM {tableName} WHERE ";

              
                for (int i = 0; i < columns.Length; i++)
                {
                    command.CommandText += $"{columns[i]} = @param{i}";
                    command.Parameters.AddWithValue($"@param{i}", values[i]);
                    if (i < columns.Length - 1)
                        command.CommandText += " AND ";
                }

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
        public static DataSet GetAllDscv()
        {
            DataSet data = new DataSet();
            string query = "select * from DsCongViec";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select manv,hoten,phongban from NhanVien";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetCTCV()
        {
            DataSet data = new DataSet();
            string query = "" +
                "select  DSCV.maCV,DSCV.ten,NV.maNV,NV.hoten,NV.phongban,C.trangthai,C.thoiGianHoanThanh,C.Tuychonchiase " +
                "from CTCV C,DsCongViec DSCV,NhanVien NV " +
                "WHERE C.maCV=DSCV.maCV AND C.maNV=NV.maNV";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
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
                        nhanVien.quyenhan =Convert.ToInt32(reader["quyenhan"]);

                        tk.id = reader["id"].ToString();
                        tk.mk = reader["mk"].ToString();
                        
                    }
                }
            }

            return (nhanVien, tk);
        }
        public static bool CapNhatThongTinNhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string didong, string email, string chucvu, string phongban, double luong, string trangthai, string trinhdohocvan, string loaihinh,int quyenhan)
        {
            string query = "UPDATE NhanVien SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, didong = @didong, email = @email,quyenhan=@quyenhan, ";
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
                cmd.Parameters.AddWithValue("@quyenhan", quyenhan);

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
                parameterNames[i] = $"@{columnNames[i]}";
            }

            string sql = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", parameterNames)})";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                for (int i = 0; i < columnNames.Length; i++)
                {
                    command.Parameters.AddWithValue(parameterNames[i], values[i]);
                }

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    
                }
                catch (Exception )
                {
                 
                }
            }
        }
        public static void delCTCV(int maCV)
        {
            string sql = "DELETE FROM CTCV WHERE maCV =@maCV";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@maCV", maCV);
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                }catch (Exception )
                {

                }

            }

        }
        public static void DeleteData(string tableName, string[] columnNames, object[] values)
        {
           
            string[] conditions = new string[columnNames.Length];
            for (int i = 0; i < columnNames.Length; i++)
            {
                conditions[i] = $"{columnNames[i]} = @{columnNames[i]}"; 
            }

        
            string sql = $"DELETE FROM {tableName} WHERE {string.Join(" AND ", conditions)}";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                for (int i = 0; i < columnNames.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{columnNames[i]}", values[i]); 
                }

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                

                    throw ex;
                }
            }
        }
        public static void UpdateData(string tableName, string[] columnNames, object[] values, string[] conditionColumns, object[] conditionValues)
        {
            
            string[] setStatements = new string[columnNames.Length];
            for (int i = 0; i < columnNames.Length; i++)
            {
                setStatements[i] = $"{columnNames[i]} = @{columnNames[i]}";
            }

            string[] conditions = new string[conditionColumns.Length];
            for (int i = 0; i < conditionColumns.Length; i++)
            {
                conditions[i] = $"{conditionColumns[i]} = @{conditionColumns[i]}";
            }

           
            string sql = $"UPDATE {tableName} SET {string.Join(", ", setStatements)} WHERE {string.Join(" AND ", conditions)}";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

               
                for (int i = 0; i < columnNames.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{columnNames[i]}", values[i]);
                }

                
                for (int i = 0; i < conditionColumns.Length; i++)
                {
                    command.Parameters.AddWithValue($"@{conditionColumns[i]}", conditionValues[i]);
                }

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                
                    throw ex; 
                }
            }
        }



    }
}
