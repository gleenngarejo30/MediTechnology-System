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
			DataTable dataFromForm1 = GetDataGridViewData();
			pres.SetDataGridViewData2(dataFromForm1);
			pres.Show();
			this.Close();
		}

		private void presLBL_Click(object sender, EventArgs e)
		{

		}

        public void SetFromPresScription(Prescription Pres) {
            FromPrescriptionInstance = Pres;
		}
		public void SetDataGridViewData(DataTable data)
		{
			// Assuming your DataGridView in Form2 is named dataGridView2
			prescriptionList.DataSource = data;
		}
		public DataTable GetDataGridViewData()
		{
			// Assuming your DataGridView is named dataGridView1
			DataTable dt = new DataTable();

			// Assuming there are columns in your DataGridView
			foreach (DataGridViewColumn col in prescriptionList.Columns)
			{
				dt.Columns.Add(col.HeaderText);
			}

			// Add data rows
			foreach (DataGridViewRow row in prescriptionList.Rows)
			{
				DataRow dRow = dt.NewRow();
				foreach (DataGridViewCell cell in row.Cells)
				{
					dRow[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(dRow);
			}

			return dt;
		}


	}
}
