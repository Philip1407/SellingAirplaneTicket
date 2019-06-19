using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    public class HangVeDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from HangVe";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(HangVe HangVe)
        {
            string sql = string.Format("Insert into HangVe(MaHangVe, MaChuyenBay, GiaVe, SoCho)  Values('{0}','{1}',{2},{3})",
              HangVe.MaHangVe, HangVe.MaChuyenBay, HangVe.GiaVe, HangVe.SoCho);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChuyenBay Where MaHangVe={0}",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(HangVe HangVe)
        {
            string sql = string.Format("Update GiaoDich Set MaHangVe='{1}', MaChuyenBay='{2}', GiaVe='{3}', SoCho='{4}'  Where MaGiaoDich={0}",
              HangVe.MaHangVe, HangVe.MaChuyenBay, HangVe.GiaVe, HangVe.SoCho);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }
    }
}
