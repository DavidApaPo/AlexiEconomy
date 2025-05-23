﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlexiEconomy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^[a-zA-Z\s]+$";
            string texto = txtUser.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {

                MessageBox.Show("Solo se permiten letras y espacios.");

                txtUser.Text = texto.Remove(texto.Length - 1);

                txtUser.SelectionStart = txtUser.Text.Length;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "alexi" && txtPass.Text == "1")
            {
                Menu _menu = new Menu();
                _menu.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SendToBack();
        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtUse_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void paneBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
