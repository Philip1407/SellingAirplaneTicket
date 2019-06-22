using SellAirplaneTicketManagement.BUS;
using SellAirplaneTicketManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellAirplaneTicketManagement.UI
{
    public partial class Add_EditFightSchedule : Form
    {

        string idlich="";
        LichChuyenBayBUS lichchuyenbay = new LichChuyenBayBUS();



        private void GetIDList()
        {
            List<string> list = lichchuyenbay.GetAllID();
            cmbFight.DataSource = new BindingSource(list, null);
            
        }
       
        public Add_EditFightSchedule()
        {
            InitializeComponent();
            dpkStart.Format = DateTimePickerFormat.Time;
            dpkEnd.Format = DateTimePickerFormat.Time;
            GetIDList();
            cmbFight.SelectedIndex = 1;
            cmbState.SelectedIndex = 1;
        }

        public Add_EditFightSchedule(LichBay lichbay)
        {
            InitializeComponent();

            dpkStart.Format = DateTimePickerFormat.Time;
            dpkEnd.Format = DateTimePickerFormat.Time;
            GetIDList();
            cmbFight.SelectedIndex = 1;
            cmbState.SelectedIndex = 1;

            idlich = lichbay.MaLichBay;
            cmbFight.SelectedIndex = cmbFight.Items.IndexOf(lichbay.MaChuyenBay);
            dpkDate.Text = lichbay.Ngay;
            dpkStart.Text = lichbay.GioKhoiHanh;
            dpkEnd.Text = lichbay.GioKetThuc;
            cmbState.SelectedIndex = cmbState.Items.IndexOf(lichbay.TinhTrang);

            grvData.DataSource = lichchuyenbay.LoadDetail(lichbay.MaLichBay);
        }

        public delegate void Add(LichBay lichbay);
        public event Add onAdd = null;

        public delegate void Edit(LichBay lichbay);
        public event Edit onEdit = null;
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LichBay lichbay = GetInfo();
            lichchuyenbay.UpdateAll(grvData.DataSource as DataTable);

            onAdd?.Invoke(lichbay);
            onEdit?.Invoke(lichbay);
            this.Close();
        }

        private LichBay GetInfo()
        {
            LichBay inf = new LichBay();

            inf.MaLichBay = idlich;
            inf.MaChuyenBay = cmbFight.SelectedItem.ToString();
            inf.Ngay = dpkDate.Value.ToShortDateString();
            inf.GioKhoiHanh = dpkStart.Value.ToShortTimeString();
            inf.GioKetThuc = dpkEnd.Value.ToShortTimeString();
            inf.TinhTrang = cmbState.SelectedItem.ToString();

            return inf;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
