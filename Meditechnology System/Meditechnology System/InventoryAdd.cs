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
    public partial class InventoryAdd : Form
    {
        public InventoryAdd()
        {
            InitializeComponent();
        }

		private void Backbtn_Click(object sender, EventArgs e)
		{
			showInventory();
			this.Hide();
		}

		private void InventoryAdd_FormClosed(object sender, FormClosedEventArgs e)
		{
			showInventory();
		}
		public static void showInventory()
		{
			var inventory = new InventoryScreen();
			inventory.Show();
		}
	}
}
