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
        ThongTinKhachHangBUS thongtinkhachhang = new ThongTinKhachHangBUS();
        DatVeBUS datve = new DatVeBUS();
        string EmployeeID = "";
        bool valid = false;

        

        private void FillFlightIDList()
        {
            List<string> list = lichchuyenbay.GetIDList();
            bookTicket1.FlightIDList.DataSource = new BindingSource(list, null);
        }
        
        private void FillIDNumberList()
        {
            List<string> list = thongtinkhachhang.GetIDNumberList();
            bookTicket1.IDNumberList.DataSource = new BindingSource(list, null);
        }

        private string GetClassName(string id)
        {
            switch(id){
                case "HV001": return "Thương gia";
                case "HV002": return "Hạng nhất";
                case "HV003": return "Phổ thông";

            }
            return "";
        }

        private string GetClassID(string id)
        {
            switch (id)
            {
                case "Thương gia": return "HV001";
                case "Hạng nhất": return "HV002";
                case "Phổ thông": return "HV003";

            }
            return "";
        }

        private string Cost(string id, int amount, string Class){
            string idflight = lichchuyenbay.GetFlightID(id);
            int cost= datve.GetCost(GetClassID(Class), idflight)*amount;
            if (cost == 0) valid = false;
            else valid = true;
            return cost.ToString()+" VND";
        }

        private void ReloadData()
        {
            checkTransaction1.Data = thongtingiaodich.Loadata();
            ShowEmployeeInfo(EmployeeID);
            FillIDNumberList();
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
            FillFlightIDList();
            FillIDNumberList();
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

        private void bookTicket1_AddCustomerClick(object sender, EventArgs e)
        {
            Add_EditCustomerInfo frm = new Add_EditCustomerInfo();
            frm.onAdd += Frm_onAdd;
            frm.ShowDialog();
        }

        private void Frm_onAdd(KhachHang khachhang)
        {
            thongtinkhachhang.Insert(khachhang);
            ReloadData();
        }

        private void bookTicket1_BookClick(object sender, EventArgs e)
        {
            if (!valid)
            {
                MessageBox.Show("Chưa nhập đủ trường");
                return;
            }
            try
            {
                GiaoDich giaodich = new GiaoDich();
                giaodich.MaKhachHang = thongtinkhachhang.GetIDbyIDNum(bookTicket1.IDNumber);
                giaodich.MaLichBay = bookTicket1.FlightID;
                giaodich.MaNhanVien = EmployeeID;
                giaodich.SoTienGiaoDich = int.Parse(bookTicket1.Total.Split(' ')[0]);
                giaodich.ThoiGianGiaoDich = DateTime.Now.ToString();

                thongtingiaodich.Insert(giaodich);

                Ve ve = new Ve();
                ve.MaLichBay = bookTicket1.FlightID;
                ve.MaHangVe = GetClassID(bookTicket1.Class);
                int amount = bookTicket1.Amount;
                datve.Insert(ve, amount, thongtingiaodich.GetID(giaodich.MaNhanVien, giaodich.ThoiGianGiaoDich));

                MessageBox.Show("Đặt vé thành công");
                ReloadData();

            }
            catch
            {
                MessageBox.Show("Chưa nhập đủ trường");
                return;
            }

        }

        private void bookTicket1_onAmountChange(object sender, EventArgs e)
        {
            bookTicket1.Total = Cost(bookTicket1.FlightID, bookTicket1.Amount, bookTicket1.Class);
            valid = true;
        }

        private void bookTicket1_onClassChange(object sender, EventArgs e)
        {
            bookTicket1.Total = Cost(bookTicket1.FlightID, bookTicket1.Amount, bookTicket1.Class);
            valid = true;
        }

        private void bookTicket1_onChangeCustomerIDNumber(object sender, EventArgs e)
        {
            string name = thongtinkhachhang.GetNameByIdNum(bookTicket1.IDNumber);
            if (string.IsNullOrEmpty(name))
            {
                bookTicket1.CustomerName = "Chưa có khách hàng này trong dữ liệu";
                valid = false;
            }
            else
            {
                bookTicket1.CustomerName = name;
                valid = true;
            }
                
        }

        private void bookTicket1_onFlightIDChange(object sender, EventArgs e)
        {
            List<string> list= new List<string>();
            foreach(string item in lichchuyenbay.GetClassList(bookTicket1.FlightID))
            {
                list.Add(GetClassName(item));
            }
            
            bookTicket1.ClassList.DataSource = new BindingSource(list, null);
        }

        private void ucEmployeeInfo1_ExitClick(object sender, EventArgs e)
        {
            EmployeeID = "";
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        
    }
}
