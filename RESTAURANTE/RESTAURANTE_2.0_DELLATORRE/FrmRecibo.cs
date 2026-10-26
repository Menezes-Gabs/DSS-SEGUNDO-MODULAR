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
    public partial class FrmRecibo : Form
    {        
        public FrmRecibo(string textoDoRecibo)
        {
            InitializeComponent();        
            lblRecibo.Text = textoDoRecibo;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmRecibo_Load(object sender, EventArgs e)
        {

        }
    }
}
