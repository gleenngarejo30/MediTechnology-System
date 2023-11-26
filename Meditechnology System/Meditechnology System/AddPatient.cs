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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            NurseScreen nurseScreen = new NurseScreen();
            nurseScreen.Show();
            this.Hide();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patient Register, Proceed to Doctor!");
            NurseScreen nurseScreen = new NurseScreen();
            nurseScreen.Show();
            this.Hide();
        }
    }
}
