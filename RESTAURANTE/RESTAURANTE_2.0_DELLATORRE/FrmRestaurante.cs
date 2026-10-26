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
    public partial class FrmRestaurante : Form
    {
        /*"pega os dados" da classe criada e traz pra ca*/
        ClassCalculo conta = new ClassCalculo();
        public FrmRestaurante()
        {
            InitializeComponent();
        }
        //serve para atualizar o label de saida sempre que trocar algo
        private void AtualizarTotal()
        {
            conta.Calcular(
                CboAlmoco.Checked,
                CboRefrig.Checked,
                CboCerveja.Checked,
                CboSuco.Checked,
                Convert.ToInt32(NumAlmoco.Value),
                Convert.ToInt32(NumRefrigerante.Value),
                Convert.ToInt32(NumCerveja.Value),
                Convert.ToInt32(NumSuco.Value)
            );

            bool aniversariante =
                DtpClient.Value.Day == DateTime.Today.Day &&
                DtpClient.Value.Month == DateTime.Today.Month;

            conta.DescontoAniversariante(aniversariante);

            lblTotal.Text = "Total: R$ " + conta.TotalFinal.ToString("F2");
        }

        private void FrmRestaurante_Load(object sender, EventArgs e)
        {
            //deixa a caixa de data de nascimento zerada, é melhor assim
            DtpClient.Format = DateTimePickerFormat.Custom;
            DtpClient.CustomFormat = " ";                        
        }

        /*mostra os dois groupbx somente de a caixa estiver checkada*/
        private void CboAlmoco_CheckedChanged(object sender, EventArgs e)
        {
            GpbAlmoco.Visible = CboAlmoco.Checked;
            AtualizarTotal();

            if (CboAlmoco.Checked)
            {
                
            }
            else
            {
                NumAlmoco.Value = 1; // se o usuario desativar e ativar o cbo ele retonra para o valor padrao.
            }
        }

        private void CboBebidas_CheckedChanged(object sender, EventArgs e)
        {
            GpbBebidas.Visible = CboBebidas.Checked;
        }       

        private void DtpClient_ValueChanged(object sender, EventArgs e)
        {
            //se o usuario colocar mes e dia de nascimento igual ao de hoe (marcado no sistema) mostra o textinho de desconto aplicado
            DtpClient.Format =
                DateTimePickerFormat.Short;
            DtpClient.CustomFormat = "dd/MM/yyyy";

            DateTime nascimento = DtpClient.Value;
            DateTime hoje = DateTime.Today;

            lblAniversario.Visible =
                nascimento.Day == hoje.Day &&
                nascimento.Month == hoje.Month;

            AtualizarTotal();
        }

        /*puxa a função criada para atualizar o preço no label*/
        private void CboRefrig_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
            //se o cbo for verificado aparece a escolha para selecionar a quantidade, se nao, nao aparece e retorna o valor padrao
            if (CboRefrig.Checked)
            {
                NumRefrigerante.Visible = true;
            }
            else
            {
                NumRefrigerante.Visible = false;
                NumRefrigerante.Value = 1;
            }
        }

        private void CboCerveja_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();            
            
            if(CboCerveja.Checked)
            {
                NumCerveja.Visible = true;
            }
            else
            {
                NumCerveja.Visible = false;
                NumCerveja.Value = 1;
            }

        }

        private void CboSuco_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();

            if (CboSuco.Checked)
            {
                NumSuco.Visible = true;
            }
            else
            {
                NumSuco.Visible = false;
                NumSuco.Value = 1;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            ClassRecibo recibo = new ClassRecibo();

            string texto = recibo.GerarTextoRecibo(
                txtNomeClient.Text,
                DtpClient.Value.ToString("dd/MM/yyyy"),
                CboAlmoco.Checked,
                CboRefrig.Checked,
                CboCerveja.Checked,
                CboSuco.Checked,
                Convert.ToInt32(NumAlmoco.Value),
                Convert.ToInt32(NumRefrigerante.Value),
                Convert.ToInt32(NumCerveja.Value),
                Convert.ToInt32(NumSuco.Value),
                lblTotal.Text
            );

            FrmRecibo frmRecibo = new FrmRecibo(texto);
            frmRecibo.Show();
            this.Hide();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Width = 580;
            Height = 395;
            btnMostrar.Visible = false;
            btnClose.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnMostrar.Visible = true;
            btnClose.Visible = false;
            Width = 400;
            Height = 150;
        }

        private void NumAlmoco_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
                        
        }

        private void NumRefrigerante_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void NumCerveja_ValueChanged(object sender, EventArgs e)
        {
             AtualizarTotal();
        }

        private void NumSuco_ValueChanged(object sender, EventArgs e)
        {
             AtualizarTotal();
        }
    }
}