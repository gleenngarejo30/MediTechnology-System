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
    public partial class Prescription : Form
    {
        static Boolean isAvailable = false;
        static int quan;
		public static int numMeds;
		public Prescription()
		{
			InitializeComponent();
		}
		private void Prescription_Load(object sender, EventArgs e)
		{
			patientNameLBL.Text = prescriptionDetails.getPatientName();
		}
		private void reserveBTN_Click(object sender, EventArgs e)
		{
			prescriptionDetails.setReserved(true);
			var prescription = new ViewPrescription();
			this.Hide();
			prescription.Show();


		}
		private void prescribeBtn_Click(object sender, EventArgs e)
		{
			prescriptionDetails.setReserved(false);
			ViewPrescription viewPrescription = new ViewPrescription();
			viewPrescription.Show();
			this.Hide();
		}
        private void BackBtn_Click(object sender, EventArgs e)
        {
            DoctorScreen doc = new DoctorScreen();
            doc.Show();
            this.Hide();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            quan = Convert.ToInt32(QuantityLBL.Text);

            if(quan >= Convert.ToInt32(quantityTB.Text))
                isAvailable = true;
            else
				isAvailable = false;

			DataGridViewRow row = (DataGridViewRow)prescriptionList.Rows[0].Clone();
            row.Cells[0].Value = medCB.Text;
            row.Cells[1].Value = quantityTB.Text;
            row.Cells[2].Value = isAvailable;

			prescriptionList.Rows.Add(row);
        }
		

		private void removeBTN_Click(object sender, EventArgs e){
			foreach (DataGridViewRow item in this.prescriptionList.SelectedRows)
			{
				prescriptionList.Rows.RemoveAt(item.Index);
			}
		}
		
	}
}
