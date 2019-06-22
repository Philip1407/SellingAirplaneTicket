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
    public class ThongTinChuyenBayBUS
    {
        ChuyenBayDAO chuyenbayDAO= new ChuyenBayDAO();
        public DataTable Loadata()
        {
            return chuyenbayDAO.LoadList();
        }

        public int Insert(ChuyenBay cb)
        {
            return chuyenbayDAO.Insert(cb);
        }

        public int Delete(string id)
        {
            return chuyenbayDAO.Delete(id);
        }

        public int Update(ChuyenBay cb)
        {
            return chuyenbayDAO.Update(cb);
        }

        public List<string> GetDepartList()
        {
            return chuyenbayDAO.DepartList();
        }

        public List<string> GetArriveList()
        {
            return chuyenbayDAO.ArriveList();
        }
    }
}
