using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    public class VeDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from Ve";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(Ve Ve)
        {
            string sql = string.Format("Insert into LichLamViec(maVe, MaLichBay, MahangVe)  Values('{0}','{1}','{2}')",
            Ve.MaVe, Ve.MaLichBay, Ve.MaHangVe);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from LichLamViec Where MaVe='{0}'",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(Ve Ve)
        {
            string sql = string.Format("Update LichBay Set  MaLichBay='{1}', MaHangVe='{2}'  Where MaNhanVien='{0}'",
               Ve.MaVe, Ve.MaLichBay, Ve.MaHangVe);
            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }
}
