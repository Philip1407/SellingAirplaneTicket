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
        ChiTietGiaoDichDAO chitietgiaodichDAO = new ChiTietGiaoDichDAO();

        public DataTable Loadata()
        {
            return veDAO.LoadList();
        }

        public int Insert(Ve lb, int amount, string idTran)
        {
            ChiTietGiaoDich ct = new ChiTietGiaoDich();
            return veDAO.Insert(lb, amount,idTran);
        }

        public int Delete(string id)
        {
            return veDAO.Delete(id);
        }

        public int Update(Ve lb)
        {
            return veDAO.Update(lb);
        }

        public int GetCost(string idclass, string idflight)
        {
            return new HangVeDAO().GetCost(idclass,idflight);
        }
    }
}
