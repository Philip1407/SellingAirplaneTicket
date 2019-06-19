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
    public partial class Add_EditEmployeeSchedule : Form
    {
        ThongTinNhanVienBUS thongtin = new ThongTinNhanVienBUS();

        public delegate void Add(LichLamViec lichlamviec);
        public event Add onAdd = null;

        public delegate void Edit(LichLamViec lichlamviec);
        public event Edit onEdit = null;

        private void FillID()
        {
            List<string> list = thongtin.GetAllEmployee();
            cmbID.DataSource = new BindingSource(list, null);
        }

        public Add_EditEmployeeSchedule()
        {
            InitializeComponent();
            FillID();
            cmbID.SelectedIndex = 0;
            cmbShift.SelectedIndex = 0;
        }

        public Add_EditEmployeeSchedule(LichLamViec lichlamviec)
        {
            InitializeComponent();
            FillID();

            cmbID.SelectedIndex = cmbID.Items.IndexOf(lichlamviec.MaNhanVien);
            lblName.Text = thongtin.GetManagerName(lichlamviec.MaNhanVien);
            dpkDate.Text = lichlamviec.Ngay;
            cmbShift.SelectedIndex = cmbShift.Items.IndexOf(lichlamviec.Ca.ToString());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LichLamViec lichlamviec = GetInfo();

            onAdd?.Invoke(lichlamviec);
            onEdit?.Invoke(lichlamviec);
            this.Close();
        }

        private LichLamViec GetInfo()
        {
            LichLamViec lichlamviec = new LichLamViec();

            lichlamviec.MaNhanVien = cmbID.SelectedItem.ToString();
            lichlamviec.Ngay = dpkDate.Value.ToShortDateString();
            lichlamviec.Ca = int.Parse(cmbShift.SelectedItem.ToString());
            
            return lichlamviec;
        }

        private void cmbID_SelectedValueChanged(object sender, EventArgs e)
        {
            lblName.Text = thongtin.GetManagerName(cmbID.SelectedItem.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
