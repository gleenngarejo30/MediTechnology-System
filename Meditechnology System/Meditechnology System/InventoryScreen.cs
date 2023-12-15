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
