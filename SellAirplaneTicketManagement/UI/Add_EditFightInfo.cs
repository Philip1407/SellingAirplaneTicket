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
    public partial class Add_EditFightInfo : Form
    {
        public delegate void Add(ChuyenBay chuyenbay);
        public event Add onAdd=null;

        public delegate void Edit(ChuyenBay chuyenbay);
        public event Edit onEdit=null;


        public Add_EditFightInfo()
        {
            InitializeComponent();
        }
        string id;

        public Add_EditFightInfo(ChuyenBay chuyenbay)
        {
            InitializeComponent();

            id = chuyenbay.MaChuyenBay;
            txtHangHangKhong.Text = chuyenbay.HangHangKhong;
            txtDiemKhoiHanh.Text = chuyenbay.DiemKhoiHanh;
            txtDiemDen.Text = chuyenbay.DiemDen;
            txtSoLuongKhach.Text = chuyenbay.SoLuongKhach.ToString();

            btnConfirm.Text = "Cập nhật";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ChuyenBay chuyenbay = GetInfo();
            onAdd?.Invoke(chuyenbay);
            onEdit?.Invoke(chuyenbay);

            this.Close();
        }

        private ChuyenBay GetInfo()
        {
            ChuyenBay inf = new ChuyenBay();

            inf.MaChuyenBay = id;
            inf.HangHangKhong = txtHangHangKhong.Text;
            inf.DiemKhoiHanh = txtDiemKhoiHanh.Text;
            inf.DiemDen = txtDiemDen.Text;
            inf.SoLuongKhach = int.Parse(txtSoLuongKhach.Text);

            return inf;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
