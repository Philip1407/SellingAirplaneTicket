using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MAX(MaLichBay) From LichBay");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();


            int id = int.Parse(tmp.Remove(0, 2));
            id++;
            tmp = "LB";
            if (id < 10) tmp += "00";
            else if (id < 100) tmp += "0";
            tmp += id;
            sql = string.Format("Insert into LichBay(MaLichBay, MaChuyenBay, Ngay, GioKhoiHanh, GioKetThuc, TinhTrang)  Values('{0}','{1}','{2}','{3}','{4}',N'{5}')",
              tmp, LichBay.MaChuyenBay, LichBay.Ngay, LichBay.GioKhoiHanh, LichBay.GioKetThuc, LichBay.TinhTrang);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from LichBay Where MaLichBay='{0}'",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(LichBay LichBay)
        {
            string sql = string.Format("Update LichBay Set MaChuyenBay='{1}, Ngay='{2}', GioKhoiHanh='{3}', GioKetThuc='{4}', TinhTrang=N'{5}'  Where MaLichBay='{0}'",
                LichBay.MaLichBay, LichBay.MaChuyenBay, LichBay.Ngay, LichBay.GioKhoiHanh, LichBay.GioKetThuc, LichBay.TinhTrang);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }
    }
}
