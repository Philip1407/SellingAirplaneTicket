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
    public partial class ucUserInfo : UserControl
    {
        public ucUserInfo()
        {
            InitializeComponent();
        }

        public event EventHandler ConfirmClick;
        public event EventHandler ExitClick;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmClick?.Invoke(this, e);
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitClick?.Invoke(this, e);
        }
    }
}
