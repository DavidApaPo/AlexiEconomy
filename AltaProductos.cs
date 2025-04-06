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

namespace AlexiEconomy
{
    public partial class AltaProductos : Form
    {
        public AltaProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu _menu= new Menu();
            _menu.Show();
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^[a-zA-Z\s]+$";
            string texto = txtName.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {

                MessageBox.Show("Solo se permiten letras y espacios.");

                txtName.Text = texto.Remove(texto.Length - 1);

                txtName.SelectionStart = txtName.Text.Length;
            }
        }

        private void cbMili_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
