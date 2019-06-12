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
    public class LichLamViecBUS
    {
        LichLamViecDAO lichlamviecDAO = new LichLamViecDAO();
        public DataTable Loadata()
        {
            return lichlamviecDAO.LoadList();
        }

        public int Insert(LichLamViec dt)
        {
            return lichlamviecDAO.Insert(dt);
        }

        public int Delete(string id)
        {
            return lichlamviecDAO.Delete(id);
        }

        public int Update(LichLamViec dt)
        {
            return lichlamviecDAO.Update(dt);
        }
    }
}
