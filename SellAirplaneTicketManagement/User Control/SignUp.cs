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
        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpClick?.Invoke(this, e);
        }

        public void ClearForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        public string IDEmployee
        {
            get { return lblEmployeeID.Text; }
            set { lblEmployeeID.Text = value; }

        }
       
        public string Pass
        {
            get { return txtPass.Text; }
            set { txtPass.Text=value; }
        }

        public string RePass
        {
            get { return txtRePass.Text; }
            set { txtRePass.Text = value; }
        }

        public string FullName
        {
            get { return txtFullName.Text; }
            set { txtFullName.Text = value; }
        }

        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string DOB {
            get { return dpkDOB.Value.ToShortDateString(); }
            set
            {
                if (string.IsNullOrEmpty(value)) dpkDOB.Text = DateTime.Today.ToShortDateString();
                else dpkDOB.Text = value;
            }
        }

        public string Gender {
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

        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }


    }
}
