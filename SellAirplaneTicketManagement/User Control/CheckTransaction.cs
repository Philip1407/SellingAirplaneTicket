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

        private bool add=true;
        private bool delete = true;
        private bool edit = true;
        
        public bool AddEnable
        {
            get
            {
                return add;
            }
            set
            {
                if (value)
                {
                    btnAdd.Show();
                    add = true;
                }
                else {
                    btnAdd.Hide();
                    add = false;
                }
            }
        }

        public bool EditEnable
        {
            get
            {
                return edit;
            }
            set
            {
                if (value)
                {
                    btnEdit.Show();
                    edit = true;
                }
                else
                {
                    btnEdit.Hide();
                    edit = false;
                }
            }
        }

        public bool DeleteEnable {
            get
            {
                return delete;
            }
            set
            {
                if (value)
                {
                    btnDelete.Show();
                    delete = true;
                }
                else
                {
                    btnDelete.Hide();
                    delete = false;
                }
            }
        }
        

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public event EventHandler AddClick;
        public event EventHandler EditClick;
        public event EventHandler DeleteClick;
        public event EventHandler DetailClick;

        public DataTable Data
        {
            get { return grvData.DataSource as DataTable; }
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailClick?.Invoke(this, e);
        }
    }
}