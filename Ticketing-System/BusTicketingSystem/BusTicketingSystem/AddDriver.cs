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
    public partial class AddDriver : Form
    {
        Drivers Drivers = new Drivers();

        private SubUrbQueryClass SubUrbQuery;

        public string DriverName, Address;
        public long ContactNum, license;
        public AddDriver()
        {
            InitializeComponent();
        }
        private void AddDriver_Load(object sender, EventArgs e)
        {
            SubUrbQuery = new SubUrbQueryClass();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DriverName = txtDriverName.Text;
            Address = txtAddress.Text;
            ContactNum = Convert.ToInt64(txtContactNo.Text);
            license = Convert.ToInt64(txtLicense.Text);
            SubUrbQuery.addDriver(DriverName, Address, ContactNum, license);

            MessageBox.Show("Successfully Added!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void RefreshDriverList()
        {
            SubUrbQuery.DisplayDriverList();
            Drivers.dgvDrivers.DataSource = SubUrbQuery.bindingSource;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
