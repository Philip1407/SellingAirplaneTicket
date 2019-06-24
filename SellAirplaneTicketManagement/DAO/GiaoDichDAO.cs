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
    class GiaoDichDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select GiaoDich.*, KhachHang.TenKhachHang From GiaoDich, KhachHang Where GiaoDich.MaKhachHang = KhachHang.MaKhachHang";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(GiaoDich GiaoDich)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MAX(MaGiaoDich) From GiaoDich");

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();


            int id = int.Parse(tmp.Remove(0, 2));
            id++;
            tmp = "GD";
            if (id < 10) tmp += "00";
            else if (id < 100) tmp += "0";
            tmp += id;

            sql = string.Format("Insert into GiaoDich(MaGiaoDich, SoTienGiaoDich, ThoiGianGIaoDich,MaKhachHang,MaNhanVien,SoTaiKhoanChuyenDen,MaLichBay)  Values('{0}','{1}',{2},{3},{4},{5})",
              tmp, GiaoDich.SoTienGiaoDich, GiaoDich.ThoiGianGiaoDich, GiaoDich.MaKhachHang, GiaoDich.MaNhanVien, GiaoDich.SoTaiKhoanChuyenDen, GiaoDich.MaLichBay);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
            
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChuyenBay Where MaGiaoDich={0}",
               id);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public int Update(GiaoDich GiaoDich)
        {
            string sql = string.Format("Update GiaoDich Set SoTienGiaoDich='{1}', ThoiGianGiaoDich='{2}', GiaoDich.MaKhachHang='{3}', MaNhanVien='{4}', SoTaiKhoanChuyenDen='{5}', GiaoDich.MaLichBay='{6}'  Where MaGiaoDich={0}",
               GiaoDich.MaGiaoDich, GiaoDich.SoTienGiaoDich, GiaoDich.ThoiGianGiaoDich, GiaoDich.MaKhachHang, GiaoDich.MaNhanVien, GiaoDich.SoTaiKhoanChuyenDen, GiaoDich.MaLichBay);
            var rs = ProcessData.ExecuteNonQuery(sql);
            return rs;
        }

        public string GetID(string idemployee, string time)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = string.Format("Select MaGiaoDich from GiaoDich where MaNhanVien = '{0}' and ThoiGianGiaoDich ='{1}'",
                idemployee, time);
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rd = command.ExecuteReader();

            string tmp = "";

            if (rd.Read()) tmp = rd.GetString(0);

            conn.Close();

            return tmp;
        }

        public DataTable getReportData(int from,int to)
        {
            DataTable dt = new DataTable();
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(path);
            string sql = "select DATEPART(month, GIAODICH.THOIGIANGIAODICH) AS MONTH, SUM(GIAODICH.SOTIENGIAODICH) AS TOTAL "
                            + "from GIAODICH "
                            + "group by DATEPART(month, GIAODICH.THOIGIANGIAODICH)";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            DataTable newD = new DataTable();
            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "Month";
            newD.Columns.Add(fNameColumn);

            DataColumn lNameColumn = new DataColumn();
            lNameColumn.DataType = System.Type.GetType("System.String");
            lNameColumn.ColumnName = "Total";
            newD.Columns.Add(lNameColumn);
            int k = 0;
            for(int i = from; i <= to; i++)
            {
                if(dt.Rows[k].Field<int>(0) == i)
                {
                    if (k < dt.Rows.Count-1)
                    {
                        k++;
                    }
                    DataRow row = newD.NewRow();
                    row["Month"] = dt.Rows[k].Field<int>(0);
                    row["Total"] = dt.Rows[k].Field<int>(1);
                    newD.Rows.Add(row);
                }else
                {
                    DataRow row = newD.NewRow();
                    row["Month"] = i;
                    row["Total"] = 0;
                    newD.Rows.Add(row);
                }
            }
            return newD;
        }
    }
}
