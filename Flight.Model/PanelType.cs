using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public enum PanelType
    {
        Login = 1,
        Register = 12,
        Dashboard = 13,
        AddFlights = 2,
        EditFlight = 3,
        RemoveFlight = 10,
        BuyFlight = 5,
        ReserveSeat = 8,
        GetHelp = 9
    }
}
