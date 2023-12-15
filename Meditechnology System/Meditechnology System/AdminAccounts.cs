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
            DGVEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVEmployee.ReadOnly = true;
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
            filter();
        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void AccountNumberTxtBox_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void TypeEmployeeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
			filter();
        }

		public void filter()
		{
			string name = NameTxtBox.Text;
			string id = AccountNumberTxtBox.Text;
			string occupation = TypeEmployeeCB.Text;
            DGVEmployee.DataSource = SqlQueries.EmployeeLoadQuery(name, id, occupation);
        }
    }
}
