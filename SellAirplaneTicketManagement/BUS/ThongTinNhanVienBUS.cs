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
    public class ThongTinNhanVienBUS
    {
        NhanVienDAO nhanvienDAO = new NhanVienDAO();

        public DataTable Loadata()
        {
            return nhanvienDAO.LoadList();
        }

        public int Insert(NhanVien lb)
        {
            return nhanvienDAO.Insert(lb);
        }

        public int Delete(string id)
        {
            return nhanvienDAO.Delete(id);
        }

        public int Update(NhanVien lb)
        {
            return nhanvienDAO.Update(lb);
        }

        public List<string> GetAllManager()
        {
            return nhanvienDAO.ManagerList();
        }

        public string GetManagerName(string id)
        {
            return nhanvienDAO.ManagerName(id);
        }

        public List<string> GetAllEmployee()
        {
            return nhanvienDAO.EmployeeList();
        }

        public NhanVien GetInfo(string id)
        {
            return nhanvienDAO.GetInfo(id);
        }
    }
}
