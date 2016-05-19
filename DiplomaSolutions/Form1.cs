using System;
using System.Windows.Forms;

namespace DiplomaSolutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label60_Click(object sender, EventArgs e)
        {
        }

        private void label63_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label107_Click(object sender, EventArgs e)
        {
        }

        private void Results_Click(object sender, EventArgs e)
        {
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            WormGearTypes gearType;
            Enum.TryParse<WormGearTypes>(gearData.SelectedValue.ToString(), out gearType);
        }

        private void moduleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}