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
    public partial class Add_EditEmployeeInfo : Form
    {
        public delegate void Add(NhanVien nhanvien);
        public event Add onAdd =null;

        public delegate void Edit(NhanVien nhanvien);
        public event Edit onEdit = null;
        ThongTinNhanVienBUS thongtinnhanvien = new ThongTinNhanVienBUS();

        private void FillManagerList()
        {
            List<string> list = thongtinnhanvien.GetAllManager();
            cmbManager.DataSource = new BindingSource(list, null);
        }
        
        public Add_EditEmployeeInfo()
        {
            InitializeComponent();
            FillManagerList();
            cmbRole.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
        }

        public Add_EditEmployeeInfo(NhanVien nhanvien)
        {
            InitializeComponent();
            FillManagerList();

            txtName.Text = nhanvien.HoTen;
            cmbState.SelectedItem = cmbState.Items.IndexOf(nhanvien.TinhTrang);
            cmbRole.SelectedItem = cmbRole.Items.IndexOf(nhanvien.ChucVu);
            dpkDOB.Text = nhanvien.NgaySinh;
            txtAddress.Text = nhanvien.DiaChi;
            cmbGender.SelectedItem = cmbGender.Items.IndexOf(nhanvien.GioiTinh);
            txtPhone.Text = nhanvien.SoDienThoai;
            cmbManager.Text = nhanvien.MaNguoiQuanLy;

            lblManagerName.Text = thongtinnhanvien.GetManagerName(nhanvien.MaNguoiQuanLy);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = GetInfo();
            onAdd?.Invoke(nhanvien);
            onEdit?.Invoke(nhanvien);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private NhanVien GetInfo()
        {
            NhanVien nhanvien = new NhanVien();

            nhanvien.HoTen=txtName.Text;
            nhanvien.TinhTrang=cmbState.SelectedItem.ToString();
            nhanvien.ChucVu = cmbRole.SelectedItem.ToString();
            nhanvien.NgaySinh= dpkDOB.Value.ToShortDateString();
            nhanvien.DiaChi = txtAddress.Text;
            nhanvien.GioiTinh = cmbGender.SelectedItem.ToString();
            nhanvien.SoDienThoai = txtPhone.Text;
            nhanvien.MaNguoiQuanLy = cmbManager.SelectedItem.ToString();

            return nhanvien;
        }

        private void cmbManager_SelectedValueChanged(object sender, EventArgs e)
        {
            lblManagerName.Text = thongtinnhanvien.GetManagerName(cmbManager.SelectedItem.ToString());
        }

        private void cmbRole_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbRole.SelectedItem.ToString()!="Nhân viên bán vé")
            {
                lblManager.Hide();
                cmbManager.Hide();
                lblManagerName.Hide();
            }
            else
            {
                lblManager.Show();
                cmbManager.Show();
                lblManagerName.Show();
            }
        }
    }
}
