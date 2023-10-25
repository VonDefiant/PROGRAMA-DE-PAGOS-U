namespace programa_mamalon_de_pagos.FRONTEND
{
    partial class SecondMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondMenu));
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button6 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(537, 93);
            button3.Name = "button3";
            button3.Size = new Size(179, 217);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(55, 93);
            button5.Name = "button5";
            button5.Size = new Size(179, 217);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(301, 93);
            button1.Name = "button1";
            button1.Size = new Size(179, 217);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Green;
            button6.Location = new Point(55, 358);
            button6.Name = "button6";
            button6.Size = new Size(301, 51);
            button6.TabIndex = 9;
            button6.Text = "Regresar";
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(413, 358);
            button2.Name = "button2";
            button2.Size = new Size(303, 51);
            button2.TabIndex = 10;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 50);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(129, 40);
            label1.TabIndex = 11;
            label1.Text = "Agregar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(319, 50);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(150, 40);
            label2.TabIndex = 12;
            label2.Text = "Modificar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(564, 50);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(129, 40);
            label3.TabIndex = 13;
            label3.Text = "Eliminar";
            // 
            // SecondMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button3);
            ForeColor = SystemColors.ControlText;
            Name = "SecondMenu";
            Text = "SecondMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button6;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}