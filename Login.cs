using System;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^[a-zA-Z\s]+$";
            string texto = txtUsuario.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {

                MessageBox.Show("Solo se permiten letras y espacios.");

                txtUsuario.Text = texto.Remove(texto.Length - 1);

                txtUsuario.SelectionStart = txtUsuario.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="alexi"&& txtContraseña.Text=="panfleto" )
            {
                Menu open=new Menu();
                open.Show();
                this.Hide();   
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
