using Flight.DataAccess;
using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace Flight.UI
{
    public partial class DashboardPanelControl : UserControl
    {
        FlightRepository flightRepository;
        List<FlightModel> flights;
        
        public DashboardPanelControl()
        {
            InitializeComponent();
            flightRepository = new FlightRepository();
            flights = flightRepository.GetAll();
        }
        private void SetRoleMode()
        {
            if(State.currentUser != null && State.currentUser.Role != Role.Admin)
            {
                btnAddFlights.Visible = false;
                btnAddFlights.Enabled = false;
            }
            else
            {
                btnAddFlights.Visible = true;
                btnAddFlights.Enabled = true;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.Login);
        }

        private void tbOrigin_Click(object sender, EventArgs e)
        {
            lblOrigin.Visible = false;
        }

        private void tbOrigin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOrigin.Text))
            {
                lblOrigin.Visible = true; 
            }
        }

        private void tbDestination_Click(object sender, EventArgs e)
        {
            lblDestination.Visible = false;
        }

        private void tbDestination_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDestination.Text))
            {
                lblDestination.Visible= true;
            }
        }

        private void DashboardPanelControl_Load(object sender, EventArgs e)
        {
            SetRoleMode();
            PopulateFlowLayoutPanelFlights(flights);
        }
        private void btnAddFlights_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.AddFlights);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.GetHelp);
        }
        private void PerformSearch()
        {
            string origin = CapitalizeFirstLetter(tbOrigin.Text);
            string destination = CapitalizeFirstLetter(tbDestination.Text);

            List<FlightModel> filteredFlights = flights
                                        .Where(f => f.From.Contains(origin) &&
                                                    f.To.Contains(destination))
                                        .ToList();

            PopulateFlowLayoutPanelFlights(filteredFlights);
        }
        private void PopulateFlowLayoutPanelFlights(List<FlightModel> flights)
        {
            flowLayoutPanelFlights.Controls.Clear();

            foreach (var flight in flights)
            {
                var currentFlightControl = new SearchResultControl(flight);

                flowLayoutPanelFlights.Controls.Add(currentFlightControl);
            }
        }
        private string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input; 
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        private void tbOrigin_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void tbDestination_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}
