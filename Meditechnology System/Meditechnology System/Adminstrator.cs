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
            this.Close();
        }

        private void ViewEmploteeBtn_Click(object sender, EventArgs e)
        {
            AdminViewEmployee ViewEmployees = new AdminViewEmployee();
            ViewEmployees.Show();
            this.Close();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            AdministratorHistory adminHistory = new AdministratorHistory();
            adminHistory.Show();
            this.Close();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
