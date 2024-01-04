using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class AddTrip : Form
    {
        public AddTrip()
        {
            InitializeComponent();
        }


        private void btnAddtrip_Click(object sender, EventArgs e)
        {

        } 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtBusType.Clear();
            txtDate.Clear();
            txtDeparture.Clear();
            txtDestinationTo.Clear();
            txtDestinationWhere.Clear();
            txtFare.Clear();

            txtBusType.Focus();
        }
    }
}
