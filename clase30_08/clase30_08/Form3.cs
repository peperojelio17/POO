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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }
    }
}
