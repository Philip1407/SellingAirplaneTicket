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
    public class VeDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from Ve";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(Ve Ve, int amount, string idTran)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MAX(MaVe) From Ve");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();


            int id = int.Parse(tmp.Remove(0, 1));

            int rs=0;
            int temp= id;
            for(id++; id<=temp+amount+1; id++)
            {
                tmp = "V";
                if (id < 10) tmp += "00";
                else if (id < 100) tmp += "0";
                tmp += id;

                sql = string.Format("Insert into Ve(MaVe, MaLichBay, MahangVe)  Values('{0}','{1}','{2}')",
                tmp, Ve.MaLichBay, Ve.MaHangVe);
                rs += ProcessData.ExecuteNonQuery(sql);
                sql = string.Format("Insert into ChiTietGiaoDich(MaGiaoDich, MaVe) values('{0}','{1}')",
                idTran, tmp);
                rs += ProcessData.ExecuteNonQuery(sql);
            }

            
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from LichLamViec Where MaVe='{0}'",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(Ve Ve)
        {
            string sql = string.Format("Update LichBay Set  MaLichBay='{1}', MaHangVe='{2}'  Where MaNhanVien='{0}'",
               Ve.MaVe, Ve.MaLichBay, Ve.MaHangVe);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }
    }
}
