﻿using System;
using System.Collections;
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
                refNumLB.Items.Add(dr["prescriptionID"].ToString());
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
            refNumLB.Items.Clear();
			medCB.Items.Clear();
			foreach (DataRow dr in SqlQueries.PharmacyScreenLoadQuery().Rows)
			{
				refNumLB.Items.Add(dr["prescriptionID"].ToString());
			}

			foreach (DataRow dr in SqlQueries.PrescriptionMedicineLoadQuery().Rows)
			{
				medCB.Items.Add(dr["medName"].ToString());
			}
		}
		private void LogoutBtn_Click(object sender, EventArgs e)
		{
            EmployeeDetails.toOffline();
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
                remarksLB.Items.Add(text);

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
            if (remarksLB.Items.Count > 0)
            {
                remarksLB.Items.RemoveAt(remarksLB.Items.Count - 1);
            }
        }
		private void refNumLB_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (!refNumLB.Text.Equals("")) {
                refNumLBL.Text = refNumLB.SelectedItem.ToString();
				MedicineListView.Items.Clear();
				remarksLB.Items.Clear();
				string remarks, medsAndQuan;
				int selectref = Convert.ToInt32(refNumLB.Text);
				SqlDataReader dr = SqlQueries.PharmacyScreenInfoLoadQuery(selectref);

				if (dr.Read())
				{
					patientNameTXT.Text = dr["fullname"].ToString();
					AgeLBL.Text = dr["age"].ToString();
					GENDERlbl.Text = dr["sex"].ToString();
				}
				medicinelist.AutoGenerateColumns = true;
				medicinelist.DataSource = SqlQueries.PharmacyScreenSelectGridViewQuery(selectref);

				SqlDataReader dr1 = SqlQueries.ReadDoctorRemarksQuery(selectref);
				if (dr1.Read())
				{
					remarks = dr1["doctorNotes"].ToString();
					string[] rmrk = remarks.Split('\t');
					remarksLB.Items.AddRange(rmrk);
				}
				SqlDataReader dr2 = SqlQueries.PharmacyScreenPrecriptionListViewQuery(selectref);
				if (dr2.Read())
				{
					medsAndQuan = dr2["medName"].ToString() + ": " + dr2["quantity"].ToString();
					string[] rmrk = medsAndQuan.Split('\t');
					MedicineListView.Items.AddRange(rmrk);
				}
				double totalsum = 0;

				foreach (DataGridViewRow row in medicinelist.Rows)
				{
					if (row.Cells[2].Value != null)
					{
						// Parse the cell value to a decimal and add to the total
						totalsum += Convert.ToDouble(row.Cells[3].Value);
					}
				}
				totalLBL.Text = totalsum.ToString();
			}
		}
        private void Processbtn_Click(object sender, EventArgs e)
        {
            int selectref;
            if (refNumLBL.Text.Equals("- - - - - - -")) {
                prescriptionPro();
                MessageBox.Show("Transaction Complete.");
            }
			else{
                selectref = Convert.ToInt32(refNumLBL.Text);
                //SqlQueries.SubtractInventoryQuery(quantityValues, medicineValues);
                SqlQueries.PharmacyScreenPrescriptionProcess(selectref);
                MessageBox.Show("Transaction Complete.");
            }
            double gettotal = 0;

            timer1_Tick(sender, e);
            refNumLBL.Text = "- - - - - - -";
            MedicineListView.Items.Clear();
            medicinelist.DataSource = null;
            remarksLB.Items.Clear();

            foreach (DataGridViewRow row in medicinelist.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    // Parse the cell value to a decimal and add to the total
                    gettotal += Convert.ToDouble(row.Cells[3].Value);
                }
            }
            totalLBL.Text = gettotal.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string medname = medCB.Text.ToString();
            int quantity = Convert.ToInt32(textBox1.Text);
            double totalsum = 0;

            //REPLACE INSTEAD OF ADD, WHEN CLICKED TWICE DFFDLKGJFDKLMCV
            medicinelist.DataSource =  SqlQueries.ManualTransactionQuery(medname, quantity);

            foreach (DataGridViewRow row in medicinelist.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    // Parse the cell value to a decimal and add to the total
                    totalsum += Convert.ToDouble(row.Cells[3].Value);
                }
            }
            totalLBL.Text = totalsum.ToString();
        }
        public void prescriptionPro() {
            string prescriptionID = refNumLB.Text.ToString();
            int employeeID = prescriptionDetails.getemployeeID();

            StringBuilder remarks = new StringBuilder();

            foreach (var item in remarksLB.Items)
            {
                remarks.Append(item.ToString());
                remarks.Append('\t');
            }
            if (remarksLB.Items.Count > 0)
            {
                remarks.Length--;
            }

            string allItems = remarks.ToString();

            double total = Convert.ToInt32(totalLBL.Text);

            int columnIndex = 0; // Index of the column you want to extract (zero-based index)
            int rowCount = medicinelist.Rows.Count;

            object[] medicineValues = new object[rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                medicineValues[i] = medicinelist.Rows[i].Cells[columnIndex].Value;
            }

            columnIndex = 2;
            rowCount = medicinelist.Rows.Count;

            object[] quantityValues = new object[rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                quantityValues[i] = medicinelist.Rows[i].Cells[columnIndex].Value;
            }

            SqlQueries.PharmacyTransactionTBLQuery(prescriptionID, employeeID, allItems, total, medicineValues, quantityValues);
            SqlQueries.SubtractInventoryQuery(quantityValues, medicineValues);
        }

    }
}
