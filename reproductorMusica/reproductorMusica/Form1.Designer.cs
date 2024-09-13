using System.Runtime.InteropServices;
using System.Text;
using System;

namespace reproductorMusica
{

    partial class Form1
    {
        
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Anterior = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DuracionTotal = new System.Windows.Forms.Label();
            this.TiempoActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 419);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(538, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(16, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(538, 292);
            this.listBox1.TabIndex = 4;
            // 
            // Siguiente
            // 
            this.Siguiente.BackgroundImage = global::reproductorMusica.Properties.Resources.skip_next_regular_36;
            this.Siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Siguiente.FlatAppearance.BorderSize = 0;
            this.Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Siguiente.Location = new System.Drawing.Point(326, 459);
            this.Siguiente.Margin = new System.Windows.Forms.Padding(4);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(58, 48);
            this.Siguiente.TabIndex = 6;
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Anterior
            // 
            this.Anterior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Anterior.BackgroundImage = global::reproductorMusica.Properties.Resources.skip_previous_regular_36;
            this.Anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anterior.FlatAppearance.BorderSize = 0;
            this.Anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anterior.Location = new System.Drawing.Point(193, 459);
            this.Anterior.Margin = new System.Windows.Forms.Padding(0);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(58, 48);
            this.Anterior.TabIndex = 5;
            this.Anterior.UseVisualStyleBackColor = false;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::reproductorMusica.Properties.Resources.plus_circle_regular_36;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(500, 315);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 49);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::reproductorMusica.Properties.Resources.play_circle_regular_36;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(255, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 62);
            this.button2.TabIndex = 2;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Reproducir_Click);
            // 
            // DuracionTotal
            // 
            this.DuracionTotal.AutoSize = true;
            this.DuracionTotal.Location = new System.Drawing.Point(516, 452);
            this.DuracionTotal.Name = "DuracionTotal";
            this.DuracionTotal.Size = new System.Drawing.Size(38, 16);
            this.DuracionTotal.TabIndex = 7;
            this.DuracionTotal.Text = "00:00";
            // 
            // TiempoActual
            // 
            this.TiempoActual.AutoSize = true;
            this.TiempoActual.Location = new System.Drawing.Point(13, 452);
            this.TiempoActual.Name = "TiempoActual";
            this.TiempoActual.Size = new System.Drawing.Size(38, 16);
            this.TiempoActual.TabIndex = 8;
            this.TiempoActual.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 529);
            this.Controls.Add(this.TiempoActual);
            this.Controls.Add(this.DuracionTotal);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Label DuracionTotal;
        private System.Windows.Forms.Label TiempoActual;
    }
}

