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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //if Admin
            if (UsernameTxtBox.Text.Equals("admin")) {
                var admin = new Adminstrator();
                this.Hide();
                admin.Show();
            }
			//if Doctor
			if (UsernameTxtBox.Text.Equals("doctor"))
			{
				var doctor = new DoctorScreen();
				this.Hide();
				doctor.Show();
			}
			//if Inventory Manager
			if (UsernameTxtBox.Text.Equals("inventory"))
			{
				var inventory = new InventoryScreen();
				this.Hide();
				inventory.Show();
			}
			//if Pharmacy
            if (UsernameTxtBox.Text.Equals("pharmacy")) {
			var pharmacy = new PharmacyScreen();
			this.Hide();
				pharmacy.Show();
		}
	}

        private void UsernameTxtBox_TextChanged(object sender, EventArgs e)
        {
            //if Admin  form: Adminstator
            //if Doctor  form: DoctorScreen
            //if Inventory Manager  form: InventoryScreen
            //if Pharmacy  form: PharmacyScreen
        }

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
