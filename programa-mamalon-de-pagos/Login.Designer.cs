namespace programa_mamalon_de_pagos
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CONTRASEÑABOX = new TextBox();
            BONTONINGRESO = new Button();
            label1 = new Label();
            label2 = new Label();
            USERBOX = new TextBox();
            SuspendLayout();
            // 
            // CONTRASEÑABOX
            // 
            CONTRASEÑABOX.Location = new Point(308, 214);
            CONTRASEÑABOX.Name = "CONTRASEÑABOX";
            CONTRASEÑABOX.Size = new Size(224, 27);
            CONTRASEÑABOX.TabIndex = 0;
            CONTRASEÑABOX.TextChanged += textBox1_TextChanged;
            // 
            // BONTONINGRESO
            // 
            BONTONINGRESO.BackColor = SystemColors.Highlight;
            BONTONINGRESO.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BONTONINGRESO.ForeColor = SystemColors.ButtonFace;
            BONTONINGRESO.Location = new Point(353, 267);
            BONTONINGRESO.Name = "BONTONINGRESO";
            BONTONINGRESO.Size = new Size(134, 47);
            BONTONINGRESO.TabIndex = 1;
            BONTONINGRESO.Text = "INGRESAR";
            BONTONINGRESO.UseVisualStyleBackColor = false;
            BONTONINGRESO.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(316, 159);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 2;
            label1.Text = "CONTRASEÑA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(353, 44);
            label2.Name = "label2";
            label2.Size = new Size(140, 38);
            label2.TabIndex = 3;
            label2.Text = "USUARIO";
            label2.Click += label2_Click;
            // 
            // USERBOX
            // 
            USERBOX.Location = new Point(308, 92);
            USERBOX.Name = "USERBOX";
            USERBOX.Size = new Size(212, 27);
            USERBOX.TabIndex = 4;
            USERBOX.TextChanged += USERBOX_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(USERBOX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BONTONINGRESO);
            Controls.Add(CONTRASEÑABOX);
            Name = "Login";
            Text = "LOGIN";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CONTRASEÑABOX;
        private Button BONTONINGRESO;
        private Label label1;
        private Label label2;
        private TextBox USERBOX;
    }
}