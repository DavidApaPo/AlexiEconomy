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
    public partial class Bodegas : Form
    {
        public Bodegas()
        {
            InitializeComponent();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void Bodegas_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Close();
        }
    }
}
