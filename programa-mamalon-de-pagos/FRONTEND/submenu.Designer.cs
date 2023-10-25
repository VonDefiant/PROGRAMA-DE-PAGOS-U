namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class submenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(submenu));
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            ESTUDIANTEBT = new Button();
            button2 = new Button();
            INSITUCIONCONSULTABT = new Button();
            label2 = new Label();
            PAGOSCONSULTABT = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(104, 219);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 35;
            label6.Text = "AGREGAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(322, 219);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 34;
            label5.Text = "MODIFICAR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 419);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 33;
            label1.Text = "ESTUDIANTES";
            // 
            // ESTUDIANTEBT
            // 
            ESTUDIANTEBT.BackgroundImage = (Image)resources.GetObject("ESTUDIANTEBT.BackgroundImage");
            ESTUDIANTEBT.BackgroundImageLayout = ImageLayout.Zoom;
            ESTUDIANTEBT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ESTUDIANTEBT.ForeColor = SystemColors.ButtonFace;
            ESTUDIANTEBT.Location = new Point(67, 272);
            ESTUDIANTEBT.Name = "ESTUDIANTEBT";
            ESTUDIANTEBT.Size = new Size(165, 144);
            ESTUDIANTEBT.TabIndex = 32;
            ESTUDIANTEBT.TextAlign = ContentAlignment.BottomCenter;
            ESTUDIANTEBT.UseVisualStyleBackColor = true;
            ESTUDIANTEBT.Click += ESTUDIANTEBT_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.facultad;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(277, 72);
            button2.Name = "button2";
            button2.Size = new Size(165, 144);
            button2.TabIndex = 31;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // INSITUCIONCONSULTABT
            // 
            INSITUCIONCONSULTABT.BackgroundImage = Properties.Resources.institucion;
            INSITUCIONCONSULTABT.BackgroundImageLayout = ImageLayout.Zoom;
            INSITUCIONCONSULTABT.FlatAppearance.BorderColor = Color.Black;
            INSITUCIONCONSULTABT.FlatAppearance.BorderSize = 14;
            INSITUCIONCONSULTABT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            INSITUCIONCONSULTABT.ForeColor = SystemColors.ButtonFace;
            INSITUCIONCONSULTABT.Location = new Point(67, 72);
            INSITUCIONCONSULTABT.Name = "INSITUCIONCONSULTABT";
            INSITUCIONCONSULTABT.Size = new Size(161, 144);
            INSITUCIONCONSULTABT.TabIndex = 30;
            INSITUCIONCONSULTABT.TextAlign = ContentAlignment.BottomCenter;
            INSITUCIONCONSULTABT.TextImageRelation = TextImageRelation.ImageAboveText;
            INSITUCIONCONSULTABT.UseVisualStyleBackColor = true;
            INSITUCIONCONSULTABT.Click += AGREGARBT_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(306, 419);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 37;
            label2.Text = "RECIBOS DE PAGO";
            // 
            // PAGOSCONSULTABT
            // 
            PAGOSCONSULTABT.BackgroundImage = Properties.Resources.recibo;
            PAGOSCONSULTABT.BackgroundImageLayout = ImageLayout.Zoom;
            PAGOSCONSULTABT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PAGOSCONSULTABT.ForeColor = SystemColors.ButtonFace;
            PAGOSCONSULTABT.Location = new Point(277, 272);
            PAGOSCONSULTABT.Name = "PAGOSCONSULTABT";
            PAGOSCONSULTABT.Size = new Size(165, 144);
            PAGOSCONSULTABT.TabIndex = 36;
            PAGOSCONSULTABT.TextAlign = ContentAlignment.BottomCenter;
            PAGOSCONSULTABT.UseVisualStyleBackColor = true;
            PAGOSCONSULTABT.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 38;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // submenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(483, 468);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(PAGOSCONSULTABT);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(ESTUDIANTEBT);
            Controls.Add(button2);
            Controls.Add(INSITUCIONCONSULTABT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "submenu";
            Text = "Consultas";
            Load += submenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label1;
        private Button ESTUDIANTEBT;
        private Button button2;
        private Button INSITUCIONCONSULTABT;
        private Label label2;
        private Button PAGOSCONSULTABT;
        private Button button1;
    }
}