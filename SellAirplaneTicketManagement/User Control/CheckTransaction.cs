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
    public partial class CheckTransaction : UserControl
    {
        public CheckTransaction()
        {
            InitializeComponent();
        }

        public event EventHandler AddClick;
        public event EventHandler EditClick;
        public event EventHandler DeleteClick;

        protected DataTable DataTable
        {
            set { grvData.DataSource = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClick?.Invoke(this, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditClick?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClick?.Invoke(this, e);
        }


    }
}