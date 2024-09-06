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
using System.IO;

namespace reproductorMusica
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> canciones = new Dictionary<string, string>();
        string _audioFilePath = "";
        string nombre = "";
        private long errcode;
        long dato;
        const int MAX_PATH = 260;
        bool play = false;
        int a;
        StringBuilder sbBuffer = new StringBuilder(MAX_PATH);

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (play)
            {
                mciSendString("play myAudio from " + (trackBar1.Value * 1000).ToString(), null, 0, IntPtr.Zero);
                mciSendString("play myAudio", null, 0, IntPtr.Zero);
            }
        }
        private void PlayAudio(string filePath)
        {
            mciSendString($"open \"{filePath}\" alias myAudio", null, 0, IntPtr.Zero);

            mciSendString("play myAudio", null, 0, IntPtr.Zero);
            play = true;

        }

        private void despausar()
        {
            mciSendString("play myAudio from " + (trackBar1.Value * 1000).ToString(), null, 0, IntPtr.Zero);

            play = true;
        }

        private void StopAudio()
        {

            play = false;
            mciSendString("stop myAudio", null, 0, IntPtr.Zero);

            mciSendString("close myAudio", null, 0, IntPtr.Zero);
        }
        private void PauseAudio() 
        {
            play = false;
            mciSendString("pause myAudio", null, 0, IntPtr.Zero);
        }

        private void Pausar_Click(object sender, EventArgs e)
        {
            PauseAudio();
        }


        private void Reproducir_Click(object sender, EventArgs e)
        {
            if (nombre != "")
            {
                if (nombre != listBox1.SelectedItem.ToString())
                {
                    StopAudio();
                    trackBar1.Value = 0;
                    foreach (var a in canciones)
                    {
                        if (a.Value == listBox1.SelectedItem.ToString())
                        {
                            _audioFilePath = a.Key;
                        }
                    }
                    mciSendString("set " + _audioFilePath + " time format milliseconds", null, 0, IntPtr.Zero);
                    PlayAudio(_audioFilePath);
                }
                else
                {
                    despausar();
                }
            }
            else
            {
                foreach(var d in canciones)
                {
                    if(d.Value == listBox1.SelectedItem.ToString())
                    {
                        _audioFilePath = d.Key;
                    }
                }
                mciSendString("set " + _audioFilePath + " time format milliseconds", null, 0, IntPtr.Zero);
                PlayAudio(_audioFilePath);
            }
            
            nombre = Path.GetFileNameWithoutExtension(_audioFilePath);
            // Obtenemos el largo del archivo, en millisegundos.
            mciSendString("status " + _audioFilePath + " length", sbBuffer, MAX_PATH, IntPtr.Zero);
            trackBar1.Maximum = int.Parse(sbBuffer.ToString()) / 1000;

        }
        private void Agregar_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.wav;*.mp3";
                openFileDialog.Title = "Select an Audio File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog.FileName));
                    canciones.Add(openFileDialog.FileName, Path.GetFileNameWithoutExtension(openFileDialog.FileName));
                    //listBox1.Items.Add(openFileDialog.SafeFileName);
                }
            }
            
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (play)
                trackBar1.Value += 1;
        }
        private void Anterior_Click(object sender, EventArgs e)
        {
            
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            int indice = 0;
            StopAudio();
            trackBar1.Value = 0;
            for (int i = 0; i < listBox1.Items.Count - 1; i++) 
            { 
                if(listBox1.SelectedItem == listBox1.Items[i])
                {
                    indice = i;
                    indice = (listBox1.Items.Count - 1 == indice) ? 0 : indice + 1;
                    listBox1.SelectedItem = null;
                    listBox1.SelectedItem = listBox1.Items[indice];
                }
            }

            foreach (var d in canciones)
            {
                if (d.Value == listBox1.SelectedItem.ToString())
                {
                    _audioFilePath = d.Key;
                }
            }
            PlayAudio(_audioFilePath);
        }
    }
}
