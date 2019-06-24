﻿using SellAirplaneTicketManagement.DAO;
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
        ChuyenBayDAO chuyenbayDAO = new ChuyenBayDAO();

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

        public List<string> GetAllID()
        {
            return chuyenbayDAO.GetIDList();
        }

        public DataTable LoadDetail(string id)
        {
            return lichbayDAO.DetailLoad(id);
        }

        public void UpdateAll(DataTable dt)
        {
            lichbayDAO.UpdateAll(dt);
        }

        public DataTable Search(string diemkhoihanh, string diemden,string date)
        {
            return lichbayDAO.Search(diemkhoihanh, diemden, date);
        }

        public string GetFlightID(string id)
        {
            return lichbayDAO.GetFlightID(id);
        }

        public List<string> GetIDList()
        {
            return lichbayDAO.GetIDList();
        }

        public List<string> GetClassList(string id)
        {
            return new HangVeDAO().GetClassList(id);
        }
    }
}
