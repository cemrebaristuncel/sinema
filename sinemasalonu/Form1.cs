using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemasalonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,,] salon = new string[2, 3, 4] {
            {
                {"Kat 1\nSalon A\nKoltuk 1","Kat 1\nSalon A\nKoltuk 2","Kat 1\nSalon A\nKoltuk 3","Kat 1\nSalon A\nKoltuk 4"},
                {"Kat 1\nSalon B\nKoltuk 1","Kat 1\nSalon B\nKoltuk 2","Kat 1\nSalon B\nKoltuk 3","Kat 1\nSalon B\nKoltuk 4"},
                {"Kat 1\nSalon C\nKoltuk 1","Kat 1\nSalon C\nKoltuk 2","Kat 1\nSalon C\nKoltuk 3","Kat 1\nSalon C\nKoltuk 4"}
            },                                                                                                            
            {                                                                                                             
                {"Kat 2\nSalon A\nKoltuk 1","Kat 2\nSalon A\nKoltuk 2","Kat 2\nSalon A\nKoltuk 3","Kat 2\nSalon A\nKoltuk 4"},
                {"Kat 2\nSalon B\nKoltuk 1","Kat 2\nSalon B\nKoltuk 2","Kat 2\nSalon B\nKoltuk 3","Kat 2\nSalon B\nKoltuk 4"},
                {"Kat 2\nSalon C\nKoltuk 1","Kat 2\nSalon C\nKoltuk 2","Kat 2\nSalon C\nKoltuk 3","Kat 2\nSalon C\nKoltuk 4"}
            },
        };
        private void button1_Click(object sender, EventArgs e)
        {
            string secilenKat = comboBox1.Text;
            string secilenSalon = comboBox2.Text;

            if (secilenKat == "1" && secilenSalon == "A")
            {
                groupBox1.Text = "Kat 1 Salon A";
                button6.Visible = true;

                button2.Text = salon[0, 0, 0];
                button3.Text = salon[0, 0, 1];
                button4.Text = salon[0, 0, 2];
                button5.Text = salon[0, 0, 3];

                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            }
            else if (secilenKat == "1" && secilenSalon == "B")
            {
                groupBox2.Text = "Kat 1 Salon B";
                button6.Visible = true;

                button7.Text = salon[0, 1, 0];
                button8.Text = salon[0, 1, 3];
                button9.Text = salon[0, 1, 1];
                button10.Text = salon[0, 1, 2];

                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;

                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            }
            else if (secilenKat == "1" && secilenSalon == "C")
            {
                groupBox3.Text = "Kat 1 Salon C";
                button6.Visible = true;

                button11.Text = salon[0, 2, 0];
                button12.Text = salon[0, 2, 3];
                button13.Text = salon[0, 2, 1];
                button14.Text = salon[0, 2, 2];

                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            }
            else if (secilenKat == "2" && secilenSalon == "A")
            {
                groupBox4.Text = "Kat 2 Salon A";
                button6.Visible = true;

                button15.Text = salon[1, 0, 0];
                button16.Text = salon[1, 0, 3];
                button17.Text = salon[1, 0, 1];
                button18.Text = salon[1, 0, 2];

                button15.Visible = true;
                button16.Visible = true;
                button17.Visible = true;
                button18.Visible = true;

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            }
            else if (secilenKat == "2" && secilenSalon == "B")
            {
                groupBox5.Text = "Kat 2 Salon B";
                button6.Visible = true;

                button19.Text = salon[1, 1, 0];
                button20.Text = salon[1, 1, 3];
                button21.Text = salon[1, 1, 1];
                button22.Text = salon[1, 1, 2];

                button19.Visible = true;
                button20.Visible = true;
                button21.Visible = true;
                button22.Visible = true;

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = true;
                groupBox6.Visible = false;
            }
            else if (secilenKat == "2" && secilenSalon == "C")
            {
                groupBox6.Text = "Kat 2 Salon C";
                button6.Visible = true;

                button23.Text = salon[1, 2, 0];
                button24.Text = salon[1, 2, 3];
                button25.Text = salon[1, 2, 1];
                button26.Text = salon[1, 2, 2];

                button23.Visible = true;
                button24.Visible = true;
                button25.Visible = true;
                button26.Visible = true;

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Red)
            {
                button2.BackColor = Color.Gray;
                button2.Enabled = false;
            }
            if (button3.BackColor == Color.Red)
            {
                button3.BackColor = Color.Gray;
                button3.Enabled = false;
            }
            if (button4.BackColor == Color.Red)
            {
                button4.BackColor = Color.Gray;
                button4.Enabled = false;
            }
            if (button5.BackColor == Color.Red)
            {
                button5.BackColor = Color.Gray;
                button5.Enabled = false;
            }
            if (button7.BackColor == Color.Red)
            {
                button7.BackColor = Color.Gray;
                button7.Enabled = false;
            }
            if (button8.BackColor == Color.Red)
            {
                button8.BackColor = Color.Gray;
                button8.Enabled = false;
            }
            if (button9.BackColor == Color.Red)
            {
                button9.BackColor = Color.Gray;
                button9.Enabled = false;
            }
            if (button10.BackColor == Color.Red)
            {
                button10.BackColor = Color.Gray;
                button10.Enabled = false;
            }
            if (button11.BackColor == Color.Red)
            {
                button11.BackColor = Color.Gray;
                button11.Enabled = false;
            }
            if (button12.BackColor == Color.Red)
            {
                button12.BackColor = Color.Gray;
                button12.Enabled = false;
            }
            if (button13.BackColor == Color.Red)
            {
                button13.BackColor = Color.Gray;
                button13.Enabled = false;
            }
            if (button14.BackColor == Color.Red)
            {
                button14.BackColor = Color.Gray;
                button14.Enabled = false;
            }
            if (button15.BackColor == Color.Red)
            {
                button15.BackColor = Color.Gray;
                button15.Enabled = false;
            }
            if (button16.BackColor == Color.Red)
            {
                button16.BackColor = Color.Gray;
                button16.Enabled = false;
            }
            if (button17.BackColor == Color.Red)
            {
                button17.BackColor = Color.Gray;
                button17.Enabled = false;
            }
            if (button18.BackColor == Color.Red)
            {
                button18.BackColor = Color.Gray;
                button18.Enabled = false;
            }
            if (button19.BackColor == Color.Red)
            {
                button19.BackColor = Color.Gray;
                button19.Enabled = false;
            }
            if (button20.BackColor == Color.Red)
            {
                button20.BackColor = Color.Gray;
                button20.Enabled = false;
            }
            if (button21.BackColor == Color.Red)
            {
                button21.BackColor = Color.Gray;
                button21.Enabled = false;
            }
            if (button22.BackColor == Color.Red)
            {
                button22.BackColor = Color.Gray;
                button22.Enabled = false;
            }
            if (button23.BackColor == Color.Red)
            {
                button23.BackColor = Color.Gray;
                button23.Enabled = false;
            }
            if (button24.BackColor == Color.Red)
            {
                button24.BackColor = Color.Gray;
                button24.Enabled = false;
            }
            if (button25.BackColor == Color.Red)
            {
                button25.BackColor = Color.Gray;
                button25.Enabled = false;
            }
            if (button26.BackColor == Color.Red)
            {
                button26.BackColor = Color.Gray;
                button26.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Lime)
            {
                button2.BackColor = Color.Red;
            }
            else if(button2.BackColor == Color.Red)
            {
                button2.BackColor = Color.Lime;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Lime)
            {
                button3.BackColor = Color.Red;
            }
            else if (button3.BackColor == Color.Red)
            {
                button3.BackColor = Color.Lime;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Lime)
            {
                button4.BackColor = Color.Red;
            }
            else if (button4.BackColor == Color.Red)
            {
                button4.BackColor = Color.Lime;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Lime)
            {
                button5.BackColor = Color.Red;
            }
            else if (button5.BackColor == Color.Red)
            {
                button5.BackColor = Color.Lime;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Lime)
            {
                button7.BackColor = Color.Red;
            }
            else if (button7.BackColor == Color.Red)
            {
                button7.BackColor = Color.Lime;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Lime)
            {
                button8.BackColor = Color.Red;
            }
            else if (button8.BackColor == Color.Red)
            {
                button8.BackColor = Color.Lime;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Lime)
            {
                button9.BackColor = Color.Red;
            }
            else if (button9.BackColor == Color.Red)
            {
                button9.BackColor = Color.Lime;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Lime)
            {
                button10.BackColor = Color.Red;
            }
            else if (button10.BackColor == Color.Red)
            {
                button10.BackColor = Color.Lime;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Lime)
            {
                button11.BackColor = Color.Red;
            }
            else if (button11.BackColor == Color.Red)
            {
                button11.BackColor = Color.Lime;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Lime)
            {
                button12.BackColor = Color.Red;
            }
            else if (button12.BackColor == Color.Red)
            {
                button12.BackColor = Color.Lime;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Lime)
            {
                button13.BackColor = Color.Red;
            }
            else if (button13.BackColor == Color.Red)
            {
                button13.BackColor = Color.Lime;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Lime)
            {
                button14.BackColor = Color.Red;
            }
            else if (button14.BackColor == Color.Red)
            {
                button14.BackColor = Color.Lime;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Lime)
            {
                button15.BackColor = Color.Red;
            }
            else if (button15.BackColor == Color.Red)
            {
                button15.BackColor = Color.Lime;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Lime)
            {
                button16.BackColor = Color.Red;
            }
            else if (button16.BackColor == Color.Red)
            {
                button16.BackColor = Color.Lime;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Lime)
            {
                button17.BackColor = Color.Red;
            }
            else if (button17.BackColor == Color.Red)
            {
                button17.BackColor = Color.Lime;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Lime)
            {
                button18.BackColor = Color.Red;
            }
            else if (button18.BackColor == Color.Red)
            {
                button18.BackColor = Color.Lime;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Lime)
            {
                button19.BackColor = Color.Red;
            }
            else if (button19.BackColor == Color.Red)
            {
                button19.BackColor = Color.Lime;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Lime)
            {
                button20.BackColor = Color.Red;
            }
            else if (button20.BackColor == Color.Red)
            {
                button20.BackColor = Color.Lime;
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Lime)
            {
                button21.BackColor = Color.Red;
            }
            else if (button21.BackColor == Color.Red)
            {
                button21.BackColor = Color.Lime;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Lime)
            {
                button22.BackColor = Color.Red;
            }
            else if (button22.BackColor == Color.Red)
            {
                button22.BackColor = Color.Lime;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Lime)
            {
                button23.BackColor = Color.Red;
            }
            else if (button23.BackColor == Color.Red)
            {
                button23.BackColor = Color.Lime;
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.Lime)
            {
                button24.BackColor = Color.Red;
            }
            else if (button24.BackColor == Color.Red)
            {
                button24.BackColor = Color.Lime;
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Lime)
            {
                button25.BackColor = Color.Red;
            }
            else if (button25.BackColor == Color.Red)
            {
                button25.BackColor = Color.Lime;
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.Lime)
            {
                button26.BackColor = Color.Red;
            }
            else if (button26.BackColor == Color.Red)
            {
                button26.BackColor = Color.Lime;
            }
        }

       
    }
}
