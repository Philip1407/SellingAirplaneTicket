using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    public class LichBayDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from LichBay";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(LichBay LichBay)
        {
            string sql = string.Format("Insert into LichBay(MaLichBay, MaChuyenBay, Ngay, GioKhoiHanh, GioKetThuc, TinhTrang)  Values('{0}','{1}','{2}','{3}','{4}','{5}')",
              LichBay.MaLichBay, LichBay.MaChuyenBay, LichBay.Ngay, LichBay.GioKhoiHanh, LichBay.GioKetThuc, LichBay.TinhTrang);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from LichBay Where MaLichBay='{0}'",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(LichBay LichBay)
        {
            string sql = string.Format("Update LichBay Set MaChuyenBay='{1}, Ngay='{2}', GioKhoiHanh='{3}', LichBay.GioKetThuc='{4}', TinhTrang='{5}'  Where MaLichBay='{0}'",
                LichBay.MaLichBay, LichBay.MaChuyenBay, LichBay.Ngay, LichBay.GioKhoiHanh, LichBay.GioKetThuc, LichBay.TinhTrang);
            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }
}
