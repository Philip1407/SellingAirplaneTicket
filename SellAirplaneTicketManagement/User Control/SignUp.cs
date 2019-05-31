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
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public event EventHandler SignUpClick;
        public event EventHandler BackClick;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpClick?.Invoke(this, e);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            BackClick?.Invoke(this, e);
        }
    }
}
