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
    public partial class SeeTransactionInfo : Form
    {

        ThongTinNhanVienBUS thongtin = new ThongTinNhanVienBUS();
        ThongTinGiaoDichBUS chitiet = new ThongTinGiaoDichBUS();
        public SeeTransactionInfo(GiaoDich giaodich)
        {
            InitializeComponent();

            lblTime.Text = giaodich.ThoiGianGiaoDich;
            lblMoney.Text = giaodich.SoTienGiaoDich.ToString();
            lblEmployee.Text = thongtin.GetManagerName(giaodich.MaNhanVien);

            grvData.DataSource = chitiet.Detail(giaodich.MaKhachHang);
        }
    }
}
