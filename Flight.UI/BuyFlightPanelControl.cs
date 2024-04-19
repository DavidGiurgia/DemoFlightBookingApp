using Flight.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Flight.UI
{
    public partial class BuyFlightPanelControl : UserControl
    {
        CultureInfo englishCulture;
        FlightModel flight;
        public BuyFlightPanelControl()
        {
            InitializeComponent();
            englishCulture = new CultureInfo("en-US");
            flight = MainForm.currentFlight;
        }

        private void BuyFlightPanelControl_Load(object sender, EventArgs e)
        {
            string formatDate = flight.Date.ToString("dddd, dd MMMM yyyy", englishCulture);
            labelDate.Text = formatDate;
            lblFlightInfo.Text = flight.ToString();
            lblPrice.Text = flight.Price + "\u20AC";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.Dashboard);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateInput()) MainForm.NextPanel(PanelType.ReserveSeat);
        }
        private bool ValidateInput()
        {
            if (tbName.Text == string.Empty || tbPhone.Text == string.Empty || tbCNP.Text == string.Empty)
            {
                MessageBox.Show("Please fill all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
}
