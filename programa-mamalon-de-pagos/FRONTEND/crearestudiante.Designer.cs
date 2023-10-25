namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class crearestudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearestudiante));
            nombreestuadiante = new TextBox();
            pictureBox1 = new PictureBox();
            telefonoalumno = new TextBox();
            textBox2 = new TextBox();
            FACULTAD = new ListBox();
            INSTITUCION = new ListBox();
            textBox1 = new TextBox();
            CARRERA = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nombreestuadiante
            // 
            nombreestuadiante.ForeColor = SystemColors.ScrollBar;
            nombreestuadiante.Location = new Point(176, 41);
            nombreestuadiante.Name = "nombreestuadiante";
            nombreestuadiante.Size = new Size(467, 27);
            nombreestuadiante.TabIndex = 0;
            nombreestuadiante.Text = "INGRESE EL NOMBRE COMPLETO";
            nombreestuadiante.TextAlign = HorizontalAlignment.Center;
            nombreestuadiante.TextChanged += nombreestuadiante_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ALUMNO;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(27, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 151);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // telefonoalumno
            // 
            telefonoalumno.ForeColor = SystemColors.ScrollBar;
            telefonoalumno.Location = new Point(176, 107);
            telefonoalumno.Name = "telefonoalumno";
            telefonoalumno.Size = new Size(125, 27);
            telefonoalumno.TabIndex = 2;
            telefonoalumno.Text = "TELEFONO";
            telefonoalumno.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(176, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(467, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "CORREO ELECTRONICO";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // FACULTAD
            // 
            FACULTAD.ForeColor = SystemColors.ScrollBar;
            FACULTAD.FormattingEnabled = true;
            FACULTAD.ItemHeight = 20;
            FACULTAD.Location = new Point(307, 110);
            FACULTAD.Name = "FACULTAD";
            FACULTAD.Size = new Size(156, 24);
            FACULTAD.TabIndex = 4;
            // 
            // INSTITUCION
            // 
            INSTITUCION.ForeColor = SystemColors.ScrollBar;
            INSTITUCION.FormattingEnabled = true;
            INSTITUCION.ItemHeight = 20;
            INSTITUCION.Location = new Point(469, 110);
            INSTITUCION.Name = "INSTITUCION";
            INSTITUCION.Size = new Size(174, 24);
            INSTITUCION.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(176, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "SECCION";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // CARRERA
            // 
            CARRERA.ForeColor = SystemColors.ScrollBar;
            CARRERA.FormattingEnabled = true;
            CARRERA.ItemHeight = 20;
            CARRERA.Location = new Point(263, 153);
            CARRERA.Name = "CARRERA";
            CARRERA.Size = new Size(251, 24);
            CARRERA.TabIndex = 7;
            // 
            // crearestudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(676, 592);
            Controls.Add(CARRERA);
            Controls.Add(textBox1);
            Controls.Add(INSTITUCION);
            Controls.Add(FACULTAD);
            Controls.Add(textBox2);
            Controls.Add(telefonoalumno);
            Controls.Add(pictureBox1);
            Controls.Add(nombreestuadiante);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crearestudiante";
            Text = "crearestudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreestuadiante;
        private PictureBox pictureBox1;
        private TextBox telefonoalumno;
        private TextBox textBox2;
        private ListBox FACULTAD;
        private ListBox INSTITUCION;
        private TextBox textBox1;
        private ListBox CARRERA;
    }
}