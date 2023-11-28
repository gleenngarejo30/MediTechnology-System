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
    public partial class AdministratorHistory : Form
    {
        public AdministratorHistory()
        {
            InitializeComponent();
        }

		private void AdministratorHistory_FormClosed(object sender, FormClosedEventArgs e){
			showAdmin();
		}
		public static void showAdmin() {
			var admin = new Adminstrator();
			admin.Show();
		}

        private void backIcon_Click(object sender, EventArgs e)
        {
            showAdmin();
            this.Hide();
        }
    }
}
