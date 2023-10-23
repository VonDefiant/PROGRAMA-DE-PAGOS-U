using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace programa_mamalon_de_pagos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (USERBOX.Text.Trim() == "" && CONTRASE�ABOX.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                string query = "SELECT * FROM Usuarios WHERE Usuario= @user AND Contrase�a = @pass";
                SQLiteConnection conn = new SQLiteConnection("Data Source=BACKEND/EXACTUS.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", USERBOX.Text);
                cmd.Parameters.AddWithValue("@pass", CONTRASE�ABOX.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(" Te has logueado", "Acceso Correcto");
                }
                else
                {
                    MessageBox.Show("Acceso Denegado", "Algo has ingresado mal");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void USERBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}