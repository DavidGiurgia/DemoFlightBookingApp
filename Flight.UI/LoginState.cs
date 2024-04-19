using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public class LoginState : State
    {
        LoginPanelControl loginPanelControl;
        public LoginState()
        {
            Id = 1;
            loginPanelControl = new LoginPanelControl();
        }

        public override UserControl GetPanelControl()
        {
            return loginPanelControl;
        }
    }
}
