using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meditechnology_System
{
    public partial class PharmacyScreen : Form
    {
        public PharmacyScreen()
        {
            InitializeComponent();
        }
		private void LogoutBtn_Click(object sender, EventArgs e)
		{
			showLogin();
			this.Hide();
		}
		private void PharmacyScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			showLogin();
		}
        public static void showLogin() {
			var login = new Form1();
			login.Show();
		}
	}
}
