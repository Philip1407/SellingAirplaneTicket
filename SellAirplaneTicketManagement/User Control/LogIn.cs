using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellAirplaneTicketManagement
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public event EventHandler LoginClick;
        public event EventHandler ForgotPasswordClick;
        public event EventHandler SignUpClick;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClick?.Invoke(this, e);
        }

        private void lblForgetpassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordClick?.Invoke(this, e);
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            SignUpClick?.Invoke(this, e);
        }
    }
}
