using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public class HelpState : State
    {
        public HelpState()
        {
            Id = 9;
        }
        public override UserControl GetPanelControl()
        {
            return new HelpPanelControl();
        }
    }
}
