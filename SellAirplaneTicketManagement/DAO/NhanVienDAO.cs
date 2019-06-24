using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    public class NhanVienDAO
    {
        public DataTable LoadList()
        {
        string sql = "Select * from NhanVien Where TinhTrang!=N'Đã xóa'";
        var rs = ProcessData.LoadData(sql);
        return rs;
        }

        public int Insert(NhanVien NhanVien)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MAX(MaNhanVien) From NhanVien");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();


            int id = int.Parse(tmp.Remove(0, 2));
            id++;
            tmp = "NV";
            if (id < 10) tmp += "00";
            else if (id < 100) tmp += "0";
            tmp += id;

            sql = string.Format("Insert into NhanVien(MaNhanVien,HoTen, MatKhau, TinhTrang, MaNguoiQuanLy, NgaySinh, GioiTinh, ChucVu, DiaChi, SoDienThoai)  Values('{0}',N'{1}','{2}',N'{3}','{4}','{5}',N'{6}',N'{7}',N'{8}','{9}')",
              tmp, NhanVien.HoTen, NhanVien.MatKhau, NhanVien.TinhTrang, NhanVien.MaNguoiQuanLy, NhanVien.NgaySinh, NhanVien.GioiTinh, NhanVien.ChucVu, NhanVien.DiaChi, NhanVien.SoDienThoai);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Update NhanVien Set TinhTrang=N'Đã xóa' Where MaNhanVien='{0}'",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(NhanVien NhanVien)
        {
            string sql = string.Format("Update NhanVien Set  HoTen'{1}', MatKhau='{2}', TinhTrang'{3}', MaNguoiQuanLy='{4}', NgaySinh='{5}', GioiTinh'{6}', ChucVu='{7}', DiaChi='{8}', SoDienThoai='{9}'  Where MaNhanVien='{0}'",
                NhanVien.MaNhanVien, NhanVien.HoTen, NhanVien.MatKhau, NhanVien.TinhTrang, NhanVien.MaNguoiQuanLy, NhanVien.NgaySinh, NhanVien.GioiTinh, NhanVien.ChucVu, NhanVien.DiaChi, NhanVien.SoDienThoai);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int FindUser(string userid)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaNhanVien, ChucVu From NhanVien Where MaNhanVien='{0}'", userid);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            try {
                var rs = command.ExecuteReader();
                
                if (!rs.HasRows) return 0;
                else
                {
                    rs.Read();
                    if (rs.GetString(1) == "Nhân viên bán vé") return 1; // nhân viên
                    else return 2; // admin

                }
            }
            finally {
                conn.Close();
            }
        }

        public bool VerifyPass(string userid, string pass)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaNhanVien, MatKhau From NhanVien Where MaNhanVien='{0}'", userid);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                var rs = command.ExecuteReader();
                if(rs.Read())
                    if (pass==rs.GetString(1)) return true;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool VerifyEmail(string userid, string email)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaNhanVien, Email From NhanVien Where MaNhanVien='{0}'", userid);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                var rs = command.ExecuteReader();
                if (rs.Read())
                    if (email == rs.GetString(1)) return true;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> ManagerList()
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaNhanVien From NhanVien Where TinhTrang!=N'Đã xóa' and ChucVu!=N'Nhân viên bán vé'");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            List<string> list = new List<string>();

            while (rd.Read())
            {
                list.Add(rd.GetString(0));
            }

            conn.Close();
            return list;
        }

        public string ManagerName(string id)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select HoTen From NhanVien Where MaNhanVien='{0}'", id);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();
            string name="";
            if (rd.Read())
                name = rd.GetString(0);

            conn.Close();
            return name;
        }

        public List<string> EmployeeList()
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaNhanVien From NhanVien Where TinhTrang!=N'Đã xóa'");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            List<string> list = new List<string>();

            while (rd.Read())
            {
                list.Add(rd.GetString(0));
            }

            conn.Close();
            return list;
        }

        public NhanVien GetInfo(string id)
        {
            NhanVien nhanvien = new NhanVien();

            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select * From NhanVien Where MaNhanVien='{0}'", id);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();
            if (rd.Read())
            {
                nhanvien.MaNhanVien = id;
                nhanvien.HoTen = rd.GetString(1);
                nhanvien.MatKhau = rd.GetString(2);
                nhanvien.TinhTrang = rd.GetString(3);
                if (rd.IsDBNull(4)) nhanvien.MaNguoiQuanLy = "";
                else
                    nhanvien.MaNguoiQuanLy = rd.GetString(4);
                nhanvien.NgaySinh = rd.GetDateTime(5).ToShortDateString();
                nhanvien.GioiTinh = rd.GetString(6);
                nhanvien.ChucVu = rd.GetString(7);
                nhanvien.DiaChi = rd.GetString(8);
                nhanvien.SoDienThoai = rd.GetString(9);
            }
            conn.Close();

            return nhanvien;
        }

        public string GetNewID()
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MAX(MaNhanVien) From NhanVien");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();


            int id = int.Parse(tmp.Remove(0, 2));
            id++;
            tmp = "NV";
            if (id < 10) tmp += "00";
            else if (id < 100) tmp += "0";
            tmp += id;

            return tmp;
        }
    }
}
