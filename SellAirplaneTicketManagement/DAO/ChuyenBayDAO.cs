using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellAirplaneTicketManagement.DTO;
using System.Data;
using System.Data.SqlClient;

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
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MAX(MaChuyenBay) From ChuyenBay");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp="";

            if (rd.Read()) tmp = rd.GetString(0);
            
            conn.Close();

            
            int id = int.Parse(tmp.Remove(0,2));
            id++;
            tmp = "CB";
            if (id < 10) tmp += "00";
            else if (id < 100) tmp += "0";
            tmp += id;

            sql = string.Format("Insert into ChuyenBay(MaChuyenBay, HangHangKhong, DiemKhoiHanh, DiemDen, SoLuongKhach)  Values('{0}','{1}',N'{2}',N'{3}','{4}')",
               tmp, ChuyenBay.HangHangKhong, ChuyenBay.DiemKhoiHanh,ChuyenBay.DiemDen, ChuyenBay.SoLuongKhach);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChuyenBay Where MaChuyenBay='{0}'",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(ChuyenBay ChuyenBay)
        {
            string sql = string.Format("Update ChuyenBay Set HangHangKhong=N'{1}', DiemKhoiHanh=N'{2}', DiemDen=N'{3}', SoLuongKhach={4} Where MaChuyenBay='{0}'",
              ChuyenBay.MaChuyenBay, ChuyenBay.HangHangKhong, ChuyenBay.DiemKhoiHanh, ChuyenBay.DiemDen, ChuyenBay.SoLuongKhach);

            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }
    }
}
