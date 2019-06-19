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
        string sql = "Select * from NhanVien";
        var rs = ProcessData.LoadData(sql);
        return rs;
        }

        public int Insert(NhanVien NhanVien)
        {
            string sql = string.Format("Insert into NhanVien(MaNhanVien,HoTen, MatKhau, TinhTrang, MaNguoiQuanLy, NgaySinh, GioiTinh, ChucVu, DiaChi, SoDienThoai)  Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
              NhanVien.MaNhanVien, NhanVien.HoTen, NhanVien.MatKhau, NhanVien.TinhTrang, NhanVien.MaNguoiQuanLy, NhanVien.NgaySinh, NhanVien.GioiTinh, NhanVien.ChucVu, NhanVien.DiaChi, NhanVien.SoDienThoai);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from NhanVien Where MaNhanVien='{0}'",
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
    }
}
