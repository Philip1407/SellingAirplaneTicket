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
    public partial class ForgetPassword : UserControl
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        public event EventHandler BackClick;
        public event EventHandler FindClick;

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClick?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindClick?.Invoke(this, e);
        }
    }
}
