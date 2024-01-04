using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BusTicketingSystem
{
    public partial class AddStation : Form
    {
        private SubUrbQueryClass SubUrbQuery;
        private string station;
        public AddStation()
        {
            InitializeComponent();
        }
        private void AddStation_Load(object sender, EventArgs e)
        {
            SubUrbQuery = new SubUrbQueryClass();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            station = txtStation.Text;
            SubUrbQuery.addStation(station);

            MessageBox.Show("Successfully Added!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void Clear()
        {
            txtBusType.Clear();
            txtCapacity.Clear();
            txtBusNo.Clear();
            txtPlateNo.Clear();
            txtBusType.Focus();
        }

    }
}
