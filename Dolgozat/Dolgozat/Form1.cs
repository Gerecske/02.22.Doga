using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rab_green.Checked = true;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rab_green.Checked)
            {
                button3.BackColor = Color.Green;
            }
            if (rab_yellow.Checked)
            {
                button3.BackColor = Color.Yellow;
            }
            if (rab_blue.Checked)
            {
                button3.BackColor = Color.Blue;
            }
            if (rab_red.Checked)
            {
                button3.BackColor = Color.Red;
            }
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rab_green.Checked)
            {
                button1.BackColor = Color.Green;
            }
            if (rab_yellow.Checked)
            {
                button1.BackColor = Color.Yellow;
            }
            if (rab_blue.Checked)
            {
                button1.BackColor = Color.Blue;
            }
            if (rab_red.Checked)
            {
                button1.BackColor = Color.Red;
            }
            button3.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rab_green.Checked)
            {
                button2.BackColor = Color.Green;
            }
            if (rab_yellow.Checked)
            {
                button2.BackColor = Color.Yellow;
            }
            if (rab_blue.Checked)
            {
                button2.BackColor = Color.Blue;
            }
            if (rab_red.Checked)
            {
                button2.BackColor = Color.Red;
            }
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rab_green.Checked)
            {
                button4.BackColor = Color.Green;
            }
            if (rab_yellow.Checked)
            {
                button4.BackColor = Color.Yellow;
            }
            if (rab_blue.Checked)
            {
                button4.BackColor = Color.Blue;
            }
            if (rab_red.Checked)
            {
                button4.BackColor = Color.Red;
            }
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
        }

        private void cb_upper_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_upper.Checked)
            {
                button1.Text = button1.Text.ToUpper();
                button2.Text = button2.Text.ToUpper();
                button3.Text = button3.Text.ToUpper();
                button4.Text = button4.Text.ToUpper();
            }
            else
            {
                button1.Text = button1.Text.ToLower();
                button2.Text = button2.Text.ToLower();
                button3.Text = button3.Text.ToLower();
                button4.Text = button4.Text.ToLower();
            }
               
            
        }

        private void b_set_Click(object sender, EventArgs e)
        {
            string[] irasjel = { ".", "!", "?" };
            if (tb_read.Text.EndsWith(irasjel[0])| tb_read.Text.EndsWith(irasjel[1])| tb_read.Text.EndsWith(irasjel[2]))
            {

                rtb_write.Text += tb_read.Text+"\n";
                l_asd.Text = "Jó!";
                l_asd.ForeColor = Color.LightGreen;
            }
            else
            {
                l_asd.Text = "nem jó!";
                l_asd.ForeColor = Color.Red;
            }
        }

        private void b_count_Click(object sender, EventArgs e)
        {
            float t;
            int a = Convert.ToInt32(tb1.Text);
            int b = Convert.ToInt32(tb2.Text);
            t = a * a + b * b;
            tb_atfogo.Text = Convert.ToString(Math.Round(Math.Sqrt(t),2));
            tb_kerulet.Text = Convert.ToString(a + b + Math.Round(Math.Sqrt(t),2));
            tb_terulet.Text = Convert.ToString((a*b)/2);
        }
    }
}
