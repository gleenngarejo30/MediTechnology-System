using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                remarksTxtBox.KeyDown += remarksTxtBox_KeyDown;
        }

        private void PharmacyScreen_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in SqlQueries.PharmacyScreenLoadQuery().Rows)
            {
                refNumCB.Items.Add(dr["prescriptionID"].ToString());
            }

            foreach (DataRow dr in SqlQueries.PrescriptionMedicineLoadQuery().Rows)
            {
                medCB.Items.Add(dr["medName"].ToString());
            }
			System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
			timer1.Interval = (10 * 1000); // 10 secs
			timer1.Tick += new EventHandler(timer1_Tick);
			timer1.Start();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
            refNumCB.Items.Clear();
			medCB.Items.Clear();
			foreach (DataRow dr in SqlQueries.PharmacyScreenLoadQuery().Rows)
			{
				refNumCB.Items.Add(dr["prescriptionID"].ToString());
			}

			foreach (DataRow dr in SqlQueries.PrescriptionMedicineLoadQuery().Rows)
			{
				medCB.Items.Add(dr["medName"].ToString());
			}
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

        private void remarksTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Get the text from the remarksTxtBox
                string text = remarksTxtBox.Text;

                // Add the text to the ListBox
                listBox1.Items.Add(text);

                // Clear the remarksTxtBox for the next input
                remarksTxtBox.Clear();

                // Prevent the "ding" sound when Enter is pressed
                e.SuppressKeyPress = true;

                //clears the textbox
                remarksTxtBox.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Remove the last entered item in the ListBox
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }

        private void refNumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string remarks;
            int selectref = Convert.ToInt32(refNumCB.Text);
            SqlDataReader dr = SqlQueries.PharmacyScreenInfoLoadQuery(selectref);

            if (dr.Read())
            {
                patientNameTXT.Text = dr["fullname"].ToString();
                AgeLBL.Text = dr["age"].ToString();
                GENDERlbl.Text = dr["sex"].ToString();
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = SqlQueries.PharmacyScreenSelectGridViewQuery(selectref);

            SqlDataReader dr1 = SqlQueries.ReadDoctorRemarksQuery(selectref);
            if (dr1.Read())
            {
                remarks = dr1["doctorNotes"].ToString();
                string[] rmrk = remarks.Split('\t');
                MedicineListView.Items.AddRange(rmrk);

            }
            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    // Parse the cell value to a decimal and add to the total
                    total += Convert.ToDouble(row.Cells[3].Value);
                }
            }
            totalLBL.Text = total.ToString();


        }

        private void Processbtn_Click(object sender, EventArgs e)
        {

        }
	}
}
