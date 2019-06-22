using SellAirplaneTicketManagement.BUS;
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
    public partial class FightScheduleDetail : Form
    {
        LichChuyenBayBUS lichchuyenbay = new LichChuyenBayBUS();

        public FightScheduleDetail(LichBay lichbay)
        {
            InitializeComponent();

            lblFight.Text = lichbay.MaChuyenBay;
            lblDate.Text = lichbay.Ngay;
            lblStart.Text = lichbay.GioKhoiHanh;
            lblEnd.Text = lichbay.GioKetThuc;
            lblState.Text = lichbay.TinhTrang;

            grvData.DataSource = lichchuyenbay.LoadDetail(lichbay.MaLichBay);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
