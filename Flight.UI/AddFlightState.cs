using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public class AddFlightState : State
    {
        public AddFlightState()
        {
            Id = 2;
        }
        public override UserControl GetPanelControl()
        {
            return new AddFlightPanelControl();
        }
    }
}
