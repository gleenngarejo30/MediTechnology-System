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
        private void NurseScreen_Load(object sender, EventArgs e)
        {
			foreach (DataRow dr in SqlQueries.NurseScreenLoadQuery().Rows)
			{
				comboBox1.Items.Add(dr["FullName"].ToString());
			}
        }

        private void button3_Click(object sender, EventArgs e)
		{
			EmployeeDetails.toOffline();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectname = comboBox1.Text.ToString();
            string[] splitname = selectname.Split(' ');
			string getfirstname = splitname[0];

            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = SqlQueries.NurseScreenSelectQuery(getfirstname);

        }

        private void EditPatientBtn_Click(object sender, EventArgs e)
        {
			NurseEditPatient editPatient = new NurseEditPatient();	
			editPatient.Show();
			this.Hide();
        }
    }
}
