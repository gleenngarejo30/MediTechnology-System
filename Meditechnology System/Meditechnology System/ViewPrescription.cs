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
			presLBL.Text = prescriptionDetails.getReserved();
			prescriptionList.Refresh();

			//DataGridView
            prescriptionList.DataSource = prescriptionDetails.getDataGrid();

            //reference number
            ReferenceLBL.Text = SqlQueries.ViewPrescriptionID().ToString();

			//Name and ID
            PatientNameLBL.Text = prescriptionDetails.getPatientName();
			PatientIDLBL.Text = prescriptionDetails.getPatientID();

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
                remarksLB.Items.Add(prescriptionDetails.medRemarks);

        }
		private void backBtn_Click(object sender, EventArgs e)
		{
			showPrescription();
			this.Hide();
		}
		private void SendSaveBtn_Click(object sender, EventArgs e)
		{
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
