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

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Adminstrator adminstrator = new Adminstrator();
            adminstrator.Show();
            this.Close();
        }
    }
}
