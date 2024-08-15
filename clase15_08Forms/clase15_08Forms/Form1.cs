using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase15_08Forms
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Left = r.Next(0, this.Width - button1.Width);
            button1.Top = r.Next(0, this.Height - button1.Height);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons yesNo = MessageBoxButtons.YesNo;
            var resultado =MessageBox.Show("Seguro?","Hola",yesNo);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
