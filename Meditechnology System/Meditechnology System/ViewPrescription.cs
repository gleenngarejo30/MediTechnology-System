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
    public partial class ViewPrescription : Form
    {
        public ViewPrescription()
        {
            InitializeComponent();
        }

        private void ViewPrescription_Load(object sender, EventArgs e)
        {

        }

        private void label1N_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void SendSaveBtn_Click(object sender, EventArgs e)
        {
            DoctorScreen doctorScreen = new DoctorScreen();
            doctorScreen.Show();
            this.Close();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            DoctorScreen doctorScreen = new DoctorScreen();
            doctorScreen.Show();
            this.Close();
        }
    }
}
