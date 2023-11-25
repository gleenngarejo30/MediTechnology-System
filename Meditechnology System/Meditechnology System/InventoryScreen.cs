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
        }
		private void Addbtn_Click(object sender, EventArgs e)
		{
			InventoryAddItem inventoryAddItem = new InventoryAddItem();
			inventoryAddItem.Show();
			this.Hide();
		}
		private void Removebtn_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
									 "Confirm Delete!!",
									 MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				// If 'Yes', do something here.
			}
			else
			{
				// If 'No', do something here.
			}
		}
		private void InventoryScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			showLogin();
		}
		private void logoutBTN_Click(object sender, EventArgs e)
		{
			showLogin();
			this.Hide();
		}
		public static void showLogin() {
			var login = new Form1();
			login.Show();
		}
	}
}
