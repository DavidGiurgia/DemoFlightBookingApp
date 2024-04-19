using Flight.DataAccess;
using Flight.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public partial class EditFlightPanelControl : UserControl
    {
        FlightModel flight;
        FlightRepository flightRepository;
        public EditFlightPanelControl()
        {
            InitializeComponent();
            flight = MainForm.currentFlight;
            flightRepository = new FlightRepository();
        }

        private void EditFlightPanelControl_Load(object sender, EventArgs e)
        {
            tbOrigin.Text = flight.From;
            tbDestination.Text = flight.To;
            dateTimePickerDate.Value = flight.Date;
            numericUpDownPrice.Value = flight.Price;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.Dashboard);
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            EditExistingFlight();
        }
        private void EditExistingFlight()
        {
            var flightModel = new FlightModel()
            {
                Id = flight.Id,
                From = tbOrigin.Text,
                To = tbDestination.Text,
                Date = dateTimePickerDate.Value,
                Price = (int)numericUpDownPrice.Value
            };
            var dr = MessageBox.Show($"Are you sure you want to save: {flightModel}", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (flightRepository.Update(flightModel) != null)
                {
                    MessageBox.Show("FLight saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm.NextPanel(PanelType.Dashboard);
                }
                else
                {
                    MessageBox.Show("Failed to save the flight! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (tbDestination.Text == "Destination" || tbOrigin.Text == "Origin")
            {
                lblWarning.Text = "Please type a valid location or fill all required fields";
                lblWarning.Visible = true;
                return false;
            }
            if (string.IsNullOrEmpty(tbDestination.Text) || string.IsNullOrEmpty(tbOrigin.Text))
            {
                lblWarning.Text = "Please fill all required fields";
                lblWarning.Visible = true;
                return false;
            }
            if (dateTimePickerDate.Value < DateTime.UtcNow)
            {
                lblWarning.Text = "The date cannot be in the past";
                lblWarning.Visible = true;
                return false;
            }
            if (numericUpDownPrice.Value < 0)
            {
                lblWarning.Text = "The price must be a positive number";
                lblWarning.Visible = true;
                return false;
            }
            return true;
        }
    }
}
