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
        public Admin()
        {
            InitializeComponent();

            tbMenu.DrawItem += new DrawItemEventHandler(tbMenu_DrawItem);
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

        private void ucFightInfo_AddClick(object sender, EventArgs e)
        {
            Add_EditFightInfo frm = new Add_EditFightInfo();
            frm.ShowDialog();
        }

        private void ucFightInfo_EditClick(object sender, EventArgs e)
        {
            Add_EditFightInfo frm = new Add_EditFightInfo();
            frm.ShowDialog();
        }

        private void ucFightInfo_DeleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);

        }
        private void ucFightInfo_DetailClick(object sender, EventArgs e)
        {
            Add_EditFightInfo frm = new Add_EditFightInfo();
            frm.ShowDialog();
        }


        private void ucFightSchedule_AddClick(object sender, EventArgs e)
        {
            Add_EditFightSchedule frm = new Add_EditFightSchedule();
            frm.ShowDialog();
        }

        private void ucFightSchedule_DetailClick(object sender, EventArgs e)
        {
            Add_EditFightSchedule frm = new Add_EditFightSchedule();
            frm.ShowDialog();
        }

        private void ucFightSchedule_DeleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
        }

        private void ucFightSchedule_EditClick(object sender, EventArgs e)
        {
            Add_EditFightSchedule frm = new Add_EditFightSchedule();
            frm.ShowDialog();
        }

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
            Add_EditEmployeeSchedule frm = new Add_EditEmployeeSchedule();
            frm.ShowDialog();
        }

        private void ucEmployeeSchedule_DeleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc là muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel);

        }

        private void ucEmployeeSchedule_DetailClick(object sender, EventArgs e)
        {
            Add_EditEmployeeSchedule frm = new Add_EditEmployeeSchedule();
            frm.ShowDialog();
        }

        private void ucEmployeeSchedule_EditClick(object sender, EventArgs e)
        {
            Add_EditEmployeeSchedule frm = new Add_EditEmployeeSchedule();
            frm.ShowDialog();
        }

        private void checkTransaction1_DetailClick(object sender, EventArgs e)
        {
            SeeTransactionInfo frm = new SeeTransactionInfo();
            frm.ShowDialog();
        }
    }
}
