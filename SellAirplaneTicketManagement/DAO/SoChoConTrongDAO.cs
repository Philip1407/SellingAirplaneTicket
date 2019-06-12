using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    class SoChoConTrongDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from SoChoConTrong";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(SoChoConTrong SoChoConTrong)
        {
            string sql = string.Format("Insert into LichLamViec(MaLichBay, MaHangVe, SoChoConTrong)  Values('{0}','{1}','{2}')",
              SoChoConTrong.MaLichBay, SoChoConTrong.MaHangVe, SoChoConTrong.SoChoTrong);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from LichLamViec Where MaLichBay='{0}'",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(SoChoConTrong SoChoConTrong)
        {
            string sql = string.Format("Update SoChoConTrong Set  MaHangVe='{1}', SoChoConTrong='{2}'  Where MaLichBay='{0}'",
                SoChoConTrong.MaLichBay, SoChoConTrong.MaHangVe, SoChoConTrong.SoChoTrong);
            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }
}
