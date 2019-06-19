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
    public partial class Admin : Form
    {
        ThongTinChuyenBayBUS thongtinchuyenbay = new ThongTinChuyenBayBUS();
        LichChuyenBayBUS lichchuyenbay = new LichChuyenBayBUS();
        ThongTinNhanVienBUS thongtinnhanvien = new ThongTinNhanVienBUS();
        LichLamViecBUS lichlamviec = new LichLamViecBUS();
        ThongTinGiaoDichBUS thongtingiaodich = new ThongTinGiaoDichBUS();
        ThongTinKhachHangBUS thongtinkhachhang = new ThongTinKhachHangBUS();
        ThongTinAdminBUS thongtinadmin = new ThongTinAdminBUS();

        string AdminID = "";

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void ReloadData()
        {
            ucFightInfo.Data = thongtinchuyenbay.Loadata();
            ucFightSchedule.Data = lichchuyenbay.Loadata();
            EmployeeInfo.Data = thongtinnhanvien.Loadata();
            ucEmployeeSchedule.Data = lichlamviec.Loadata();
            checkTransaction1.Data = thongtingiaodich.Loadata();
            ucCustomerInfo.Data = thongtinkhachhang.Loadata();
        }
        
        public Admin()
        {
            InitializeComponent();
            tbMenu.DrawItem += new DrawItemEventHandler(tbMenu_DrawItem);
            ReloadData();
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
                if (MessageBox.Show("Bạn có chắc là muốn thoát?","Thông báo",
                                MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true;
            }
        }

        //Fight Info tab function
        private void ucFightInfo_AddClick(object sender, EventArgs e)
        {
            Add_EditFightInfo frm = new Add_EditFightInfo();
            frm.onAdd += Frm_onAdd;
            frm.ShowDialog();
        }

        private void Frm_onAdd(ChuyenBay chuyenbay)
        {
            thongtinchuyenbay.Insert(chuyenbay); 
            ReloadData();
        }

        private void ucFightInfo_EditClick(object sender, EventArgs e)
        {
            ChuyenBay chuyenbay = new ChuyenBay();

            chuyenbay.MaChuyenBay = ucFightInfo.GridView.CurrentRow.Cells[0].Value.ToString();
            chuyenbay.HangHangKhong = ucFightInfo.GridView.CurrentRow.Cells[1].Value.ToString();
            chuyenbay.DiemKhoiHanh = ucFightInfo.GridView.CurrentRow.Cells[2].Value.ToString();
            chuyenbay.DiemDen = ucFightInfo.GridView.CurrentRow.Cells[3].Value.ToString();
            chuyenbay.SoLuongKhach = (int)ucFightInfo.GridView.CurrentRow.Cells[4].Value;

            Add_EditFightInfo frm = new Add_EditFightInfo(chuyenbay);
            frm.onEdit += Frm_onEdit;
            frm.ShowDialog();
        }

        private void Frm_onEdit(ChuyenBay chuyenbay)
        {
            thongtinchuyenbay.Update(chuyenbay);
            ReloadData();
        }

        private void ucFightInfo_DeleteClick(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);

            if (msg == DialogResult.No) return;
            string id = ucFightInfo.GridView.CurrentRow.Cells[0].Value.ToString();

            thongtinchuyenbay.Delete(id);
            ReloadData();
        }
        private void ucFightInfo_DetailClick(object sender, EventArgs e)
        {
            ChuyenBay chuyenbay = new ChuyenBay();

            chuyenbay.MaChuyenBay = ucFightInfo.GridView.CurrentRow.Cells[0].Value.ToString();
            chuyenbay.HangHangKhong = ucFightInfo.GridView.CurrentRow.Cells[1].Value.ToString();
            chuyenbay.DiemKhoiHanh = ucFightInfo.GridView.CurrentRow.Cells[2].Value.ToString();
            chuyenbay.DiemDen = ucFightInfo.GridView.CurrentRow.Cells[3].Value.ToString();
            chuyenbay.SoLuongKhach = (int)ucFightInfo.GridView.CurrentRow.Cells[4].Value;

            FightInfoDetail frm = new FightInfoDetail(chuyenbay);
            frm.ShowDialog();
        }
        //End of FightInfo Tab function


        //FightSchedule Tab Function

        private void ucFightSchedule_AddClick(object sender, EventArgs e)
        {
            Add_EditFightSchedule frm = new Add_EditFightSchedule();
            frm.onAdd += Frm_onAdd1;
            frm.ShowDialog();
        }

        private void Frm_onAdd1(LichBay lichbay)
        {
            lichchuyenbay.Insert(lichbay);
            ReloadData();
        }

        private void ucFightSchedule_DetailClick(object sender, EventArgs e)
        {
            Add_EditFightSchedule frm = new Add_EditFightSchedule();
            frm.ShowDialog();
        }

        private void ucFightSchedule_DeleteClick(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);

            if (msg == DialogResult.No) return;
            string id = ucFightSchedule.GridView.CurrentRow.Cells[0].Value.ToString();

            new LichChuyenBayBUS().Delete(id);
            ReloadData();
        }

        private void ucFightSchedule_EditClick(object sender, EventArgs e)
        {
            LichBay lichbay = new LichBay();
            lichbay.MaLichBay = ucFightSchedule.GridView.CurrentRow.Cells[0].Value.ToString();
            lichbay.MaChuyenBay = ucFightSchedule.GridView.CurrentRow.Cells[1].Value.ToString();
            lichbay.Ngay= ucFightSchedule.GridView.CurrentRow.Cells[2].Value.ToString();
            lichbay.GioKhoiHanh = ucFightSchedule.GridView.CurrentRow.Cells[3].Value.ToString();
            lichbay.GioKetThuc= ucFightSchedule.GridView.CurrentRow.Cells[4].Value.ToString();
            lichbay.TinhTrang= ucFightSchedule.GridView.CurrentRow.Cells[5].Value.ToString();

            Add_EditFightSchedule frm = new Add_EditFightSchedule(lichbay);
            frm.onEdit += Frm_onEdit1;
            frm.ShowDialog();
        }

        private void Frm_onEdit1(LichBay lichbay)
        {
            lichchuyenbay.Update(lichbay);
            ReloadData();
        }

        // End of FightSchedule Tab Function



        private void EmployeeInfo_AddClick(object sender, EventArgs e)
        {
            Add_EditEmployeeInfo frm = new Add_EditEmployeeInfo();
            frm.ShowDialog();
        }

        private void EmployeeInfo_DeleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
        }

        private void EmployeeInfo_DetailClick(object sender, EventArgs e)
        {
            Add_EditEmployeeInfo frm = new Add_EditEmployeeInfo();
            frm.ShowDialog();
        }

        private void EmployeeInfo_EditClick(object sender, EventArgs e)
        {
            Add_EditEmployeeInfo frm = new Add_EditEmployeeInfo();
            frm.ShowDialog();
        }

        private void ucEmployeeSchedule_AddClick(object sender, EventArgs e)
        {
            EmployeeScheduleDetail frm = new EmployeeScheduleDetail();
            frm.ShowDialog();
        }

        private void ucEmployeeSchedule_DeleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);

        }

        private void ucEmployeeSchedule_DetailClick(object sender, EventArgs e)
        {
            EmployeeScheduleDetail frm = new EmployeeScheduleDetail();
            frm.ShowDialog();
        }

        private void ucEmployeeSchedule_EditClick(object sender, EventArgs e)
        {
            


            EmployeeScheduleDetail frm = new EmployeeScheduleDetail();
            frm.ShowDialog();
        }

        private void checkTransaction1_DetailClick(object sender, EventArgs e)
        {
            SeeTransactionInfo frm = new SeeTransactionInfo();
            frm.ShowDialog();
        }

        private void CheckCustomerInfo_DetailClick(object sender, EventArgs e)
        {
            Add_EditCustomerInfo frm = new Add_EditCustomerInfo();
            frm.ShowDialog();
        }
    }
}
