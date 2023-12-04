using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Meditechnology_System
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

       

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            string fName, lName, mName, email, contactnum;
            int age;
            string sex = "";

            if (MaleRB.Checked)
            {
                sex = "Male";
            }
            else if (FemaleRB.Checked)
            {
                sex = "Female";
            }
            if (string.IsNullOrEmpty(FirstNameTxtBox.Text) || string.IsNullOrEmpty(LastNameTxtBox.Text) ||
                string.IsNullOrEmpty(MiddleNameTxtName.Text) || string.IsNullOrEmpty(ageNUD.Text) || 
                string.IsNullOrEmpty(EmailTxtBox.Text) || string.IsNullOrEmpty(ageNUD.Text) || sex == "")
            {
                MessageBox.Show("Incomplete Details!");
            }
            else
            {
                fName = FirstNameTxtBox.Text.ToString();
                lName = LastNameTxtBox.Text.ToString();
                mName = MiddleNameTxtName.Text.ToString();
                age = Convert.ToInt32(ageNUD.Text);
                email = EmailTxtBox.Text.ToString();
                contactnum = ContactTxtBox.Text.ToString();
                SqlQueries.AddPatientQuery(fName, lName, mName, age, sex, email, contactnum);
                MessageBox.Show("Patient Register, Proceed to Doctor!");
                NurseScreen nurseScreen = new NurseScreen();
                nurseScreen.Show();
                this.Hide();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            NurseScreen nurseScreen = new NurseScreen();
            nurseScreen.Show();
            this.Hide();
        }
    }
}
