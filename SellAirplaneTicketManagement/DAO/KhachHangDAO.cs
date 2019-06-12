using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = string.Format("Insert into HangVe(MaKhachHang, TenKhachHang, SoDienThoai, MatKhau, CMND)  Values('{0}','{1}',{2},{3},{4})",
              KhachHang.MaKhachHang, KhachHang.TenKhachHang, KhachHang.SoDienThoai, KhachHang.MatKhau, KhachHang.CMND);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChuyenBay Where MaKhachHang='{0}'",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(KhachHang KhachHang)
        {
            string sql = string.Format("Update GiaoDich Set TenKhachHang='{1}', SoDienThoai='{2}', MatKhau='{3}', CMND='{4}'  Where MaKhachHang='{0}'",
              KhachHang.MaKhachHang, KhachHang.TenKhachHang, KhachHang.SoDienThoai, KhachHang.MatKhau, KhachHang.CMND);
            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }
}
