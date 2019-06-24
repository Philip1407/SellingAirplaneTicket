﻿using SellAirplaneTicketManagement.DTO;
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
            string sql = string.Format("Update LichBay Set MaChuyenBay='{1}', Ngay='{2}', GioKhoiHanh='{3}', GioKetThuc='{4}', TinhTrang=N'{5}'  Where MaLichBay='{0}'",
                LichBay.MaLichBay, LichBay.MaChuyenBay, LichBay.Ngay, LichBay.GioKhoiHanh, LichBay.GioKetThuc, LichBay.TinhTrang);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public DataTable DetailLoad(string id)
        {
            string sql = string.Format("Select HangVe.*, SoChoTrong.SoChoConTrong From LichBay, HangVe, SoChoTrong Where LichBay.MaLichBay='{0}' and LichBay.MaChuyenBay = HangVe.MaChuyenBay and SoChoTrong.MaHangVe=HangVe.MaHangVe and SoChoTrong.MaLichBay=LichBay.MaLichBay",
                id);
            var rs = ProcessData.LoadData(sql);
            return rs;

        }

        public void UpdateAll(DataTable dt)
        {
            ProcessData.UpdateAll(dt);
        }

        public DataTable Search(string diemkhoihanh, string diemden, string date)
        {
            string sql = string.Format("Select lb.machuyenbay,hanghangkhong,giokhoihanh,gioketthuc,mahangve,sochocontrong,tinhtrang from LichBay lb,ChuyenBay cb, SoChoTrong sct where lb.MaLichBay = sct.MaLichBay AND lb.MaChuyenBay = cb.MaChuyenBay AND DiemKhoiHanh = N'{0}' AND DiemDen = N'{1}' AND Ngay = '{2}'", diemkhoihanh, diemden, date);
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public string GetFlightID(string id)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaChuyenBay From LichBay Where MaLichBay like '{0}%'",id.Trim());

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();

            return tmp;
        }

        public List<string> GetIDList()
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaLichBay From LichBay");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            List<string> list = new List<string>();

            while (rd.Read())
            {
                list.Add(rd.GetString(0));
            }

            conn.Close();
            return list;
        }
    }
}
