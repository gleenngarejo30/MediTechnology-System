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
    public partial class InventoryScreen : Form
    {
        public InventoryScreen()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            btnclick();
        }

        private void Addbtn_Click(object sender, EventArgs e)
		{
			InventoryAddItem inventoryAddItem = new InventoryAddItem();
			inventoryAddItem.Show();
			this.Hide();
		}
		private void logoutBTN_Click(object sender, EventArgs e)
		{
            EmployeeDetails.toOffline();
			showLogin();
			this.Hide();
		}
		public static void showLogin() {
			var login = new Form1();
			login.Show();
		}

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            btnclick();
        }
        private void Removebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string medID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var confirmResult = MessageBox.Show("Are you sure you want to delete this item?" +
                                                    "\nMedicine ID: " + medID,
                                                    "Confirm Delete!!",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    SqlQueries.InventoryDeleteSearchQuery(medID);
                    btnclick();
                }
                else
                {
                    // If 'No', do something here.
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
        public void btnclick()
        {
            string search = SearchTxtBox.Text.ToString();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = SqlQueries.InventoryScreenSearchQuery(search);
        }

        private void AddStockbtn_Click(object sender, EventArgs e)
        {
            InventoryAddMedicine inventoryAddMedicine = new InventoryAddMedicine();
            inventoryAddMedicine.Show();
            this.Hide();
        }
    }
}
