﻿using System;
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
	public partial class AdminAddEmployee : Form
	{
		public AdminAddEmployee()
		{
			InitializeComponent();
		}

		private void RegisterBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Employee Register!");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void BackBtn_Click(object sender, EventArgs e)
		{
			AdminAccounts adminAccounts = new AdminAccounts();
			adminAccounts.Show();
			this.Hide();
		}
	}
}
