using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public class EditFlightState : State
    {
        public EditFlightState()
        {
            Id = 3;
        }
        public override UserControl GetPanelControl()
        {
            return new EditFlightPanelControl();
        }
    }
}
