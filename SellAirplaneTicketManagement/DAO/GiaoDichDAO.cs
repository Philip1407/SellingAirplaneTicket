using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    /*class GiaoDichDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from GiaoDich";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(GiaoDich GiaoDich)
        {
            string sql = string.Format("Insert into GiaoDich(MaGiaoDich, SoTienGiaoDich, ThoiGianGIaoDich,MaKhachHang,MaNhanVien,SoTaiKhoanChuyenDen,MaLichBay)  Values('{0}','{1}',{2},{3},{4},{5})",
              GiaoDich.MaGiaoDich, GiaoDich.SoTienGiaoDich, GiaoDich.ThoiGianGIaoDich, GiaoDich.MaKhachHang, GiaoDich.MaNhanVien, GiaoDich.SoTaiKhoanChuyenDen, GiaoDich.MaLichBay);
            var rs = ProcessData.Execute(sql);
            return rs;
            
        }

        public int Delete(int id)
        {
            string sql = string.Format("Delete from ChuyenBay Where Id={0}",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(GiaoDich GiaoDich)
        {
            string sql = string.Format("Update ChiTietGiaoDich Set MaLichBay='{0}', MaChuyenBay='{1}', Ngay='{2}', GioKhoiHanh='{3}', GioKetThuc='{4}', TinhTrang='{5}' Where Id={6}",
               ChuyenBay.MaLichBay, ChuyenBay.MaChuyenBay, ChuyenBay.HangHangKhong, ChuyenBay.DiemKhoiHanh, ChuyenBay.DiemDen, ChuyenBay.SoLuongKhach, id);

            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }*/
}
