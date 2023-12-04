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
    public partial class InventoryAddMedicine : Form
    {
        public InventoryAddMedicine()
        {
            InitializeComponent();
        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            showInventory();
            this.Hide();
        }

        public static void showInventory()
        {
            var screen = new InventoryScreen();
            screen.Show();
        }

        private void InventoryAddMedicine_FormClosed(object sender, FormClosedEventArgs e)
        {
            showInventory();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string medname = NameMedTxtBox.Text.ToString();
            double price = Convert.ToDouble(unitPriceTxtBox.Text);

            SqlQueries.InventoryAddMedicineQuery(medname, price);
            MessageBox.Show("Medicine Registered!");
            showInventory();
            this.Hide();
        }
    }
}
