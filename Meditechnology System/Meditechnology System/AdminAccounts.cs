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
	public partial class AdminAccounts : Form
	{
		public AdminAccounts()
		{
			InitializeComponent();
		}
		private void Remove_Click(object sender, EventArgs e)
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

		private void AddBtn_Click(object sender, EventArgs e)
		{
			showAdmin();
			this.Hide();
		}
		private void Backbtn_Click(object sender, EventArgs e)
		{
			showAdmin();
			this.Hide();
		}
		private void AdminAccounts_FormClosed(object sender, FormClosedEventArgs e)
		{
			showAdmin();
		}
		public static void showAdmin(){
			var adminstrator = new Adminstrator();
			adminstrator.Show();
		}
	}
}
