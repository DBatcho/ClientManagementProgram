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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CustomerRecordsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openform = new CustomerRecordsForm();
            openform.Show();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openform = new AppointmentsForm();
            openform.Show();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openform = new CalendarForm();
            openform.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
