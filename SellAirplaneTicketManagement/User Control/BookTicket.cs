using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellAirplaneTicketManagement.User_Control
{
    public partial class BookTicket : UserControl
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        public string FlightID
        {
            get
            {
                if (cmbFlightID.SelectedItem != null) return cmbFlightID.SelectedItem.ToString();
                else return "";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbFlightID.SelectedIndex = 0;
                else cmbFlightID.SelectedIndex = cmbFlightID.Items.IndexOf(value);
            }
        }

        public ComboBox FlightIDList
        {
            get { return cmbFlightID; }
            set { cmbFlightID = value; }
        }

        public int Amount
        {
            get { return Convert.ToInt32(nudAmount.Value); }
            set { nudAmount.Value = value; }
        } 

        public string Class
        {
            get
            {
                if (cmbClass.SelectedItem != null) return cmbClass.SelectedItem.ToString();
                else return "";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbClass.SelectedIndex = 0;
                else cmbClass.SelectedIndex = cmbClass.Items.IndexOf(value);
            }
        }

        public ComboBox ClassList
        {
            get { return cmbClass; }
            set { cmbClass = value; }
        }

        public string CustomerName
        {
            get { return lblCustomerName.Text; }
            set { lblCustomerName.Text = value; }
        }

        public ComboBox IDNumberList
        {
            get { return cmbIDNumber; }
            set { cmbIDNumber = value; }
        }

        public string IDNumber
        {
            get
            {
                if (cmbIDNumber.SelectedItem != null) return cmbIDNumber.SelectedItem.ToString();
                else return "";
            }
            set
            {
                cmbIDNumber.SelectedIndex = cmbIDNumber.Items.IndexOf(value);
            }
        }

        public string Total
        {
            get { return lblTotal.Text; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    lblTotal.Text = "";
                    lblTotal.Visible = false;
                }
                else
                {
                    lblTotal.Text = value;
                    lblTotal.Visible = true;
                }
            }
        }

        public event EventHandler BookClick;
        private void btnBook_Click(object sender, EventArgs e)
        {
            BookClick?.Invoke(this, e);
        }
        
        public event EventHandler AddCustomerClick;
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerClick?.Invoke(this, e);
        }
        
        public event EventHandler onAmountChange;

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            onAmountChange?.Invoke(this, e);
        }

        public event EventHandler onClassChange;

        private void cmbClass_TextChanged(object sender, EventArgs e)
        {
            onClassChange?.Invoke(this, e);
        }

        public event EventHandler onFlightIDChange;

        private void cmbFlightID_TextChanged(object sender, EventArgs e)
        {
            onFlightIDChange?.Invoke(this, e);
        }

        public event EventHandler onChangeCustomerIDNumber;
        private void cmbIDNumber_TextChanged(object sender, EventArgs e)
        {
            onChangeCustomerIDNumber?.Invoke(this, e);
        }
    }
}
