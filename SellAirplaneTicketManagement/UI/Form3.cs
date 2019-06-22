using SellAirplaneTicketManagement.BUS;
using SellAirplaneTicketManagement.DTO;
using SellAirplaneTicketManagement.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellAirplaneTicketManagement
{
    public partial class Form3 : Form
    {
        ThongTinChuyenBayBUS thongtinchuyenbay = new ThongTinChuyenBayBUS();
        LichChuyenBayBUS lichchuyenbay = new LichChuyenBayBUS();
        ThongTinAdminBUS thongtinadmin = new ThongTinAdminBUS();
        ThongTinNhanVienBUS thongtinnhanvien = new ThongTinNhanVienBUS();
        ThongTinGiaoDichBUS thongtingiaodich = new ThongTinGiaoDichBUS();
        string EmployeeID = "";


        private void ReloadData()
        {
            checkTransaction1.Data = thongtingiaodich.Loadata();
            ShowEmployeeInfo(EmployeeID);
        }

        private void FillDestinationList()
        {
            List<string> list1 = thongtinchuyenbay.GetDepartList();
            findFight1.DepartList.DataSource = new BindingSource(list1, null);

            List<string> list2 = thongtinchuyenbay.GetArriveList();
            findFight1.ArriveList.DataSource = new BindingSource(list2, null);
        }

        private void ShowEmployeeInfo(string id)
        {
            NhanVien employee = thongtinnhanvien.GetInfo(id);

            ucEmployeeInfo1.FullName = employee.HoTen;
            ucEmployeeInfo1.State = employee.TinhTrang;
            ucEmployeeInfo1.DOB = employee.NgaySinh;
            ucEmployeeInfo1.Address = employee.DiaChi;
            ucEmployeeInfo1.Gender = employee.GioiTinh;
            ucEmployeeInfo1.Phone = employee.SoDienThoai;
            ucEmployeeInfo1.Manager = thongtinnhanvien.GetManagerName(employee.MaNguoiQuanLy);
        }

        private void UpdateEmployeeInfo(string id)
        {
            NhanVien employee = new NhanVien();

            employee.HoTen = ucEmployeeInfo1.FullName;
            employee.TinhTrang = ucEmployeeInfo1.State;
            employee.NgaySinh = ucEmployeeInfo1.DOB;
            employee.DiaChi = ucEmployeeInfo1.Address;
            employee.GioiTinh = ucEmployeeInfo1.Gender;
            employee.SoDienThoai = ucEmployeeInfo1.Phone;
            employee.MaNguoiQuanLy = ucEmployeeInfo1.Manager;

            thongtinnhanvien.Update(employee);
        }

        public Form3(string id)
        {
            InitializeComponent();
            tbMenu.DrawItem += new DrawItemEventHandler(tbMenu_DrawItem);
            EmployeeID = id;
            ReloadData();
            checkTransaction1.GridView.Columns["SOTAIKHOANCHUYENDEN"].Visible = false;
            FillDestinationList();
        }

        private void tbMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tbMenu.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tbMenu.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Blue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Times New Roman", 16.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Bạn có chấc là muốn thoát?","Thông báo",
                                MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true;
            }

        }

        private void checkTransaction1_DetailClick(object sender, EventArgs e)
        {
            GiaoDich giaodich = new GiaoDich();

            giaodich.MaGiaoDich = checkTransaction1.GridView.CurrentRow.Cells[0].Value.ToString();
            giaodich.ThoiGianGiaoDich = checkTransaction1.GridView.CurrentRow.Cells[1].Value.ToString();
            giaodich.SoTienGiaoDich = (int)checkTransaction1.GridView.CurrentRow.Cells[2].Value;
            giaodich.MaKhachHang = checkTransaction1.GridView.CurrentRow.Cells[3].Value.ToString();
            giaodich.MaNhanVien = checkTransaction1.GridView.CurrentRow.Cells[4].Value.ToString();
            giaodich.SoTaiKhoanChuyenDen = checkTransaction1.GridView.CurrentRow.Cells[5].Value.ToString();
            giaodich.MaLichBay = checkTransaction1.GridView.CurrentRow.Cells[6].Value.ToString();

            SeeTransactionInfo frm = new SeeTransactionInfo(giaodich);
            frm.ShowDialog();
        }

        private void findFight1_FindClick(object sender, EventArgs e)
        {
            string date = findFight1.Date;
            string arrive = findFight1.Arrive;
            string depart = findFight1.Depart;

            findFight1.Data = lichchuyenbay.Search(depart, arrive, date);
        }
    }
}
