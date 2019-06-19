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
    public partial class CustomerDetail : Form
    {
        public CustomerDetail(KhachHang khachhang)
        {
            InitializeComponent();

            lblName.Text = khachhang.TenKhachHang;
            lblPhone.Text = khachhang.SoDienThoai;
            lblEmail.Text = khachhang.CMND;
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
