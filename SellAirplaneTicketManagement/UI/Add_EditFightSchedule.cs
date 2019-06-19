using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellAirplaneTicketManagement.UI
{
    public partial class Add_EditFightSchedule : Form
    {

        string idlich="";

       
        public Add_EditFightSchedule()
        {
            InitializeComponent();
            dpkStart.Format = DateTimePickerFormat.Time;
            dpkEnd.Format = DateTimePickerFormat.Time;
        }

        public Add_EditFightSchedule(LichBay lichbay)
        {
            InitializeComponent();

            dpkStart.Format = DateTimePickerFormat.Time;
            dpkEnd.Format = DateTimePickerFormat.Time;

            idlich = lichbay.MaLichBay;
            txtChuyenbay.Text = lichbay.MaChuyenBay;
            dpkDate.Text = lichbay.Ngay;
            dpkStart.Text = lichbay.GioKhoiHanh;
            dpkEnd.Text = lichbay.GioKetThuc;
            cmbState.SelectedIndex = cmbState.Items.IndexOf(lichbay.TinhTrang);
        }

        public delegate void Add(LichBay lichbay);
        public event Add onAdd = null;

        public delegate void Edit(LichBay lichbay);
        public event Edit onEdit = null;
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LichBay lichbay = GetInfo();
            onAdd?.Invoke(lichbay);
            onEdit?.Invoke(lichbay);
        }

        private LichBay GetInfo()
        {
            LichBay inf = new LichBay();

            inf.MaLichBay = idlich;
            inf.MaChuyenBay = txtChuyenbay.Text;
            inf.Ngay = dpkDate.Value.ToShortDateString();
            inf.GioKhoiHanh = dpkStart.Value.ToShortTimeString();
            inf.GioKetThuc = dpkEnd.Value.ToShortTimeString();
            inf.TinhTrang = cmbState.SelectedItem.ToString();

            return inf;

        }
    }
}
