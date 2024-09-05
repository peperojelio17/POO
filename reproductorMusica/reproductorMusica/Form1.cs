using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Security.Cryptography;

namespace reproductorMusica
{
    public partial class Form1 : Form
    {
        string _audioFilePath;
        private long errcode;
        long dato;
        const int MAX_PATH = 260;
        bool play = false;
        StringBuilder sbBuffer = new StringBuilder(MAX_PATH);

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        public Form1()
        {
            InitializeComponent();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mciSendString("play myAudio from " + (trackBar1.Value * 1000).ToString() , null, 0, IntPtr.Zero);
            mciSendString("play myAudio", null, 0, IntPtr.Zero);

        }
        private void PlayAudio(string filePath)
        {

            mciSendString($"open \"{filePath}\" alias myAudio", null, 0, IntPtr.Zero);

            mciSendString("play myAudio", null, 0, IntPtr.Zero);
            play = true;

        }

        private void StopAudio()
        {
            mciSendString("pause myAudio", null, 0, IntPtr.Zero);

            play = false;
            //mciSendString("stop myAudio", null, 0, IntPtr.Zero);

            //mciSendString("close myAudio", null, 0, IntPtr.Zero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopAudio();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            _audioFilePath = listBox1.SelectedItem.ToString();

            mciSendString("set " + _audioFilePath + " time format milliseconds", null, 0, IntPtr.Zero);
            // Obtenemos el largo del archivo, en millisegundos.
            mciSendString("status " + _audioFilePath + " length", sbBuffer, MAX_PATH, IntPtr.Zero);
            trackBar1.Maximum = int.Parse(sbBuffer.ToString()) / 1000;

            PlayAudio(_audioFilePath);
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.wav;*.mp3";
                openFileDialog.Title = "Select an Audio File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    listBox1.Items.Add(openFileDialog.FileName);
                    
                    MessageBox.Show("Selected file: " + _audioFilePath);
                }
            }
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (play)
                trackBar1.Value += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
    }
}
