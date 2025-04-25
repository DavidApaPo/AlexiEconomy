using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexiEconomy
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtProducts_Click(object sender, EventArgs e)
        {
            AltaProductos _altaProductos = new AltaProductos();
            _altaProductos.Show();
            this.Hide();        
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Venta _venta = new Venta();
            _venta.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnWare_Click(object sender, EventArgs e)
        {
            Bodegas _bodegas = new Bodegas();
            _bodegas.Show();
            this.Hide();
        }
    }
}
