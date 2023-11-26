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
    public partial class DoctorScreen : Form
    {
        public DoctorScreen()
        {
            InitializeComponent();
        }
        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            this.Hide();
        }

		private void prescriptionBTN_Click(object sender, EventArgs e)
		{
            prescriptionDetails.setPatientName(NametxtBox.Text);
            var prescription = new Prescription();
            prescription.Show();
            this.Hide();
		}
		private void DoctorScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			showLogin();
		}
		private void LogoutBtn_Click(object sender, EventArgs e)
		{
			showLogin();
			this.Hide();
		}
		public static void showLogin() {
			Form1 form1 = new Form1();
			form1.Show();
		}


	}
}
