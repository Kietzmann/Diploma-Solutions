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

        private void Form1_Load(object sender, EventArgs e)
        {
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
        }

        private void moduleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gearData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gearData.SelectedItem.ToString() == "ZT1" || gearData.SelectedItem.ToString() == "ZT2")
            {
                textBox15.ReadOnly = false;
            }
            else
            {
                textBox15.ReadOnly = true;
            }
            if (gearData.SelectedItem.ToString() == "ZI")
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void calcModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calcModeBox.SelectedItem.ToString() != "За міжосьовою відстанню")
            {
                textBox13.ReadOnly = false;
                textBox12.ReadOnly = true;
            }
            else
            {
                textBox13.ReadOnly = true;
                textBox12.ReadOnly = false;
            }
        }

        private void normalContureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (normalContureBox.SelectedItem.ToString() == "По ГОСТ 19034-94")
            {
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
                textBox11.ReadOnly = true;
                textBox3.Text = "20";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "2,186";
                textBox7.Text = "1";
                textBox8.Text = "0,2";
                textBox9.Text = "0,2";
                textBox10.Text = "1,57";
                textBox11.Text = "0,3";
            }
            else
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
                textBox9.ReadOnly = false;
                textBox10.ReadOnly = false;
                textBox11.ReadOnly = false;
            }
        }
    }
}