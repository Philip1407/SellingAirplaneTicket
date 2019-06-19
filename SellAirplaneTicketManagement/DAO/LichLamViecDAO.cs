using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    public class LichLamViecDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select LichLamViec.MaNhanVien, NhanVien.HoTen, LichLamViec.Ngay, LichLamViec.Ca from LichLamViec, NhanVien where LichLamViec.MaNhanVien = NhanVien.MaNhanVien";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(LichLamViec LichLamViec)
        {
            string sql = string.Format("Insert into LichLamViec(MaNhanVien, Ngay, Ca)  Values('{0}','{1}','{2}')",
              LichLamViec.MaNhanVien,  LichLamViec.Ngay,LichLamViec.Ca);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from LichLamViec Where MaNhanVien='{0}'",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(LichLamViec LichLamViec)
        {
            string sql = string.Format("Update LichLamViec Set  Ngay='{1}', Ca='{2}'  Where MaNhanVien='{0}'",
                LichLamViec.MaNhanVien, LichLamViec.Ngay, LichLamViec.Ca);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }
    }
}
