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
    public class LichChuyenBayBUS
    {
        LichBayDAO lichbayDAO = new LichBayDAO();

        public DataTable Loadata()
        {
            return lichbayDAO.LoadList();
        }

        public int Insert(LichBay lb)
        {
            return lichbayDAO.Insert(lb);
        }

        public int Delete(string id)
        {
            return lichbayDAO.Delete(id);
        }

        public int Update(LichBay lb)
        {
            return lichbayDAO.Update(lb);
        }
    }
}
