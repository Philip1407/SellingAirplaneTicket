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
    public partial class Add_EditCustomerInfo : Form
    {
        public delegate void Add(KhachHang khachhang);
        public event Add onAdd = null;

        public delegate void Edit();
        public event Edit onEdit = null;

        public Add_EditCustomerInfo()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = GetInfo();
            onAdd?.Invoke(khachhang);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private KhachHang GetInfo()
        {
            KhachHang khachhang = new KhachHang();
            khachhang.TenKhachHang = txtName.Text;
            khachhang.SoDienThoai = txtPhoneNumber.Text;
            khachhang.CMND = txtCustomerIDNumber.Text;

            return khachhang;
        }
    }
}
