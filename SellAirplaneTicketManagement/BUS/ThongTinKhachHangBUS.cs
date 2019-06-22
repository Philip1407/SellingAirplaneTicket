using SellAirplaneTicketManagement.DAO;
using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.BUS
{
    public class ThongTinKhachHangBUS
    {
        KhachHangDAO khachhangDAO = new KhachHangDAO();

        public DataTable Loadata()
        {
            return khachhangDAO.LoadList();
        }

        public int Insert(KhachHang lb)
        {
            return khachhangDAO.Insert(lb);
        }

        public int Delete(string id)
        {
            return khachhangDAO.Delete(id);
        }

        public int Update(KhachHang lb)
        {
            return khachhangDAO.Update(lb);
        }

        public string GetName(string id)
        {
            return khachhangDAO.GetName(id);
        }
    }
}
