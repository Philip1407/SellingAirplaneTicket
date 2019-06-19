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
    public partial class ucAdminInfo : UserControl
    {
        public ucAdminInfo()
        {
            InitializeComponent();
        }

        public string FullName {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string State {
            get { return txtState.Text; }
            set { txtState.Text = value; }
        }

        public string Role {
            get { return txtRole.Text; }
            set { txtRole.Text = value; }
        }

        public string DOB {
            get { return txtDOB.Text; }
            set { txtDOB.Text = value; }
        }

        public string Address {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        public string Gender {
            get { return txtGender.Text; }
            set { txtGender.Text = value; }
        }

        public string Phone {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
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
