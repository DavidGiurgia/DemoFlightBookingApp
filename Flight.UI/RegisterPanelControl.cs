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
    public partial class RegisterPanelControl : UserControl
    {
        private UserRepository _userRepository;
        public RegisterPanelControl()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm.NextPanel(PanelType.Login);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            User newUser = new User()
            {
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                Role = Role.Client,
            };

            if (_userRepository.Create(newUser) != null)
            {
                MessageBox.Show("Registered successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm.NextPanel(PanelType.Login);
            }
            else
            {
                MessageBox.Show("Username already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool ValidateInput()
        {
            if(tbUsername.Text == string.Empty || tbPassword.Text == string.Empty || tbConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("Please fill all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                MessageBox.Show("Passwords don't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(tbPassword.Text.Count() < 4)
            {
                MessageBox.Show("Password must be at least 4 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
