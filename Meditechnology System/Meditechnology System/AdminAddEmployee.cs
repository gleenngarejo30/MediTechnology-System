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
	public partial class AdminAddEmployee : Form
	{
		public AdminAddEmployee()
		{
			InitializeComponent();
		}

		private void RegisterBtn_Click(object sender, EventArgs e)
		{
            string fName, lName, mName, email, contactnum, occupation, username, password;
            int age;
            string sex = "";
            string status = "OFFLINE";

            if (MaleRB.Checked)
            {
                sex = "Male";
            }
            else if (FemaleRB.Checked)
            {
                sex = "Female";
            }
            if (string.IsNullOrEmpty(TypeEmpCB.Text) || string.IsNullOrEmpty(UserNameTxtBox.Text) ||
                string.IsNullOrEmpty(PasswordTxtBox.Text) || string.IsNullOrEmpty(LNameTxtBox.Text) ||
                string.IsNullOrEmpty(FNameTxtBox.Text) || string.IsNullOrEmpty(MNameTxtBox.Text) ||
                string.IsNullOrEmpty(AgeTxtBox.Text) || string.IsNullOrEmpty(ContactNumTxtBox.Text) ||
                string.IsNullOrEmpty(textBox1.Text) || sex == "")
            {
                MessageBox.Show("Incomplete Details!");
            }
            else
            {
                occupation = TypeEmpCB.Text.ToString();
                username = UserNameTxtBox.Text.ToString();
                password = PasswordTxtBox.Text.ToString();
                lName = LNameTxtBox.Text.ToString();
                fName = FNameTxtBox.Text.ToString();
                mName = MNameTxtBox.Text.ToString();
                age = Convert.ToInt32(AgeTxtBox.Text);
                contactnum = ContactNumTxtBox.Text.ToString();
                email = textBox1.Text.ToString();

                SqlQueries.AdminAddEmployeeQuery(fName, lName, mName, age, sex, email, contactnum, occupation, username, password, status);
                MessageBox.Show("Patient Register, Proceed to Doctor!");
                Adminstrator adminstrator = new Adminstrator();
                adminstrator.Show();
                this.Hide();
            }
        }

		private void AdminAddEmployee_FormClosed(object sender, FormClosedEventArgs e)
		{
			var adminAccounts = new AdminAccounts();
			adminAccounts.Show();
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var adminAccounts = new AdminAccounts();
            adminAccounts.Show();
            this.Hide();
        }
    }
}
