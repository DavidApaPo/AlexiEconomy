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
    public partial class Venta : Form
    {
       
        
        public Venta()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            gbSell.Visible = true;
            txtReceive.Text = "1000";
            txtChange.Text=txtReceive.Text; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();
        }

        private void btnSell_KeyDown(object sender, KeyEventArgs e)
        {
        
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

        private void txtUnits_TextChanged(object sender, EventArgs e)
        {
            string patron = "^-?[0-9]+(\\.[0-9]+)?$";
            string texto =txtUnits.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {
                MessageBox.Show("Solo se permiten digitos");

                txtUnits.Text = texto.Remove(texto.Length - 1);

                txtUnits.SelectionStart = txtUnits.Text.Length;

            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string patron = "^-?[0-9]+(\\.[0-9]+)?$";
            string texto = txtPrice.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {
                MessageBox.Show("Solo se permiten digitos");

                txtPrice.Text = texto.Remove(texto.Length - 1);

                txtPrice.SelectionStart = txtPrice.Text.Length;

            }

        }
       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F12)
            {
      
                btnSell.PerformClick();
                gbSell.Visible = true;
                txtReceive.Focus(); 
                return true; // Indica que hemos manejado la tecla
                txtChange.Text = txtReceive.Text;
            }
            return base.ProcessCmdKey(ref msg, keyData); // Llama a la implementación base para otras teclas
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtReceive_KeyDown(object sender, KeyEventArgs e)
        {
            string patron = "^-?[0-9]+(\\.[0-9]+)?$";
            string texto = txtReceive.Text;


            if (!Regex.IsMatch(texto, patron) && texto != "")
            {
                MessageBox.Show("Solo se permiten digitos");

                txtReceive.Text = texto.Remove(texto.Length - 1);

                txtReceive.SelectionStart = txtReceive.Text.Length;


            }

            if (txtReceive.Text.Length > 0)
            {
                float receive = float.Parse(txtReceive.Text);
                float change = float.Parse(txtChange.Text);
                change = receive - change;
                txtChange.Text = change.ToString();

            }
        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();
        }
    }
}
