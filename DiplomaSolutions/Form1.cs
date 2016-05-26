using System;
using System.Diagnostics;
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
            var input = new InputData();
            input.gearType = gearData.SelectedText;
            double tmp;
            int temp, temp2, temp3;
            input.gearType = gearData.SelectedItem.ToString();
            input.m = double.Parse(moduleBox.SelectedItem.ToString().Replace('.', ','));
            input.q = double.Parse(diameterBOx.SelectedItem.ToString().Replace('.', ','));
            if (int.TryParse(textBox1.Text, out temp))
            {
                input.z1 = temp;
            }
            temp = 0;
            if (int.TryParse(textBox2.Text, out temp))
            {
                input.z2 = temp;
                
            }
            if (int.TryParse(textBox3.Text, out temp))
            {
                if (int.TryParse(textBox4.Text, out temp2) || textBox4.Text == "" || textBox4.Text == null)
                {
                    if (int.TryParse(textBox5.Text, out temp3) || textBox5.Text == "" || textBox5.Text == null)
                    {
                        input.alphaX = temp*0.01745329 + temp2*0.00029088 + temp3*0.00000048;
                    }
                }
            }
            if (double.TryParse(textBox6.Text.Replace('.', ','), out tmp))
            {
                input.h1 = tmp;
            }
            if (double.TryParse(textBox7.Text.Replace('.', ','), out tmp))
            {
                input.hAstrxAL = tmp;
            }
            if (double.TryParse(textBox8.Text.Replace('.', ','), out tmp))
            {
                input.c1 = tmp;
            }
            if (double.TryParse(textBox9.Text.Replace('.', ','), out tmp))
            {
                input.c2 = tmp;
            }
            if (double.TryParse(textBox10.Text.Replace('.', ','), out tmp))
            {
                input.sAstrx = tmp;
            }
            if (double.TryParse(textBox11.Text.Replace('.', ','), out tmp))
            {
                input.RoAstrxF1 = tmp;
            }
            if (calcModeBox.SelectedItem.ToString() == "За міжосьовою відстанню")
            {
                if (Int32.TryParse(textBox12.Text, out temp))
                {
                    input.aW = temp;
                }
            }
            else
            {
                if (double.TryParse(textBox13.Text.Replace('.', ','), out tmp))
                {
                    input.x = tmp;
                }
            }
            if (double.TryParse(textBox14.Text.Replace('.', ','), out tmp))
            {
                input.D = tmp;
            }
            if (calcModeBox.SelectedItem.ToString() == "ZT1" || calcModeBox.SelectedItem.ToString() == "ZT2")
            {
                if (Int32.TryParse(textBox12.Text, out temp))
                {
                    input.Ro = temp;
                }
            }
            Console.WriteLine(input.ToString());

        }

        private void moduleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gearData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gearData.SelectedItem.ToString() == "ZT1" || gearData.SelectedItem.ToString() == "ZT2")
            {
                textBox15.ReadOnly = false;
                tableLayoutPanel1.RowStyles[18].SizeType = SizeType.AutoSize;
                
               
            }
            else
            {
                
                textBox15.ReadOnly = false;
                tableLayoutPanel1.RowStyles[18].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[18].Height = 0;
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