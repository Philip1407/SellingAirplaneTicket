using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    
    public class ChiTietGiaoDichDAO
    { 
        public DataTable LoadList()
        {
            string sql = "Select * from ChiTietGiaoDich";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(ChiTietGiaoDich ChiTiet)
        {
            string sql = string.Format("Insert into ChiTietGiaoDich(MaGiaoDich, MaVe)  Values('{0}','{1}')",
              ChiTiet.MaGiaoDich, ChiTiet.MaVe);

            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChiTietGiaoDich Where Id={0}",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }
    }
}
