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
    public class DatVeBUS
    {
        VeDAO veDAO = new VeDAO();

        public DataTable Loadata()
        {
            return veDAO.LoadList();
        }

        public int Insert(Ve lb)
        {
            return veDAO.Insert(lb);
        }

        public int Delete(string id)
        {
            return veDAO.Delete(id);
        }

        public int Update(Ve lb)
        {
            return veDAO.Update(lb);
        }
    }
}
