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
           
            string patron = "^-?[0-9]+(\\.[0-9]+)?$";
            string texto = txtPrice.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {
                MessageBox.Show("Solo se permiten digitos");

                txtPrice.Text = texto.Remove(texto.Length - 1);

                txtPrice.SelectionStart = txtPrice.Text.Length;
                 
            }

            ChangePriceIVA();





        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceBuy_TextChanged(object sender, EventArgs e)
        {
            string patron = "^-?[0-9]+(\\.[0-9]+)?$";
            string texto = txtPriceBuy.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {
                MessageBox.Show("Solo se permiten digitos");

                txtPriceBuy.Text = texto.Remove(texto.Length - 1);

                txtPriceBuy.SelectionStart = txtPriceBuy.Text.Length;
            }
        }

        private void txtPriceIVA_TextChanged(object sender, EventArgs e)
        {
            string patron = "^-?[0-9]+(\\.[0-9]+)?$";
            string texto = txtPriceIVA.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {
                MessageBox.Show("Solo se permiten digitos");

                txtPriceIVA.Text = texto.Remove(texto.Length - 1);

                txtPriceIVA.SelectionStart = txtPriceIVA.Text.Length;
            }

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            string patron = "^-?[0-9]+(\\.[0-9]+)?$";
            string texto = txtStock.Text;

            if (!Regex.IsMatch(texto, patron) && texto != "")
            {
                MessageBox.Show("Solo se permiten digitos");

                txtStock.Text = texto.Remove(texto.Length - 1);

                txtStock.SelectionStart = txtStock.Text.Length;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)

        private void btnSerch_Click(object sender, EventArgs e)
        {

        }

        private void tableProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        private void panel1_Paint(object sender, PaintEventArgs e)

        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void lbProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int num = TableProducts.Rows.Add();

            TableProducts.Rows[num].Cells[0].Value= txtName.Text;
            TableProducts.Rows[num].Cells[1].Value = cbMili.Text;
            TableProducts.Rows[num].Cells[2].Value = txtPriceIVA.Text;
            TableProducts.Rows[num].Cells[3].Value = txtPriceBuy.Text;
            TableProducts.Rows[num].Cells[4].Value = txtStock.Text;
            TableProducts.Rows[num].Cells[5].Value = txtCategory.Text;

        }

        private void TableProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePriceIVA();

        }
        




       private void ChangePriceIVA()
        {
            float percent = 0;
            string sizePrice = txtPrice.Text;
            if (cbIVA.Text == "Si" && sizePrice.Length>0)
            {
                percent = float.Parse(txtPrice.Text);
                percent *= (float)0.16;
                float price = float.Parse(txtPrice.Text);
                price = percent + price;
                txtPriceIVA.Text = price.ToString();
            }
            else
            {
                txtPriceIVA.Text = txtPrice.Text;
            }
        }
    }
}
