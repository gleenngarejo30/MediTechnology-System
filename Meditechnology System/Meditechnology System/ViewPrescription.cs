using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meditechnology_System
{
    public partial class ViewPrescription : Form
    {
        private Prescription FromPrescriptionInstance;
        public ViewPrescription()
        {
            InitializeComponent();
        }

		private void ViewPrescription_Load(object sender, EventArgs e)
		{
			
			prescriptionList.Refresh();

			//DataGridView
            prescriptionList.DataSource = prescriptionDetails.getDataGrid();

            //reference number
            ReferenceLBL.Text = SqlQueries.ViewPrescriptionID().ToString();

			//Name and ID
            PatientNameLBL.Text = prescriptionDetails.getPatientName();
			PatientIDLBL.Text = prescriptionDetails.getPatientID();

            //Doctor Name and PhoneNum
            DoctorNameLBL.Text = prescriptionDetails.getemployeeName();
            int employeeID = prescriptionDetails.getemployeeID();
            DoctorContactNumberLBL.Text = SqlQueries.ViewPrescriptionContactNum(employeeID);

            //Age and Sex
            SqlDataReader sr = SqlQueries.ViewPrescriptionPatientInfo(prescriptionDetails.getPatientID());
            if (sr.Read())
            {
                AgeLBL.Text = sr["age"].ToString();
				SexLBL.Text = sr["sex"].ToString();
            }

			//Date
			DateLBL.Text = DateTime.Now.ToString("yyyy-MM-dd");

			//Remarks
			ArrayList arr = prescriptionDetails.getRemarks();
            foreach (var item in arr)
            {
                remarksLB.Items.Add(item);
            }
        }
		private void backBtn_Click(object sender, EventArgs e)
		{
			showPrescription();
			this.Hide();
		}
		private void SendSaveBtn_Click(object sender, EventArgs e)
		{
			int referencenum = SqlQueries.ViewPrescriptionID();
			int patientnum = Convert.ToInt32(PatientIDLBL.Text);
			string doctorContactnum = DoctorContactNumberLBL.Text.ToString();
            string date = DateLBL.Text.ToString();
			string age = AgeLBL.Text.ToString();
            string isReserved, isActive;

            if (prescriptionDetails.getReserved())
            {
                isReserved = "TRUE";
                isActive = "TRUE";
            }
            else
            {
                isReserved = "FALSE";
                isActive = "FALSE";
            }

            //remarks
            StringBuilder remarks = new StringBuilder();

            foreach (var item in remarksLB.Items)
            {
                remarks.Append(item.ToString());
                remarks.Append('\t'); // Tab character
            }
            if (remarksLB.Items.Count > 0)
            {
                remarks.Length--; // Remove the last character (which is the last tab)
            }

            string allItems = remarks.ToString();

            //listMedicine
            int columnIndex = 0; // Index of the column you want to extract (zero-based index)
            int rowCount = prescriptionList.Rows.Count;

            object[] medicineValues = new object[rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                medicineValues[i] = prescriptionList.Rows[i].Cells[columnIndex].Value;
            }

            columnIndex = 1;
            rowCount = prescriptionList.Rows.Count;

            object[] quantityValues = new object[rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                quantityValues[i] = prescriptionList.Rows[i].Cells[columnIndex].Value;
            }

            SqlQueries.ViewPrescriptionTransferQuery(referencenum, patientnum, doctorContactnum, date, age, allItems, medicineValues, quantityValues, isReserved, isActive);

            DoctorScreen doctorScreen = new DoctorScreen();
            doctorScreen.Show();
            this.Hide();
        }

		private void ViewPrescription_FormClosed(object sender, FormClosedEventArgs e)
		{
			showPrescription();
		}
		public void SetFromPresScription(Prescription Pres) {
            FromPrescriptionInstance = Pres;
		}
		public static void showPrescription() {
			Prescription pres = new Prescription();
			pres.Show();
		}

        private void backIcon_Click(object sender, EventArgs e)
        {
            showPrescription();
            this.Hide();
        }
    }
}
