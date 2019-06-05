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

        bool addCustomer = true;

        public bool AddCustomer
        {
            get
            {
                return addCustomer;
            }
            set
            {
                addCustomer = value;
                if (addCustomer) btnAddCustomer.Show();
                else btnAddCustomer.Hide();
            }
        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public event EventHandler AddCustomerClick;
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerClick?.Invoke(this, e);
        }
    }
}
