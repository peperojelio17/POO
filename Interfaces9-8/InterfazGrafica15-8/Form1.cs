using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace InterfazGrafica15_8
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);   
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Queres salir?","Para cerrar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                listBox2.Items.Add(textBox2.Text);
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                foreach (var item in listBox2.SelectedItems)
                {
                    listBox1.Items.Add(item);
                }
                for (int i = listBox2.SelectedItems.Count - 1; i >= 0 ; i--)
                {
                    listBox2.Items.RemoveAt(i);
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = listBox1.Items.Count - 1; i >= 0 ; i--)
            {
                listBox1.Items.RemoveAt(i);
            }
        }
    }
}
