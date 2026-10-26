using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANTE_2._0_DELLATORRE
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void RestauranteTSPMENU_Click(object sender, EventArgs e)
        {
            FrmRestaurante restaurante = new FrmRestaurante();
            restaurante.Show();
            Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
