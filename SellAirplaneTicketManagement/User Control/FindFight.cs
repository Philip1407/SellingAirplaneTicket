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
    public partial class FindFight : UserControl
    {
        public FindFight()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return dpkDate.Value.ToShortDateString(); }
            set
            {
                if (string.IsNullOrEmpty(value)) dpkDate.Text = DateTime.Today.ToShortDateString();
                else dpkDate.Text = value;
            }
        }

        public string Depart {
            get
            {
                if (cmbDepart.SelectedItem != null) return cmbDepart.SelectedItem.ToString();
                else return "";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbDepart.SelectedIndex = 0;
                else cmbDepart.SelectedIndex = cmbDepart.Items.IndexOf(value);
            }
        }

        public string Arrive {
            get
            {
                if (cmbArrive.SelectedItem != null) return cmbArrive.SelectedItem.ToString();
                else return "";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    cmbArrive.SelectedIndex = 0;
                else cmbArrive.SelectedIndex = cmbArrive.Items.IndexOf(value);
            }
        }

        public DataTable Data
        {
            get { return grvData.DataSource as DataTable; }
            set
            {
                grvData.DataSource = value;
            }
        }

        public DataGridView GridView
        {
            get { return grvData; }
            set { grvData = value; }
        }

        public ComboBox DepartList
        {
            get { return cmbDepart; }
            set { cmbDepart = value; }
        }

        public ComboBox ArriveList
        {
            get { return cmbArrive; }
            set { cmbArrive = value; }
        }


        public event EventHandler FindClick;

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindClick?.Invoke(this, e);
        }
    }
}
