using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.Model
{
    public abstract class State
    {
        public int Id { get; set; }
        public static User currentUser { get; set; }
        public abstract UserControl GetPanelControl();
    }

}
