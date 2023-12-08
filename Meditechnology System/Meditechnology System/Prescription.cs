using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Meditechnology_System
{
    public partial class Prescription : Form
    {
        //static Boolean isAvailable = false;
        static string isAvailable;
        static int quan;
		public static int numMeds;
		public Prescription()
		{
			InitializeComponent();

            prescriptionList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            prescriptionList.ReadOnly = true;
        }
		private void Prescription_Load(object sender, EventArgs e)
		{
			patientNameLBL.Text = prescriptionDetails.getPatientName();

            foreach (DataRow dr in SqlQueries.PrescriptionMedicineLoadQuery().Rows)
            {
                medCB.Items.Add(dr["medName"].ToString());
            }
        }
		private void reserveBTN_Click(object sender, EventArgs e)
		{
            if (!(remarksLB.Items.Count == 0) && !(prescriptionList.RowCount == 0))
                {
                try
                {
                    DataTable dt = datagridExport(prescriptionList);
                    prescriptionDetails.setDataGrid(dt);
                    var name1 = dt.Rows[0][1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                prescriptionDetails.setReserved(true);
                ArrayList remarkArray = new ArrayList(remarksLB.Items);
                prescriptionDetails.setRemarks(remarkArray);

                showViewPrescription();
                this.Hide();
            }

        }
		private void prescribeBtn_Click(object sender, EventArgs e)
		{
            if (!(remarksLB.Items.Count == 0) && !(prescriptionList.RowCount == 0))
            {
                try
                {
                    DataTable dt = datagridExport(prescriptionList);
                    prescriptionDetails.setDataGrid(dt);
                    var name1 = dt.Rows[0][1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                prescriptionDetails.setReserved(false);
                ArrayList remarkArray = new ArrayList(remarksLB.Items);
                prescriptionDetails.setRemarks(remarkArray);

                showViewPrescription();
                var prescription = new ViewPrescription();
                prescription.Show();
                this.Hide();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            String meds = medCB.Text.ToLower();

            foreach (string gamot in medCB.Items) {
                if (!(quantityNUD.Text.Equals("")) && gamot.ToLower().Equals(meds) && Convert.ToInt32(quantityNUD.Text) != 0) {
					quan = Convert.ToInt32(QuantityLBL.Text);
					if (quan >= Convert.ToInt32(quantityNUD.Text))
						isAvailable = "Available";
					else
						isAvailable = "Unavailable";

					prescriptionList.Rows.Add(gamot, quantityNUD.Text, isAvailable);

					medCB.Text = null;
					quantityNUD.Text = "0";
				}
            }
		}
		private void medCB_Leave(object sender, EventArgs e)
		{
            medCB_SelectedIndexChanged(sender, e);
		}
		private void removeBTN_Click(object sender, EventArgs e){
			foreach (DataGridViewRow item in this.prescriptionList.SelectedRows)
			{
                prescriptionList.Rows.RemoveAt(item.Index);
			}
		}
		private void BackBtn_Click(object sender, EventArgs e)
		{
			showDoctor();
			this.Hide();
		}
		private void Prescription_FormClosed(object sender, FormClosedEventArgs e){
			showDoctor();
		}
		public static void showDoctor() {
			var doc = new DoctorScreen();
			doc.Show();
		}
		public static void showViewPrescription()
		{
			var prescription = new ViewPrescription();
			prescription.Show();
		}

        private void backIcon_Click(object sender, EventArgs e)
        {
            showDoctor();
            this.Hide();
        }

        private void medCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectmed = medCB.Text.ToString();
			SqlDataReader dr = SqlQueries.PrescriptionMedicineSelectQuery(selectmed);

            if (dr.Read())
			{
				QuantityLBL.Text = dr["Available"].ToString();
            }
        }
        private void remarksTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
			string remarks;
			if (e.KeyCode == Keys.Enter && !(string.IsNullOrWhiteSpace(remarksTxtBox.Text)))
			{
                remarks = remarksTxtBox.Text.Trim();
                remarksLB.Items.Add(remarks);
                remarksTxtBox.Text = null;
            }
        }
		private void removeRemarkBTN_Click(object sender, EventArgs e)
		{
			remarksLB.Items.Remove(remarksLB.SelectedItem);
		}

		private static DataTable datagridExport(DataGridView dgv)
		{
			DataTable dt = new DataTable();
			foreach(DataGridViewColumn clm in dgv.Columns)
			{
				dt.Columns.Add(clm.Name);
			}
			foreach(DataGridViewRow row in dgv.Rows)
			{
				DataRow d = dt.NewRow();
				foreach(DataGridViewCell cell in row.Cells)
				{
					d[cell.ColumnIndex] = cell.Value;
				}
				dt.Rows.Add(d);
			}
			return dt;
		}
	}
}
