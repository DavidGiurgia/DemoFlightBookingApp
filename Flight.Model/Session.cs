using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Flight.Model
{
    public class Session
    {
        public Dictionary<PanelType, State> _states;
        public Dictionary<Key, PanelType> _transitions;

        private State _currentState;

        private UserControl _currentPanel;
        private Form _mainForm;


        public Session(Form form)
        {
            _states = new Dictionary<PanelType, State>();
            _transitions = new Dictionary<Key, PanelType>();

            _mainForm = form;
        }
        public void AddPanel(State s, PanelType type)
        {
            _states.Add(type, s);
        }

        public void StartSession(PanelType initialPanel)
        {
            _currentPanel = _states[initialPanel].GetPanelControl();

            _currentState = _states[initialPanel];

            SwitchPanel(_currentPanel);
        }
        public void Next(int choice)
        {
            _currentState = _states[_transitions[new Key() { From = _currentState.Id, Choice = choice }]];

            var nextState = _currentState.GetPanelControl();

            SwitchPanel(nextState);
        }
        public void SwitchPanel(UserControl nextPanel)
        {
            _mainForm.Controls.Remove(_currentPanel);
            _currentPanel = nextPanel;

            _mainForm.Controls.Add(_currentPanel);
        }
        public void AddTransition(PanelType from, int choice, PanelType to)
        {
            var key = new Key()
            {
                From = (int)from,
                Choice = choice
            };

            if (!_transitions.ContainsKey(key))
            {
                _transitions.Add(key, to);
            }
        }
    }
}


