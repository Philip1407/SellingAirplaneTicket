using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from LichLamViec Where MaNhanVien='{0}'",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(NhanVien NhanVien)
        {
            string sql = string.Format("Update LichBay Set   HoTen'{1}', MatKhau='{2}', TinhTrang'{3}', MaNguoiQuanLy='{4}', NgaySinh='{5}', GioiTinh'{6}', ChucVu='{7}', DiaChi='{8}', SoDienThoai='{9}'  Where MaNhanVien='{0}'",
                NhanVien.MaNhanVien, NhanVien.HoTen, NhanVien.MatKhau, NhanVien.TinhTrang, NhanVien.MaNguoiQuanLy, NhanVien.NgaySinh, NhanVien.GioiTinh, NhanVien.ChucVu, NhanVien.DiaChi, NhanVien.SoDienThoai);
            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }
}
