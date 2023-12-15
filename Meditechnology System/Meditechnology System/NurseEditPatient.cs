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
    public partial class NurseEditPatient : Form
    {
        public NurseEditPatient()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            NurseScreen nurseScreen = new NurseScreen();
            nurseScreen.Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int refnum = Convert.ToInt32(refNumTXT.Text);

            SqlDataReader reader = SqlQueries.PatientEditRead(refnum);
            if (reader.Read())
            {

                LastNameTxtBox.Text = reader["lastName"].ToString();
                FirstNameTxtBox.Text = reader["firstname"].ToString();
                MiddleNameTxtName.Text = reader["middlename"].ToString();
                EmailTxtBox.Text = reader["email"].ToString();
                ContactTxtBox.Text = reader["contactNum"].ToString();
                AgeTxtBox.Text = reader["age"].ToString();
                string sex = reader["sex"].ToString();

                if (sex == "Male")
                {
                    MaleRB.Checked = true;
                }
                else if (sex == "Female")
                {
                    FemaleRB.Checked = true;
                }
            }

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
                string.IsNullOrEmpty(MiddleNameTxtName.Text) || string.IsNullOrEmpty(AgeTxtBox.Text) ||
                string.IsNullOrEmpty(EmailTxtBox.Text) || string.IsNullOrEmpty(AgeTxtBox.Text) || sex == "")
            {
                MessageBox.Show("Incomplete Details!");
            }
            else
            {
                int refnum = Convert.ToInt32(refNumTXT.Text);
                fName = FirstNameTxtBox.Text.ToString();
                lName = LastNameTxtBox.Text.ToString();
                mName = MiddleNameTxtName.Text.ToString();
                age = Convert.ToInt32(AgeTxtBox.Text);
                email = EmailTxtBox.Text.ToString();
                contactnum = ContactTxtBox.Text.ToString();
                SqlQueries.PatientUpdate(refnum, fName, lName, mName, age, sex, email, contactnum);
                MessageBox.Show("Patient Updated!");
                NurseScreen nurseScreen = new NurseScreen();
                nurseScreen.Show();
                this.Hide();
            }
        }
    }
}
