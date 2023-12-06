using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
			AdminAddEmployee addEmployee = new AdminAddEmployee();
			addEmployee.Show();
			this.Close();
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Adminstrator adminScreen = new Adminstrator();
            adminScreen.Show();
            this.Hide();
        }

        private void AdminAccounts_Load(object sender, EventArgs e)
        {

            DGVEmployee.DataSource = SqlQueries.EmployeeLoadQuery();
        }
    }
}
