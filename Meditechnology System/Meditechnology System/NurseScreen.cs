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
	public partial class NurseScreen : Form
	{
		public NurseScreen()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			showLogin();
			this.Hide();
		}
		private void NurseScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			showLogin();
		}
		public static void showLogin() {
			var form1 = new Form1();
			form1.Show();
		}

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
			AddPatient addPatient = new AddPatient();
			addPatient.Show();
			this.Hide();
        }
    }
}
