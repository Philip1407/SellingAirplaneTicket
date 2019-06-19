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
    public partial class EmployeeDetail : Form
    {
        public EmployeeDetail(NhanVien nhanvien)
        {
            InitializeComponent();

            lblName.Text = nhanvien.HoTen;
            lblState.Text = nhanvien.TinhTrang;
            lblRole.Text = nhanvien.ChucVu;
            lblDOB.Text = nhanvien.NgaySinh;
            lblAddress.Text = nhanvien.DiaChi;
            lblGender.Text = nhanvien.GioiTinh;
            lblPhone.Text = nhanvien.SoDienThoai;
            lblManager.Text = nhanvien.MaNguoiQuanLy;
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
