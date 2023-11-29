using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meditechnology_System
{
	public partial class NurseScreen : Form
	{
		public static Boolean isOpen = true;
		public NurseScreen()
		{
			InitializeComponent();
		}
		private void NurseScreen_Load(object sender, EventArgs e)
		{
			userControl12.Visible = true;
		}
		private void userControl12_VisibleChanged(object sender, EventArgs e)
		{
			if (isOpen == true)
			{
				userControl21.Visible = true;
			}
			else if (isOpen == false)
			{
				this.Hide();
			}
		}
		private void userControl21_VisibleChanged(object sender, EventArgs e)
		{
			userControl12.Visible = true;
		}
		public static void bye() {
			isOpen = false;
			var login = new Form1();
			login.Show();
		}
	}
}
