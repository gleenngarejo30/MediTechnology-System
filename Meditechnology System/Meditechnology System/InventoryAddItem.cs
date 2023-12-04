using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meditechnology_System
{
	public partial class InventoryAddItem : Form
	{
		public InventoryAddItem()
		{
			InitializeComponent();
		}

		private void RegisterBtn_Click(object sender, EventArgs e)
		{
            string medName, issuedate, expirationdate;
            int quantity, lotnumber;
            if (string.IsNullOrEmpty(QuantityTxtBox.Text) || string.IsNullOrEmpty(lotNumberTxtBox.Text) || string.IsNullOrEmpty(medCB.Text))
            {
                MessageBox.Show("Incomplete Details!");
            }
            else
            {
                medName = medCB.Text.ToString();
                lotnumber = Convert.ToInt32(lotNumberTxtBox.Text);
                quantity = Convert.ToInt32(QuantityTxtBox.Text);
                issuedate = DateIssueDatePicker.Text.ToString();
                expirationdate = DateExpiredDatePicker.Text.ToString();

                SqlQueries.InventoryAddItemQuery(medName, lotnumber, quantity, issuedate, expirationdate);
                MessageBox.Show("Medicine Registered!");
                showInventory();
                this.Hide();
            }
        }

		private void InventoryAddItem_FormClosed(object sender, FormClosedEventArgs e)
		{
			showInventory();
		}
		public static void showInventory() {
			var screen = new InventoryScreen();
			screen.Show();
		}

        private void backIcon_Click(object sender, EventArgs e)
        {
            showInventory();
            this.Hide();
        }

        private void InventoryAddItem_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in SqlQueries.PrescriptionMedicineLoadQuery().Rows)
            {
                medCB.Items.Add(dr["medName"].ToString());
            }
        }
    }
}
