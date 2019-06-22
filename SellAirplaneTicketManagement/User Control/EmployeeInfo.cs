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
    public partial class ucEmployeeInfo : UserControl
    {
        public ucEmployeeInfo()
        {
            InitializeComponent();
        }
        public string FullName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string State
        {
            get
            {
                if (cmbState.SelectedItem != null) return cmbState.SelectedItem.ToString();
                else return "";
            }
            set { cmbState.SelectedIndex = cmbState.Items.IndexOf(value); }
        }

        public string DOB
        {
            get { return dpkDOB.Value.ToShortDateString(); }
            set
            {
                if (string.IsNullOrEmpty(value)) dpkDOB.Text = DateTime.Today.ToShortDateString();
                else dpkDOB.Text = value;
            }
        }

        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        public string Gender
        {
            get
            {
                if (cmbGender.SelectedItem != null) return cmbGender.SelectedItem.ToString();
                else return "";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbGender.SelectedIndex = 0;
                else cmbGender.SelectedIndex = cmbGender.Items.IndexOf(value);
            }
        }

        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }

        public string Manager
        {
            get { return lblManager.Text; }
            set { lblManager.Text = value; }
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
