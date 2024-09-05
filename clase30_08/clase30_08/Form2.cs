using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase30_08
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cambiarColor();
            try { 
            if(textBox1.Text != "") { 
                if(int.Parse(textBox1.Text) >= 0 && int.Parse(textBox1.Text) <= 255)
                    trackBar1.Value = int.Parse(textBox1.Text);
                else if (int.Parse(textBox1.Text) > 255)
                    trackBar1.Value = 255;
            }
            }
            catch (FormatException) { }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cambiarColor()
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cambiarColor();
            if (textBox2.Text != "")
            {
                if(int.Parse(textBox2.Text) >= 0 && int.Parse(textBox2.Text) <= 255)
                trackBar2.Value = int.Parse(textBox2.Text);
                else if(int.Parse(textBox2.Text) > 255)
                    trackBar2.Value = 255;
            }
                

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cambiarColor();
            if (textBox3.Text != "" && int.Parse(textBox3.Text) >= 0 && int.Parse(textBox3.Text) <= 255)
            {
                trackBar3.Value = int.Parse(textBox3.Text);
            }
            else if (int.Parse(textBox2.Text) >= 255)
                trackBar2.Value = 255;
        }
    }
}
