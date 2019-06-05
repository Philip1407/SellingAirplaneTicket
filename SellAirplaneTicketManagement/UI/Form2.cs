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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            HideAll();
            logIn1.BringToFront();
            logIn1.Show();
        }

        private void HideAll()
        {
            forgetPassword1.Hide();
            signUp1.Hide();
            logIn1.Hide();
        }

        private void logIn1_ForgotPasswordClick(object sender, EventArgs e)
        {
            HideAll();
            forgetPassword1.Show();
            forgetPassword1.BringToFront();
        }

        private void logIn1_LoginClick(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void logIn1_SignUpClick(object sender, EventArgs e)
        {
            HideAll();
            signUp1.BringToFront();
            signUp1.Show();
        }

        private void signUp1_BackClick(object sender, EventArgs e)
        {
            HideAll();
            logIn1.BringToFront();
            logIn1.Show();
        }

        private void forgetPassword1_BackClick(object sender, EventArgs e)
        {
            HideAll();
            logIn1.BringToFront();
            logIn1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Bạn có chấc là muốn thoát?",
                               "Thông báo",
                                MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true;
            }
        }
    }
}
