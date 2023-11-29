using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meditechnology_System
{
	public partial class nurse : UserControl
	{
		public nurse()
		{
			InitializeComponent();
		}

		private void addPatientBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			NurseScreen.bye();
			this.Hide();
		}
	}
}
