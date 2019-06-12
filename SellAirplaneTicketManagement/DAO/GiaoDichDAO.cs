﻿using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    class GiaoDichDAO
    {
        public DataTable LoadList()
        {
            string sql = "Select * from GiaoDich";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public int Insert(GiaoDich GiaoDich)
        {
            string sql = string.Format("Insert into GiaoDich(MaGiaoDich, SoTienGiaoDich, ThoiGianGIaoDich,MaKhachHang,MaNhanVien,SoTaiKhoanChuyenDen,MaLichBay)  Values('{0}','{1}',{2},{3},{4},{5})",
              GiaoDich.MaGiaoDich, GiaoDich.SoTienGiaoDich, GiaoDich.ThoiGianGiaoDich, GiaoDich.MaKhachHang, GiaoDich.MaNhanVien, GiaoDich.SoTaiKhoanChuyenDen, GiaoDich.MaLichBay);
            var rs = ProcessData.Execute(sql);
            return rs;
            
        }

        public int Delete(string id)
        {
            string sql = string.Format("Delete from ChuyenBay Where MaGiaoDich={0}",
               id);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int Update(GiaoDich GiaoDich)
        {
            string sql = string.Format("Update GiaoDich Set SoTienGiaoDich='{1}', ThoiGianGiaoDich='{2}', GiaoDich.MaKhachHang='{3}', MaNhanVien='{4}', SoTaiKhoanChuyenDen='{5}', GiaoDich.MaLichBay='{6}'  Where MaGiaoDich={0}",
               GiaoDich.MaGiaoDich, GiaoDich.SoTienGiaoDich, GiaoDich.ThoiGianGiaoDich, GiaoDich.MaKhachHang, GiaoDich.MaNhanVien, GiaoDich.SoTaiKhoanChuyenDen, GiaoDich.MaLichBay);
            var rs = ProcessData.Execute(sql);
            return rs;
        }
    }
}
