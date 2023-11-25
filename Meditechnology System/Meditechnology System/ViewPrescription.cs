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
		}
        private void SendSaveBtn_Click(object sender, EventArgs e)
        {
            DoctorScreen doctorScreen = new DoctorScreen();
            doctorScreen.Show();
            this.Close();
        }

		private void backBtn_Click(object sender, EventArgs e)
		{
			Prescription pres = new Prescription();
			
			pres.Show();
			this.Close();
		}

        public void SetFromPresScription(Prescription Pres) {
            FromPrescriptionInstance = Pres;
		}
	
		private void presLBL_Click(object sender, EventArgs e)
		{

		}
	}
}
