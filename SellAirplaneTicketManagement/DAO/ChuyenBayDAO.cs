using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellAirplaneTicketManagement.DTO;
using System.Data;

namespace SellAirplaneTicketManagement.DAO
{/*
    public class ChuyenBayDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from ChuyenBay";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(ChuyenBay ChuyenBay)
        {
            string sql = string.Format("Insert into ChuyenBay(MaLichBay, MaChuyenBay, Ngay, GioKhoiHanh, GioKetThuc, TinhTrang)  Values('{0}','{1}',{2},{3},{4},{5})",
              ChuyenBay.MaLichBay, ChuyenBay.MaChuyenBay, ChuyenBay.HangHangKhong, ChuyenBay.DiemKhoiHanh,ChuyenBay.DiemDen, ChuyenBay.SoLuongKhach);
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

        public int Update(ChuyenBay ChuyenBay)
        {
            string sql = string.Format("Update ChiTietGiaoDich Set MaLichBay='{0}', MaChuyenBay='{1}', Ngay='{2}', GioKhoiHanh='{3}', GioKetThuc='{4}', TinhTrang='{5}' Where Id={6}",
               ChuyenBay.MaLichBay, ChuyenBay.MaChuyenBay, ChuyenBay.HangHangKhong, ChuyenBay.DiemKhoiHanh, ChuyenBay.DiemDen, ChuyenBay.SoLuongKhach,id);

            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }*/
}
