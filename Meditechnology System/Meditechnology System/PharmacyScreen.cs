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
    public partial class PharmacyScreen : Form
    {
        public PharmacyScreen()
        {
            InitializeComponent();
                        remarksTxtBox.KeyDown += remarksTxtBox_KeyDown;


        }

        private void PharmacyScreen_Load(object sender, EventArgs e)
        {

            foreach (DataRow dr in SqlQueries.PharmacyScreenLoadQuery().Rows)
            {
                refNumCB.Items.Add(dr["prescriptionID"].ToString());
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
		{
			showLogin();
			this.Hide();
		}
		private void PharmacyScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			showLogin();
		}
        public static void showLogin() {
			var login = new Form1();
			login.Show();
		}

        private void remarksTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Get the text from the remarksTxtBox
                string text = remarksTxtBox.Text;

                // Add the text to the ListBox
                listBox1.Items.Add(text);

                // Clear the remarksTxtBox for the next input
                remarksTxtBox.Clear();

                // Prevent the "ding" sound when Enter is pressed
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Remove the last entered item in the ListBox
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }
    }
}
