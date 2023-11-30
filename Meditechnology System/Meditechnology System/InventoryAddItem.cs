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
	public partial class InventoryAddItem : Form
	{
		public InventoryAddItem()
		{
			InitializeComponent();
		}

		private void RegisterBtn_Click(object sender, EventArgs e)
		{
            string medId, issuedate, expirationdate;
            int quantity, price;
            double unitprice;
            if (string.IsNullOrEmpty(NameMedTxtBox.Text) || string.IsNullOrEmpty(QuantityTxtBox.Text) ||
                string.IsNullOrEmpty(lotNumberTxtBox.Text) || string.IsNullOrEmpty(unitPriceTxtBox.Text))
            {
                MessageBox.Show("Incomplete Details!");
            }
            else
            {
                medId = NameMedTxtBox.Text.ToString();
                quantity = Convert.ToInt32(QuantityTxtBox.Text);
                price = Convert.ToInt32(lotNumberTxtBox.Text);
                unitprice = Convert.ToDouble(unitPriceTxtBox.Text);
                issuedate = DateIssueDatePicker.Text.ToString();
                expirationdate = DateExpiredDatePicker.Text.ToString();

                SqlQueries.InventoryAddItemQuery(medId, quantity, price, unitprice, issuedate, expirationdate);
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
    }
}
