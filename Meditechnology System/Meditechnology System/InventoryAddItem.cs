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
			MessageBox.Show("Medicine Registered!");
			showInventory();
			this.Hide();
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
