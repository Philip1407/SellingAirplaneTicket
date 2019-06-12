using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellAirplaneTicketManagement.DTO;
using System.Data;

namespace SellAirplaneTicketManagement.DAO
{
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
            string sql = string.Format("Insert into ChuyenBay(MaChuyenBay, HangHangKhong, DiemKhoiHanh, DiemDen, SoLuongKhach)  Values('{0}','{1}','{2}','{3}','{4}')",
               ChuyenBay.MaChuyenBay, ChuyenBay.HangHangKhong, ChuyenBay.DiemKhoiHanh,ChuyenBay.DiemDen, ChuyenBay.SoLuongKhach);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChuyenBay Where MaChuyenBay={0}",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(ChuyenBay ChuyenBay)
        {
            string sql = string.Format("Update ChiTietGiaoDich Set HangHangKhong='{1}', DiemKhoiHanh='{3}', DiemDen='{4}', SoLuongKhach='{5}' Where MaChuyenBay={0}",
              ChuyenBay.MaChuyenBay, ChuyenBay.HangHangKhong, ChuyenBay.DiemKhoiHanh, ChuyenBay.DiemDen, ChuyenBay.SoLuongKhach);

            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }
}
