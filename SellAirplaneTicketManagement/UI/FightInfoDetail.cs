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
    public partial class FightInfoDetail : Form
    {
        public FightInfoDetail(ChuyenBay chuyenbay)
        {
            InitializeComponent();

            lblAirport.Text = chuyenbay.HangHangKhong;
            lblStart.Text = chuyenbay.DiemKhoiHanh;
            lblFinish.Text = chuyenbay.DiemDen;
            lblLimit.Text = chuyenbay.SoLuongKhach.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
