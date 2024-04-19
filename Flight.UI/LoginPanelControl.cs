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
    public partial class LoginPanelControl : UserControl
    {
        UserRepository userRepository;
        
        public LoginPanelControl()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            User user = userRepository.ValidateLogin(tbUsername.Text, tbPassword.Text);

            if (user != null)
            {
                State.currentUser = user;

                MainForm.NextPanel(PanelType.Dashboard);
            }
            else
            {
                MessageBox.Show("Seems there's an issue with the login credentials. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.Register);
        }
        private bool ValidateInput()
        {
            if (tbUsername.Text == string.Empty || tbPassword.Text == string.Empty)
            {
                MessageBox.Show("Please fill all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tbPassword.Text.Count() < 4)
            {
                MessageBox.Show("Password must be at least 4 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
