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
    public partial class AddFlightPanelControl : UserControl
    {
        FlightRepository flightRepository;
        public AddFlightPanelControl()
        {
            InitializeComponent();
            flightRepository = new FlightRepository();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            AddNewFlight();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.Dashboard);
        }
        private bool ValidateInput()
        {
            if(tbDestination.Text == "Destination" || tbOrigin.Text == "Origin")
            {
                lblWarning.Text = "Please type a valid location or fill all required fields";
                lblWarning.Visible = true;
                return false;
            }
            if(string.IsNullOrEmpty(tbDestination.Text) || string.IsNullOrEmpty(tbOrigin.Text))
            {
                lblWarning.Text = "Please fill all required fields";
                lblWarning.Visible = true;
                return false;
            }
            if(dateTimePickerDate.Value < DateTime.UtcNow)
            {
                lblWarning.Text = "The date cannot be in the past";
                lblWarning.Visible = true;
                return false;
            }
            if(numericUpDownPrice.Value < 0) 
            {
                lblWarning.Text = "The price must be a positive number";
                lblWarning.Visible = true;
                return false;
            }
            return true;
        }
        private void AddNewFlight()
        {
            var flightModel = new FlightModel()
            {
                From = tbOrigin.Text,
                To = tbDestination.Text,
                Date = dateTimePickerDate.Value,
                Price = (int)numericUpDownPrice.Value
            };
            var dr = MessageBox.Show($"Are you sure you want to add: {flightModel}", "New Flight", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if (flightRepository.Create(flightModel) != null)
                {
                    MessageBox.Show("FLight added successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add the flight! Please try again");
                }
            }
            else
            {
                return;
            }
            
        }
        private void ClearFields()
        {
            tbDestination.Text = string.Empty;
            tbOrigin.Text = string.Empty;
            dateTimePickerDate.Value = DateTime.Now;
            numericUpDownPrice.Value = 0;
        }
    }
}
