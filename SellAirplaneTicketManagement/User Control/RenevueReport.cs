using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SellAirplaneTicketManagement.User_Control
{
    public partial class RenevueReport : UserControl
    {
        public RenevueReport()
        {
            InitializeComponent();
        }

        public string FromMonth
        {
            get
            {
                if (cmbMonth1.SelectedItem != null) return cmbMonth1.SelectedItem.ToString();
                else return "";
            }
            set { cmbMonth1.SelectedIndex = cmbMonth1.Items.IndexOf(value); }
        }

        public string ToMonth
        {
            get
            {
                if (cmbMonth2.SelectedItem != null) return cmbMonth2.SelectedItem.ToString();
                else return "";
            }
            set { cmbMonth2.SelectedIndex = cmbMonth2.Items.IndexOf(value); }
        }

        public Chart Data
        {
            get { return ChartData; }
            set { ChartData = value; }
        }

        public event EventHandler FromMonthChange;
        public event EventHandler ToMonthChange;

        private void cmbMonth1_TextChanged(object sender, EventArgs e)
        {
            FromMonthChange?.Invoke(this, e);
        }

        private void cmbMonth2_TextChanged(object sender, EventArgs e)
        {
            ToMonthChange?.Invoke(this, e);
        }
    }
}
