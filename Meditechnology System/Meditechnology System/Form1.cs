using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meditechnology_System
{
    public partial class Form1 : Form
    {
		public static Boolean isShown = false;
        public Form1()
        {
            InitializeComponent();
        }
		private void Form1_Load(object sender, EventArgs e)
		{
			//Username
			UsernameTxtBox.ForeColor = SystemColors.GrayText;
			UsernameTxtBox.Text = "Username";
				this.UsernameTxtBox.Leave += new System.EventHandler(this.UsernameTxtBox_Enter);
				this.UsernameTxtBox.Enter += new System.EventHandler(this.UsernameTxtBox_Leave);
			//Password
			PasswordTxtBox.ForeColor = SystemColors.GrayText;
			PasswordTxtBox.Text = "Password";
				this.PasswordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Enter);
				this.PasswordTxtBox.Enter += new System.EventHandler(this.PasswordTxtBox_Leave);
		}
		//Username
		private void UsernameTxtBox_Enter(object sender, EventArgs e)
		{
			if (UsernameTxtBox.Text.Length == 0)
			{
				UsernameTxtBox.Text = "Username";
				UsernameTxtBox.ForeColor = SystemColors.GrayText;
			}
		}
		private void UsernameTxtBox_Leave(object sender, EventArgs e)
		{
			if (UsernameTxtBox.Text == "Username")
			{
				UsernameTxtBox.Text = "";
				UsernameTxtBox.ForeColor = SystemColors.WindowText;
			}
		}
		//Password
		private void PasswordTxtBox_Enter(object sender, EventArgs e)
		{
			if (PasswordTxtBox.Text.Length == 0)
			{
				PasswordTxtBox.PasswordChar = '\0';
				PasswordTxtBox.Text = "Password";
				PasswordTxtBox.ForeColor = SystemColors.GrayText;
			}
		}
		private void PasswordTxtBox_Leave(object sender, EventArgs e)
		{
			if (PasswordTxtBox.Text == "Password")
			{
				PasswordTxtBox.PasswordChar = '•';
				PasswordTxtBox.Text = "";
				PasswordTxtBox.ForeColor = SystemColors.WindowText;
			}
		}
		//show password
		private void showPassBTN_Click(object sender, EventArgs e){
			//avoid on setting passChar on hint
			if (!PasswordTxtBox.Text.Equals("Password")) {
				//hide
				if (isShown == true)
				{
					PasswordTxtBox.PasswordChar = '•';
					showPassBTN.BackgroundImage = Properties.Resources.cross_eye_icon;
					isShown = false;
				}
				//show
				else if (isShown == false)
				{
					PasswordTxtBox.PasswordChar = '\0';
					showPassBTN.BackgroundImage = Properties.Resources.eye_icon;
					isShown = true;
				}
			}
		}
		private void LoginBtn_Click(object sender, EventArgs e)
		{
            string username = UsernameTxtBox.Text.ToString();
			string password = PasswordTxtBox.Text.ToString();

            SqlDataReader exe = SqlQueries.LoginQuery(username, password);

            if (exe.Read())
			{
				//setID
				int employeeID = exe.GetInt32(0);
				prescriptionDetails.setemployeeID(employeeID);

				//setName
				string employeeName = SqlQueries.LoginUserNameQuery(employeeID);
				prescriptionDetails.setemployeeName(employeeName);


				//setOccupation
				string occupation = SqlQueries.LoginOccupationQuery(employeeID);

                //if Admin
                if (occupation.Equals("Admin"))
				{
					var admin = new Adminstrator();
					this.Hide();
					admin.Show();
				}
				//if Doctor
				else if (occupation.Equals("Doctor"))
				{
					var doctor = new DoctorScreen();
					this.Hide();
					doctor.Show();
				}
				//if Inventory Manager
				else if (occupation.Equals("Inventory"))
				{
					var inventory = new InventoryScreen();
					this.Hide();
					inventory.Show();
				}
				//if Pharmacy
				else if (occupation.Equals("Pharmacy"))
				{
					var pharmacy = new PharmacyScreen();
					this.Hide();
					pharmacy.Show();
				}
				//if nurse
				else if (occupation.Equals("Nurse"))
				{
					var nurse = new NurseScreen();
					this.Hide();
					nurse.Show();
				}
				//if wala
				else
				{
					MessageBox.Show("Employee not Register");
				}
			}
			else
			{
                MessageBox.Show("Wrong username or password");
            }
		}
		private void UsernameTxtBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				PasswordTxtBox.Focus();
			}
		}
		private void PasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter) {
				LoginBtn_Click(sender, e);
			}
		}
		//EXIT
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
            Environment.Exit(0);
		}
    }
}
