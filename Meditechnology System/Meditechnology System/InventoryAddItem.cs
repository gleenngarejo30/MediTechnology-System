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

		private void BackBtn_Click(object sender, EventArgs e)
		{
			InventoryScreen screen = new InventoryScreen();
			screen.Show();
			this.Hide();
		}

		private void RegisterBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Register Medicine!");
			InventoryScreen screen = new InventoryScreen();
			screen.Show();
			this.Hide();
		}
	}
}
