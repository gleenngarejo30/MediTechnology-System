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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }
        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            this.Hide();
        }

		private void prescriptionBTN_Click(object sender, EventArgs e)
		{
			string refnum = "";
			string name = "";

            if (NametxtBox.Text.Equals("")) {
                MessageBox.Show("doctor screen");
            }
            else{
                refnum = refNumTXT.Text.ToString();
                prescriptionDetails.setPatientID(refnum);
                name = NametxtBox.Text.ToString();
                prescriptionDetails.setPatientName(name);
                var pres = new Prescription();
                pres.Show();
                this.Hide();
			}
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
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchname;
            int searchrefnum;
            try
            {
                searchname = NametxtBox.Text.ToString();
                searchrefnum = Convert.ToInt32(refNumTXT.Text.ToString());
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                dataGridView1.DataSource = SqlQueries.DoctorScreenPatientSelectQuery(searchname, searchrefnum);
            }
            catch(FormatException) {
                searchname = NametxtBox.Text.ToString();
                searchrefnum = 0;
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                dataGridView1.DataSource = SqlQueries.DoctorScreenPatientSelectQuery(searchname, searchrefnum);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.Value != null)
            {
                NametxtBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                refNumTXT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
