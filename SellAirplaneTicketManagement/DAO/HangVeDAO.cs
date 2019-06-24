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

       

        public int GetCost(string idclass, string idflight)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select GiaVe From HangVe Where MaHangVe like '{0}%' and MaChuyenBay like '{1}%'",
                idclass, new LichBayDAO().GetFlightID(idflight.Trim()).Trim());

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            int tmp=0;

            if (rd.Read()) tmp = rd.GetInt32(0);

            conn.Close();
            return tmp;
        }

        public List<string> GetClassList(string id)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";


            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaHangVe From HangVe Where MaChuyenBay like '{0}%'", new LichBayDAO().GetFlightID(id).Trim());

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            List<string> list = new List<string>();

            while (rd.Read())
            {
                list.Add(rd.GetString(0).Trim());
            }

            conn.Close();
            return list;
        }
    }
}
