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
	public partial class UserControl2 : UserControl
	{
		public UserControl2()
		{
			InitializeComponent();
		}

		private void BackBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
