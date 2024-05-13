using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection connect()
        {

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
           
            return con;
        }
    }
    public class DatabaseAccess
    {
        public static object MessageBox { get; private set; }

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
        public static List<string> GetPhongBanData()
        {
            List<string> data = new List<string>();
            string query = "SELECT id FROM PhongBan";
            
            try
            {
                using (SqlConnection con = SqlConnectionData.connect())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["id"].ToString();
                                
                               
                                data.Add(id);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data from database: " + ex.Message);
            }

            return data;
        }
        public static bool CheckCV(string maCV,string maNV)
        {
           
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_CV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maCV", maCV);
            cmd.Parameters.AddWithValue("@maNV", maNV);
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                con.Close();
                return true;
                
       
            }
            return  false;


        }
        public static DataTable getNV()
        {
            DataTable dt = new DataTable();
            string sql = "select phongban,maNV,hoten,email from NhanVien";
            try
            {
                using(SqlConnection con = SqlConnectionData.connect()) { 
                con.Open();
                SqlDataAdapter adapter=new SqlDataAdapter(sql,con);
                    adapter.Fill(dt);
                
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public static int getUserQuyen(string id)
        {
            int loaiTK = 0;
            string query = "SELECT loaiTK FROM TaiKhoan WHERE id = @id";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open(); 

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    loaiTK = Convert.ToInt32(reader["loaiTK"]);
                }
            }

            return loaiTK;
        }


        public static DataSet GetTienDoCongViec(string maNV)
        {
            DataSet data = new DataSet();
            string query = "SELECT C.maCV, DSCV.ten,  C.trangthai, C.thoiGianHoanThanh, C.songayhethan, C.Tuychonchiase, C.ngaycapnhat " +
               "FROM CTCV C, DsCongViec DSCV " +
               "WHERE C.maNV = @maNV AND C.maCV = DSCV.maCV ";


            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data); 
            }

            return data;
        }
        public static DataSet GetNhanVienTheoPhongBan(string phongban)
        {
            DataSet data = new DataSet();
            string query = "select phongban,chucvu,manv,hoten from NhanVien WHERE @phongban=phongban";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@phongban", phongban);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static string getManv(string jobCode)
        {
            string employeeID = null;
            string query = "SELECT manv FROM CTCV WHERE macv = @macv";

            using (SqlConnection connection = SqlConnectionData.connect())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@macv", jobCode);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeID = reader["manv"].ToString();
                        }
                    }
                }
            }

            return employeeID;
        }

        public static DataSet GetCTCVTheoPhongBan(string phongban)
        {
            DataSet data = new DataSet();
            string query = "select  NV.phongban,NV.chucvu,DSCV.maCV,DSCV.ten,NV.maNV,NV.hoten,C.trangthai,C.thoiGianHoanThanh,C.Tuychonchiase, C.ngaycapnhat " +
                "from CTCV C,DsCongViec DSCV,NhanVien NV " +
                "WHERE C.maCV=DSCV.maCV AND C.maNV=NV.maNV and NV.phongban=@phongban";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@phongban", phongban);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data); // Thực hiện truy vấn và gán kết quả vào DataSet
            }

            return data;
        }


        public static bool CheckDataExists(string tableName, string columnName, string value)
        {
            
            using (SqlConnection con = SqlConnectionData.connect())
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
            string query = "select phongban,chucvu, manv,hoten from NhanVien";
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
                "select NV.phongban,NV.chucvu,DSCV.maCV,DSCV.ten,NV.maNV,NV.hoten,C.trangthai,C.thoiGianHoanThanh,C.songayhethan,C.Tuychonchiase, C.ngaycapnhat " +
                "from CTCV C,DsCongViec DSCV,NhanVien NV " +
                "WHERE C.maCV=DSCV.maCV AND C.maNV=NV.maNV";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetCTCVCty()
        {
            DataSet data = new DataSet();
            string query = "" +
                "select NV.phongban,NV.chucvu,DSCV.maCV,DSCV.ten,NV.maNV,NV.hoten,C.trangthai,C.thoiGianHoanThanh,C.Tuychonchiase, C.ngaycapnhat " +
                "from CTCV C,DsCongViec DSCV,NhanVien NV " +
                "WHERE C.maCV=DSCV.maCV AND C.maNV=NV.maNV AND C.Tuychonchiase=N'Công việc chung'";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetCTCVPban(string mapb)
        {
            DataSet data = new DataSet();
            string query = "select NV.phongban,NV.chucvu,DSCV.maCV,DSCV.ten,NV.maNV,NV.hoten,C.trangthai,C.thoiGianHoanThanh,C.Tuychonchiase, C.ngaycapnhat " +
                "from CTCV C,DsCongViec DSCV,NhanVien NV " +
                "WHERE C.maCV=DSCV.maCV AND C.maNV=NV.maNV AND C.Tuychonchiase=N'Bộ phận' AND NV.phongban=@mapb";
            using (SqlConnection con = SqlConnectionData.connect())
            {
               
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@mapb", mapb);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

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
        public static DataSet GetDSUYCV()
        {
            DataSet data = new DataSet();
            string query = "select * from DsUyQuyenCV";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetDVCH()
        {
            DataSet data = new DataSet();
            string query = "select * from DVCanHo";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetThanhVienCanHo()
        {
            DataSet data = new DataSet();
            string query = "select * from ThanhVienCanHo";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetDangKyDoXe()
        {
            DataSet data = new DataSet();
            string query = "select * from DangKyDoXe";
            SqlConnection con = SqlConnectionData.connect();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(data);
            con.Close();
            return data;
        }
        public static DataSet GetChiphicanho()
        {
            DataSet data = new DataSet();
            string query = "select * from Chiphicanho";
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
                      

                        tk.id = reader["id"].ToString();
                        tk.mk = reader["mk"].ToString();
                        tk.loaiTK= Convert.ToInt32(reader["loaiTK"]);
                    }
                }
            }

            return (nhanVien, tk);
        }
        public static bool CapNhatThongTinNhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string didong, string email, string chucvu, string phongban, double luong, string trangthai, string trinhdohocvan, string loaihinh)
        {
            string query = "UPDATE NhanVien SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, didong = @didong, email = @email,";
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
        public static void insertCV(string maCV, string ten, string ngayYC) { 
        
            string sql = "INSERT INTO DsCongViec (maCV, ten, ngayYC) VALUES (@maCV, @ten, @ngayYC)";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                // Thêm các tham số với tên đúng
                command.Parameters.AddWithValue("@maCV", maCV);
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@ngayYC", ngayYC); // Truyền giá trị của biến ngayYC vào tham số @ngayYC

                con.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                   ex.ToString();
                }
            }
        }
 
        public static void updateCV(string maCV, string ten, string ngayYC)
        {
            string sql = "UPDATE DsCongViec SET ten = @ten, ngayYC = @ngayYC WHERE maCV = @maCV";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                // Thêm các tham số với tên đúng
                command.Parameters.AddWithValue("@maCV", maCV);
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@ngayYC", ngayYC); // Truyền giá trị của biến ngayYC vào tham số @ngayYC

                con.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    
                    ex.ToString();
                }
            }
        }
        public static void insertTK(string id)
        {
            string sql = "INSERT INTO TaiKhoan (id, mk, loaiTK) VALUES (@id, '123', 1)";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                // Thêm các tham số với tên đúng
                command.Parameters.AddWithValue("@id", id);

                con.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ tại đây nếu cần
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public static void insertDsUyQuyenCV(string maNV_cu, string maCV, string maNV_moi, string trangthai, DateTime thoiGianHoanThanh,string Tuychonchiase, DateTime ngayBanGiao )
        {
            string sql = "INSERT INTO DsUyQuyenCV VALUES (@maNV_cu,@maCV, @maNV_moi,@trangthai,@thoiGianHoanThanh,@Tuychonchiase,@ngayBanGiao)";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                // Thêm các tham số với tên đúng
                command.Parameters.AddWithValue("@maNV_cu", maNV_cu);
                command.Parameters.AddWithValue("@maCV", maCV);
                command.Parameters.AddWithValue("@maNV_moi", maNV_moi);
                command.Parameters.AddWithValue("@trangthai", trangthai);
                command.Parameters.AddWithValue("@thoiGianHoanThanh", thoiGianHoanThanh);
                command.Parameters.AddWithValue("@Tuychonchiase", Tuychonchiase);
                command.Parameters.AddWithValue("@ngayBanGiao", ngayBanGiao);

                con.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ tại đây nếu cần
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static void UpdateDVCanHo(string maCV, string DV_dinhky, string ngayYC)
        {
            // Xây dựng câu truy vấn SQL INSERT
            string sql = "UPDATE  DVCanHo SET  DV_dinhky= @DV_dinhky, ngayYC=@ngayYC WHERE maCV=@maCV";

            // Tạo kết nối
            using (SqlConnection con = SqlConnectionData.connect())
            {
                // Mở kết nối
                con.Open();
                    SqlCommand command = new SqlCommand(sql, con);
                    // Thêm các tham số vào câu truy vấn
                    command.Parameters.AddWithValue("@maCV", maCV);
                    command.Parameters.AddWithValue("@DV_dinhky", DV_dinhky);
                    command.Parameters.AddWithValue("@ngayYC", ngayYC);

                    // Thực thi câu truy vấn INSERT
                    command.ExecuteNonQuery();
                
            }
        }
        public static void DeleteDVCanHo(string maCV)
        {
            // Xây dựng câu truy vấn SQL DELETE
            string sql = "DELETE FROM DVCanHo WHERE maCV = @maCV";

            // Tạo kết nối
            using (SqlConnection con = SqlConnectionData.connect())
            {
                // Mở kết nối
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);

                // Thêm tham số vào câu truy vấn
                command.Parameters.AddWithValue("@maCV", maCV);

                // Thực thi câu truy vấn DELETE
                command.ExecuteNonQuery();

            }
        }
        public static void deleteCV(string maCV)
        {
            string sql = "DELETE FROM DsCongViec WHERE maCV = @maCV";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);

                // Thêm tham số với tên đúng
                command.Parameters.AddWithValue("@maCV", maCV);

                con.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi (nếu cần thiết)
                    ex.ToString();
                }
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
        public static void delCTCV(string maCV)
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

        public static DataSet GetDuLieuThongKeHieuQuaCVNVTongQuan(string maNV, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT " +
            "COUNT(CASE WHEN a.trangthai = N'Trễ hạn' THEN 1 ELSE NULL END) AS solantrehan, " +
            "COUNT(CASE WHEN a.trangthai = N'Chưa hoàn thành' THEN 1 ELSE NULL END) AS solanchuahoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Không hoàn thành' THEN 1 ELSE NULL END) AS solankhonghoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành đúng hạn' THEN 1 ELSE NULL END) AS solanhoanthanhdunghan, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành sớm' THEN 1 ELSE NULL END) AS solanhoanthanhsom " +
            "from " +
            "(SELECT CTCV.maCV, CTCV.maNV, CTCV.trangthai, CTCV.thoiGianHoanThanh " +
            "FROM CTCV " +
            "UNION " +
            "SELECT DsUyQuyenCV.maCV, DsUyQuyenCV.maNV_cu AS maNV, N'Không hoàn thành' AS trangthai, DsUyQuyenCV.thoiGianHoanThanh " +
            "FROM DsUyQuyenCV) as a, DsCongViec as b " +
            "WHERE a.maNV = @maNV AND a.maCV = b.maCV AND thoiGianHoanThanh >= @NgayBatDau AND thoiGianHoanThanh <= @NgayKetThuc " +
            "GROUP BY a.maNV; ";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static DataSet GetDuLieuThongKeHieuQuaCVNVChiTiet(string maNV, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT	a.maCV, b.ten, a.thoiGianHoanThanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Trễ hạn' THEN 1 ELSE NULL END) AS solantrehan, " +
            "COUNT(CASE WHEN a.trangthai = N'Chưa hoàn thành' THEN 1 ELSE NULL END) AS solanchuahoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Không hoàn thành' THEN 1 ELSE NULL END) AS solankhonghoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành đúng hạn' THEN 1 ELSE NULL END) AS solanhoanthanhdunghan, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành sớm' THEN 1 ELSE NULL END) AS solanhoanthanhsom " +
            "from " +
            "(SELECT CTCV.maCV, CTCV.maNV, CTCV.trangthai, CTCV.thoiGianHoanThanh " +
            "FROM CTCV " +
            "UNION " +
            "SELECT DsUyQuyenCV.maCV, DsUyQuyenCV.maNV_cu AS maNV, N'Không hoàn thành' AS trangthai, DsUyQuyenCV.thoiGianHoanThanh " +
            "FROM DsUyQuyenCV) as a, DsCongViec as b " +
            "WHERE a.maNV = @maNV AND a.maCV = b.maCV AND thoiGianHoanThanh >= @NgayBatDau AND thoiGianHoanThanh <= @NgayKetThuc " +
            "GROUP BY a.maCV, b.ten, a.thoiGianHoanThanh; ";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static DataSet GetDuLieuThongKeHieuQuaCVPBTongQuan(string maPB, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT SUM(b.luong) as doanhthu, " +
            "COUNT(CASE WHEN a.trangthai = N'Trễ hạn' THEN 1 ELSE NULL END) AS solantrehan, " +
            "COUNT(CASE WHEN a.trangthai = N'Chưa hoàn thành' THEN 1 ELSE NULL END) AS solanchuahoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Không hoàn thành' THEN 1 ELSE NULL END) AS solankhonghoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành đúng hạn' THEN 1 ELSE NULL END) AS solanhoanthanhdunghan, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành sớm' THEN 1 ELSE NULL END) AS solanhoanthanhsom " +
            "from " +
            "(SELECT CTCV.maCV, CTCV.maNV, CTCV.trangthai, CTCV.thoiGianHoanThanh " +
            "FROM CTCV " +
            "UNION " +
            "SELECT DsUyQuyenCV.maCV, DsUyQuyenCV.maNV_cu AS maNV, N'Không hoàn thành' AS trangthai, DsUyQuyenCV.thoiGianHoanThanh " +
            "FROM DsUyQuyenCV) as a, NhanVien as b " +
            "WHERE phongban = @maPB AND a.maNV = b.maNV AND thoiGianHoanThanh >= @NgayBatDau AND thoiGianHoanThanh <= @NgayKetThuc " +
            "GROUP BY phongban; ";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maPB", maPB);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static DataSet GetDuLieuThongKeHieuQuaCVPBChiTiet(string maPB, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT a.maNV, hoten, " +
            "SUM(b.luong) as luong, " +
            "COUNT(CASE WHEN a.trangthai = N'Trễ hạn' THEN 1 ELSE NULL END) AS solantrehan, " +
            "COUNT(CASE WHEN a.trangthai = N'Chưa hoàn thành' THEN 1 ELSE NULL END) AS solanchuahoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Không hoàn thành' THEN 1 ELSE NULL END) AS solankhonghoanthanh, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành đúng hạn' THEN 1 ELSE NULL END) AS solanhoanthanhdunghan, " +
            "COUNT(CASE WHEN a.trangthai = N'Hoàn thành sớm' THEN 1 ELSE NULL END) AS solanhoanthanhsom " +
            "from " +
            "(SELECT CTCV.maCV, CTCV.maNV, CTCV.trangthai, CTCV.thoiGianHoanThanh " +
            "FROM CTCV " +
            "UNION " +
            "SELECT DsUyQuyenCV.maCV, DsUyQuyenCV.maNV_cu AS maNV, N'Không hoàn thành' AS trangthai, DsUyQuyenCV.thoiGianHoanThanh " +
            "FROM DsUyQuyenCV) as a, NhanVien as b " +
            "WHERE phongban = @maPB AND a.maNV = b.maNV AND thoiGianHoanThanh >= @NgayBatDau AND thoiGianHoanThanh <= @NgayKetThuc " +
            "GROUP BY a.maNV, hoten; ";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maPB", maPB);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static DataSet GetDuLieuBaoCaoCanHo(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT Chiphicanho.maCH, tenCH, tinhTrangNguoiO, tinhTrangBanGiao, tinhTrangNoiThat, CongNo, TongChiPhiDienNuoc, TongphiQuanLy, TongPhiDichVu, quoctich " +
                "FROM Chiphicanho, TinhTrangCanHo, CuDan WHERE  CuDan.maCD = Chiphicanho.maCD AND TinhTrangCanHo.maCH = Chiphicanho.maCH AND ngaybatdau >= @NgayBatDau AND ngayketthuc <= @Ngayketthuc;";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static DataSet GetDuLieuBaoCaoYeuCau(DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT DVCanHo.maCH, CuDan.tenCH, DV_dinhky, DsCongViec.ngayYC, ten, CTCV.trangthai, hoten " +
                "FROM DVCanHo, DsCongViec, CanHo, CTCV, NhanVien, CuDan " +
                "WHERE  DVCanHo.maCV = DsCongViec.maCV AND DVCanHo.maCH = CanHo.maCH AND CanHo.maCD = CuDan.maCD AND DVCanHo.maCV = CTCV.maCV AND CTCV.maNV = NhanVien.manv AND DsCongViec.ngayYC >= @NgayBatDau AND DsCongViec.ngayYC <= @Ngayketthuc;";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static DataSet GetDuLieuBaoCaoTimKiemYC(string maCH, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT DVCanHo.maCH, CuDan.tenCH, DV_dinhky, DsCongViec.ngayYC, ten, CTCV.trangthai, hoten " +
            "FROM DVCanHo, DsCongViec, CanHo, CTCV, NhanVien, CuDan " +
            "WHERE  DVCanHo.maCV = DsCongViec.maCV AND DVCanHo.maCH = CanHo.maCH AND CanHo.maCD = CuDan.maCD AND DVCanHo.maCV = CTCV.maCV AND CTCV.maNV = NhanVien.manv AND DsCongViec.ngayYC >= @NgayBatDau AND DsCongViec.ngayYC <= @Ngayketthuc AND DVCanHo.maCH = @maCH;";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maCH", maCH);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
        public static DataSet GetDuLieuBaoCaoTimKiemCH(string maCH, DateTime NgayBatDau, DateTime NgayKetThuc)
        {
            DataSet data = new DataSet();
            string query = "SELECT Chiphicanho.maCH, tenCH, tinhTrangNguoiO, tinhTrangBanGiao, tinhTrangNoiThat, CongNo, TongChiPhiDienNuoc, TongphiQuanLy, TongPhiDichVu, quoctich " +
                "FROM Chiphicanho, TinhTrangCanHo, CuDan WHERE  CuDan.maCD = Chiphicanho.maCD AND TinhTrangCanHo.maCH = Chiphicanho.maCH AND ngaybatdau >= @NgayBatDau AND ngayketthuc <= @Ngayketthuc AND Chiphicanho.maCH = @maCH;";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maCH", maCH);
                command.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }

        public static string getMK(string email)
        {
            string mk = "";
            string sql = "SELECT tk.mk FROM TaiKhoan tk,NhanVien nv WHERE nv.email = @email and tk.id=nv.manv";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@email", email);
                try
                {
                    con.Open();
                    
                    object result = command.ExecuteScalar();
                    if (result != null) 
                    {
                        mk = result.ToString(); 
                    }
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return mk;
        }
        public static DataSet GetDuLieuThongKeKetQuaCVHoanThanh(string maNV, string trangthai)
        {
            DataSet data = new DataSet();
            string query;
            if (trangthai == "Tất cả" || trangthai == "All")
            {
                query = "SELECT CTCV.maNV, hoten, ten, (DATEDIFF(day, ngayYC, ngaycapnhat) + 1) AS thoigianlam " +
                "FROM NhanVien, CTCV, DsCongViec " +
                "WHERE CTCV.maNV = NhanVien.maNV AND DsCongViec.maCV = CTCV.maCV AND CTCV.maNV = @maNV;";
            }
            else
            {
                query = "SELECT CTCV.maNV, hoten, ten, (DATEDIFF(day, ngayYC, ngaycapnhat) + 1) AS thoigianlam " +
                "FROM NhanVien, CTCV, DsCongViec " +
                "WHERE CTCV.maNV = NhanVien.maNV AND DsCongViec.maCV = CTCV.maCV AND CTCV.maNV = @maNV AND CTCV.trangthai = @trangthai;";
            }
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                command.Parameters.AddWithValue("@trangthai", trangthai);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }

        public static DataSet GetDuLieuThongKeKetQuaCVKhongHoanThanh(string maNV)
        {
            DataSet data = new DataSet();
            string query = "SELECT maNV_cu, hoten, ten, (DATEDIFF(day, ngayYC, ngayBanGiao) + 1) AS thoigianlam, maNV_moi " +
                "FROM NhanVien, DsUyQuyenCV, DsCongViec " +
                "WHERE maNV_cu = NhanVien.maNV AND DsCongViec.maCV = DsUyQuyenCV.maCV AND maNV_cu = @maNV;";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }

        public static string getloaihinh(string id)
        {
            string loaihinh = "";
            string sql = "SELECT loaihinh FROM NhanVien WHERE id=@id";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        loaihinh = result.ToString();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return loaihinh;
        }
        public static string getEmail(string maNV)
        {
            string email = "";
            string sql = "SELECT email FROM NhanVien  WHERE maNV = @maNV ";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                try
                {
                    con.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        email = result.ToString();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return email;
        }
        public static List<string> getEmailsByRole(int loaiTK)
        {
            List<string> emails = new List<string>();
            string sql = "SELECT email FROM NhanVien NV,TaiKhoan TK  WHERE loaiTK=@loaiTK AND TK.id=NV.maNV";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@loaiTK", loaiTK);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string email = reader["email"].ToString();
                        emails.Add(email);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return emails;
        }

        public static DataSet getThongtinkh(string macv)
        {

            DataSet data = new DataSet();
            string query = "select DISTINCT CD.* from DVCanHo DVCH,DsCongViec DSCV,CanHo CH,CuDan CD where DVCH.maCV=DSCV.maCV and DVCH.maCH=CH.maCH and CH.maCD=CD.maCD and DSCV.maCV=@maCV";

            using (SqlConnection con = SqlConnectionData.connect())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@maCV", macv);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                catch
                {
                    Console.WriteLine("Lỗi!");
                }
            }

            return data;
        }
        public static int getSLCVSapHetHan(string maNV)
        {
            int soluong = 0;
            string sql = "SELECT count(*) FROM CTCV  WHERE trangthai=N'Chưa hoàn thành' and songayhethan<=2 and maNV=@maNV";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return soluong;
        }
        public static int getSLCVNV(string maNV)
        {
            int soluong = 0;
            string sql = "SELECT count(*) FROM CTCV  WHERE trangthai=N'Chưa hoàn thành' and maNV=@maNV";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@maNV", maNV);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return soluong;
        }
        public static int getSLCV()
        {
            int soluong = 0;
            string sql = "SELECT count(*) FROM CTCV WHERE trangthai=N'Chưa hoàn thành'";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }

                return soluong;
            }

        }

        public static bool UploadPdfToDatabase(string filePath)
        {
            try
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                string fileName = System.IO.Path.GetFileName(filePath);

                using (SqlConnection con = SqlConnectionData.connect())
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO DsTaiLieu (FileName, PdfData) VALUES (@FileName, @PdfData)", con);
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@PdfData", fileBytes);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tải lên PDF từ cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public static bool DownloadPdfFromDatabase(int fileId, string savePath)
        {
            try
            {
                using (SqlConnection con = SqlConnectionData.connect())
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT FileName, PdfData FROM DsTaiLieu WHERE Id = @Id", con);
                    command.Parameters.AddWithValue("@Id", fileId);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string fileName = reader["FileName"].ToString();
                        byte[] fileBytes = (byte[])reader["PdfData"];

                        if (fileBytes != null && fileBytes.Length > 0)
                        {
                            System.IO.File.WriteAllBytes(savePath, fileBytes);
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Dữ liệu PDF trống hoặc không hợp lệ.");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy tệp PDF trong cơ sở dữ liệu.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tải xuống PDF từ cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        public static DataTable LoadPdfDataToDataGridView()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection con = SqlConnectionData.connect())
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT Id, FileName FROM DsTaiLieu", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading PDF data to DataGridView: " + ex.Message);
            }

            return dataTable;
        }

        public static int getTongCV()
        {
            int soluong = 0;
            string sql = "SELECT count(*) FROM DsCongViec";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }

                return soluong;
            }
        }

        public static int getTongNV()
        {
            int soluong = 0;
            string sql = "SELECT count(*) FROM NhanVien";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }

                return soluong;
            }
        }

        public static int getSoCVKhongHoanThanh()
        {
            int soluong = 0;
            string sql = "SELECT count(*) FROM DsUyQuyenCV";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }

                return soluong;
            }
        }
        public static int getSoCVHoanThanh()
        {
            int soluong = 0;
            string sql = "SELECT count(*) from CTCV where trangthai != N'Chưa hoàn thành'";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }

                return soluong;
            }
        }
        public static int getDoanhThu()
        {
            int soluong = 0;
            int soluong1 = 0;
            int soluong2 = 0;
            string sql = "select sum(TongphiQuanLy) from Chiphicanho";
            string sql1 = "select sum(TongChiPhiDienNuoc) from Chiphicanho";
            string sql2 = "select sum(TongPhiDichVu) from Chiphicanho";
            using (SqlConnection con = SqlConnectionData.connect())
            {
                SqlCommand command = new SqlCommand(sql, con);
                SqlCommand command1 = new SqlCommand(sql1, con);
                SqlCommand command2 = new SqlCommand(sql2, con);
                try
                {
                    con.Open();

                    // Sử dụng ExecuteScalar để lấy giá trị trả về của câu truy vấn
                    object result = command.ExecuteScalar();
                    object result1 = command1.ExecuteScalar();
                    object result2= command2.ExecuteScalar();
                    if (result != null && result1 != null && result2 != null)
                    {
                        // Convert kết quả sang kiểu int
                        soluong = Convert.ToInt32(result);
                        soluong1 = Convert.ToInt32(result1);
                        soluong2 = Convert.ToInt32(result2);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }

                return soluong + soluong1 + soluong2;
            }
        }
        
    }
}
