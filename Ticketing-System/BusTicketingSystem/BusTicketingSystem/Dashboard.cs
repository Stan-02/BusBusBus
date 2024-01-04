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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

     
        public void load_form(object form)
        {
            if(this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            load_form(new Trips());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            load_form(new Trips());
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            load_form(new Passengers());
        }

        private void btnBusses_Click(object sender, EventArgs e)
        {
            load_form(new Busses());
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            load_form(new Drivers());
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            load_form(new Stations());
        }
    }
}
