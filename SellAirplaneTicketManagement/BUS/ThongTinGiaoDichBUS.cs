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
    public class ThongTinGiaoDichBUS
    {
        GiaoDichDAO giaodichDAO = new GiaoDichDAO();
        ChiTietGiaoDichDAO chitietgiaodichDAO = new ChiTietGiaoDichDAO();

        public DataTable Loadata()
        {
            return giaodichDAO.LoadList();
        }

        public int Insert(GiaoDich dt)
        {
            return giaodichDAO.Insert(dt);
        }

        public int Delete(string id)
        {
            return giaodichDAO.Delete(id);
        }

        public int Update(GiaoDich dt)
        {
            return giaodichDAO.Update(dt);
        }
    }
}
