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
            EMAILESTUDIANTE = new TextBox();
            FACULTAD = new ListBox();
            INSTITUCION = new ListBox();
            SECCIONESTUDIANTE = new TextBox();
            CARRERA = new ListBox();
            textBox3 = new TextBox();
            NACIMIENTOESTUDIANTE = new TextBox();
            SAVEBUTTON = new Button();
            GUARDAR = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nombreestuadiante
            // 
            nombreestuadiante.ForeColor = SystemColors.InfoText;
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
            pictureBox1.Location = new Point(24, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 163);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // telefonoalumno
            // 
            telefonoalumno.ForeColor = SystemColors.InfoText;
            telefonoalumno.Location = new Point(178, 144);
            telefonoalumno.Name = "telefonoalumno";
            telefonoalumno.Size = new Size(125, 27);
            telefonoalumno.TabIndex = 2;
            telefonoalumno.Text = "TELEFONO";
            telefonoalumno.TextAlign = HorizontalAlignment.Center;
            telefonoalumno.TextChanged += telefonoalumno_TextChanged;
            // 
            // EMAILESTUDIANTE
            // 
            EMAILESTUDIANTE.ForeColor = SystemColors.InfoText;
            EMAILESTUDIANTE.Location = new Point(176, 74);
            EMAILESTUDIANTE.Name = "EMAILESTUDIANTE";
            EMAILESTUDIANTE.Size = new Size(467, 27);
            EMAILESTUDIANTE.TabIndex = 3;
            EMAILESTUDIANTE.Text = "CORREO ELECTRONICO";
            EMAILESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            EMAILESTUDIANTE.TextChanged += EMAILESTUDIANTE_TextChanged;
            // 
            // FACULTAD
            // 
            FACULTAD.ForeColor = SystemColors.InfoText;
            FACULTAD.FormattingEnabled = true;
            FACULTAD.ItemHeight = 20;
            FACULTAD.Location = new Point(309, 147);
            FACULTAD.Name = "FACULTAD";
            FACULTAD.Size = new Size(205, 24);
            FACULTAD.TabIndex = 4;
            FACULTAD.SelectedIndexChanged += FACULTAD_SelectedIndexChanged;
            // 
            // INSTITUCION
            // 
            INSTITUCION.ForeColor = SystemColors.InfoText;
            INSTITUCION.FormattingEnabled = true;
            INSTITUCION.ItemHeight = 20;
            INSTITUCION.Location = new Point(178, 107);
            INSTITUCION.Name = "INSTITUCION";
            INSTITUCION.Size = new Size(465, 24);
            INSTITUCION.TabIndex = 5;
            INSTITUCION.SelectedIndexChanged += INSTITUCION_SelectedIndexChanged;
            // 
            // SECCIONESTUDIANTE
            // 
            SECCIONESTUDIANTE.ForeColor = SystemColors.InfoText;
            SECCIONESTUDIANTE.Location = new Point(178, 177);
            SECCIONESTUDIANTE.Name = "SECCIONESTUDIANTE";
            SECCIONESTUDIANTE.Size = new Size(81, 27);
            SECCIONESTUDIANTE.TabIndex = 6;
            SECCIONESTUDIANTE.Text = "SECCION";
            SECCIONESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            SECCIONESTUDIANTE.TextChanged += SECCIONESTUDIANTE_TextChanged;
            // 
            // CARRERA
            // 
            CARRERA.ForeColor = SystemColors.InfoText;
            CARRERA.FormattingEnabled = true;
            CARRERA.ItemHeight = 20;
            CARRERA.Location = new Point(265, 180);
            CARRERA.Name = "CARRERA";
            CARRERA.Size = new Size(251, 24);
            CARRERA.TabIndex = 7;
            CARRERA.SelectedIndexChanged += CARRERA_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.InfoText;
            textBox3.Location = new Point(520, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "JORNADA";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // NACIMIENTOESTUDIANTE
            // 
            NACIMIENTOESTUDIANTE.ForeColor = SystemColors.InfoText;
            NACIMIENTOESTUDIANTE.Location = new Point(520, 147);
            NACIMIENTOESTUDIANTE.Name = "NACIMIENTOESTUDIANTE";
            NACIMIENTOESTUDIANTE.Size = new Size(123, 27);
            NACIMIENTOESTUDIANTE.TabIndex = 9;
            NACIMIENTOESTUDIANTE.Text = "NACIMIENTO";
            NACIMIENTOESTUDIANTE.TextAlign = HorizontalAlignment.Center;
            NACIMIENTOESTUDIANTE.TextChanged += NACIMIENTOESTUDIANTE_TextChanged;
            // 
            // SAVEBUTTON
            // 
            //=======================>>SAVEBUTTON.BackgroundImage = Properties.Resources.salvar;
            SAVEBUTTON.BackgroundImageLayout = ImageLayout.Zoom;
            SAVEBUTTON.ForeColor = SystemColors.ButtonHighlight;
            SAVEBUTTON.Location = new Point(309, 210);
            SAVEBUTTON.Name = "SAVEBUTTON";
            SAVEBUTTON.Size = new Size(106, 66);
            SAVEBUTTON.TabIndex = 10;
            SAVEBUTTON.UseVisualStyleBackColor = true;
            SAVEBUTTON.Click += SAVEBUTTON_Click;
            // 
            // GUARDAR
            // 
            GUARDAR.AutoSize = true;
            GUARDAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GUARDAR.ForeColor = SystemColors.ButtonHighlight;
            GUARDAR.Location = new Point(322, 272);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(84, 20);
            GUARDAR.TabIndex = 11;
            GUARDAR.Text = "GUARDAR";
            // 
            // crearestudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(676, 301);
            Controls.Add(SAVEBUTTON);
            Controls.Add(NACIMIENTOESTUDIANTE);
            Controls.Add(textBox3);
            Controls.Add(CARRERA);
            Controls.Add(SECCIONESTUDIANTE);
            Controls.Add(INSTITUCION);
            Controls.Add(FACULTAD);
            Controls.Add(EMAILESTUDIANTE);
            Controls.Add(telefonoalumno);
            Controls.Add(pictureBox1);
            Controls.Add(nombreestuadiante);
            Controls.Add(GUARDAR);
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
        private TextBox EMAILESTUDIANTE;
        private ListBox FACULTAD;
        private ListBox INSTITUCION;
        private TextBox SECCIONESTUDIANTE;
        private ListBox CARRERA;
        private TextBox textBox3;
        private TextBox NACIMIENTOESTUDIANTE;
        private Button SAVEBUTTON;
        private Label GUARDAR;
    }
}