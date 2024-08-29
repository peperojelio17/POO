using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase23_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nosSepararmeosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nOToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nOToolStripMenuItem.Enabled = !nOToolStripMenuItem.Enabled;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            openFileDialog1.FileName = "";
            //openFileDialog1.Filter = "hola pdf |*.pdf";
            d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK) 
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if(fontDialog1.ShowDialog() != DialogResult.Yes)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) { 
            richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(openFileDialog1.FileName);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width - 20;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
