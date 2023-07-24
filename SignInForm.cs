using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            SignInButton.Enabled = allowsignin();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openform = new MainForm();
            openform.Show();
        }
        
        private bool allowsignin()
        {
            return !string.IsNullOrWhiteSpace(UserNameTB.Text) &&
                !string.IsNullOrWhiteSpace(PasswordTB.Text);
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            SignInButton.Enabled = allowsignin();
        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {
            SignInButton.Enabled = allowsignin();
        }
    }
}
