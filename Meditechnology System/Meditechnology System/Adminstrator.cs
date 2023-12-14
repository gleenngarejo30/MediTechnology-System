using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meditechnology_System
{
    public partial class Adminstrator : Form
    {
        public Adminstrator()
        {
            InitializeComponent();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            AdminAccounts adminAccounts = new AdminAccounts();
            adminAccounts.Show();
            this.Hide();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            AdministratorHistory adminHistory = new AdministratorHistory();
            adminHistory.Show();
            this.Hide();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            EmployeeDetails.toOffline();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

		private void Adminstrator_FormClosed(object sender, FormClosedEventArgs e)
		{
            var login = new Form1();
            login.Show();
		}
	}
}
