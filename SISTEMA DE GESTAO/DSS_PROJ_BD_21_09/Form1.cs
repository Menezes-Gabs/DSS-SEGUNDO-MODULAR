using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS_PROJ_BD_21_09
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto Produto = new FrmProduto();
            Produto.Show();
            Hide();
        }

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoque estoque = new FrmEstoque();
            estoque.Show();
            Hide();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
            Hide();
        }
    }
}
