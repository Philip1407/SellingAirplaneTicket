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
    public class KhachHangDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from KhachHang";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(KhachHang KhachHang)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MAX(MaKhachHang) From KhachHang");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();


            int id = int.Parse(tmp.Remove(0, 2));
            id++;
            tmp = "KH";
            if (id < 10) tmp += "00";
            else if (id < 100) tmp += "0";
            tmp += id;

            sql = string.Format("Insert into KhachHang(MaKhachHang, TenKhachHang, SoDienThoai,  CMND)  Values('{0}',N'{1}','{2}','{3}')",
              tmp, KhachHang.TenKhachHang, KhachHang.SoDienThoai,  KhachHang.CMND);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChuyenBay Where MaKhachHang='{0}'",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(KhachHang KhachHang)
        {
            string sql = string.Format("Update KhachHang Set TenKhachHang='{1}', SoDienThoai='{2}', CMND='{3}'  Where MaKhachHang='{0}'",
              KhachHang.MaKhachHang, KhachHang.TenKhachHang, KhachHang.SoDienThoai,  KhachHang.CMND);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public string GetName(string id)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select TenKhachHang from KhachHang Where MaKhachHang='{0}'", id);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string dt ="";

            if (!rd.HasRows) return "";

            if (rd.Read())
            {
                dt = rd.GetString(0);
            }

            conn.Close();
            return dt;
        }

        public string GetNameByIdNum(string id)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select TenKhachHang from KhachHang Where CMND='{0}'", id);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();
            
            if (!rd.HasRows) return "";

            string dt = "";
            if (rd.Read())
            {
                dt = rd.GetString(0);
            }

            conn.Close();
            return dt;
        }

        public List<string> GetIDNumberList()
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select CMND From KhachHang");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            List<string> list = new List<string>();
            list.Add("0");
            while (rd.Read())
            {
                list.Add(rd.GetString(0));
            }

            conn.Close();
            return list;
        }

        public string GetIDbyIDNum(string id)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaKhachHang from KhachHang Where CMND='{0}'", id);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            if (!rd.HasRows) return "";

            string dt = "";
            if (rd.Read())
            {
                dt = rd.GetString(0);
            }

            conn.Close();
            return dt;
        }
    }
}
