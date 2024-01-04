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
    public partial class Stations : Form
    {
        public Stations()
        {
            InitializeComponent();
        }

        private void btnAddStations_Click(object sender, EventArgs e)
        {
            new AddStation().ShowDialog();
        }
    }
}
