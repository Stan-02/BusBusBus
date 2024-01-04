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
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suburb Ticket", 400, 300);
            printPreviewDialog1.ShowDialog();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Suburb Transit Ticket", new Font("Stencil", 14), Brushes.DeepSkyBlue, new Point(10, 10));
            e.Graphics.DrawString("Name: " + txtpsName.Text, new Font("Centuary", 12), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString("Contact No.: " + txtpsContact.Text, new Font("Centuary", 12), Brushes.Black, new Point(10, 80));
            e.Graphics.DrawString("Trip: " + cmbpsTrip.Text, new Font("Centuary", 12), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString("Bus Type: " + cbtickBusType.Text, new Font("Centuary", 12), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Bus No.: " + txtBusNo, new Font("Centuary", 12), Brushes.Black, new Point(10, 140));
            e.Graphics.DrawString("Departure: " + dtppsDep.Text, new Font("Centuary", 12), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("Fare: " + txtpsFare.Text, new Font("Centuary", 12), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("Ticket ID: " + txtpsTicket.Text, new Font("Centuary", 12), Brushes.Black, new Point(10, 200));
        }

        private void txtpsContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
