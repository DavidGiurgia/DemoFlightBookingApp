using Flight.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public partial class MainForm : Form
    {
        private static Session session;
        public static FlightModel currentFlight {  get; set; }
        public MainForm()
        {
            InitializeComponent();
            session = new Session(this);
            InitializePanels();

            session.StartSession(PanelType.Login);
        }
        public void InitializePanels()
        {
            session.AddPanel(new LoginState(), PanelType.Login);
            session.AddPanel(new RegisterState(), PanelType.Register);
            session.AddPanel(new DashboardState(), PanelType.Dashboard);
            session.AddPanel(new AddFlightState(), PanelType.AddFlights);
            session.AddPanel(new RemoveFLightState(), PanelType.RemoveFlight);
            session.AddPanel(new HelpState(), PanelType.GetHelp);
            session.AddPanel(new EditFlightState(), PanelType.EditFlight);
            session.AddPanel(new BuyFlightState(), PanelType.BuyFlight);
            session.AddPanel(new ReserveSeatState(), PanelType.ReserveSeat);

            session.AddTransition(PanelType.Login, 12, PanelType.Register);
            session.AddTransition(PanelType.Register, 1, PanelType.Login);

            //from dashboard
            session.AddTransition(PanelType.Dashboard, 1, PanelType.Login);
            session.AddTransition(PanelType.Dashboard, 2, PanelType.AddFlights);
            session.AddTransition(PanelType.Dashboard, 10, PanelType.RemoveFlight);
            session.AddTransition(PanelType.Dashboard, 9, PanelType.GetHelp);
            session.AddTransition(PanelType.Dashboard, 3, PanelType.EditFlight);
            session.AddTransition(PanelType.Dashboard, 5, PanelType.BuyFlight);

            //to dashboard
            session.AddTransition(PanelType.Login, 13, PanelType.Dashboard);
            session.AddTransition(PanelType.AddFlights, 13, PanelType.Dashboard);
            session.AddTransition(PanelType.RemoveFlight, 13, PanelType.Dashboard);
            session.AddTransition(PanelType.GetHelp, 13, PanelType.Dashboard);
            session.AddTransition(PanelType.EditFlight, 13, PanelType.Dashboard);
            session.AddTransition(PanelType.BuyFlight, 13, PanelType.Dashboard);
            session.AddTransition(PanelType.ReserveSeat, 13, PanelType.Dashboard);

            session.AddTransition(PanelType.BuyFlight, 8, PanelType.ReserveSeat);
        }

        internal static void NextPanel(PanelType choice)
        {
            session.Next((int)choice);
        }
    }
}
