using MySql.Data.MySqlClient;
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
    public partial class FrmEstoque : Form
    {
        ClsConexao Conexao = new ClsConexao();
        StringBuilder CmdSql = new StringBuilder();

        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {

        }        

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtQtnd.Clear();
            txtMovimento.Clear();
            rdbEntrada.Checked = false;
            rdbSaida.Checked = false;
            dtbData.Value = DateTime.Now; // Reseta a data para hoje
            lblDescrição.Text = string.Empty;
        }

        /*quando o usuario digitar algo no txt do codigo, ele busca no banco de dados*/
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //é pra nao dar erro se o usuario apagar o campo
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                LimparCampos();
                return;
            }

            try
            {
                // String SQL
                CmdSql.Clear();
                CmdSql.Append("SELECT * FROM tb_estoque ");
                CmdSql.Append("WHERE CodEstoque = @CodEstoque");

                // injeção de parametros
                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@CodEstoque", txtCodigo.Text);

                Conexao.StrSql = CmdSql.ToString();

                //retornar dados do banco (feito na classe)
                DataSet DS = Conexao.RetornarDataSet();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    DataRow row = DS.Tables[0].Rows[0];
                    lblDescrição.Text = row["DescEstoque"].ToString();
                    txtQtnd.Text = row["QtndEstoque"].ToString();

                    if (row["dataEstoque"] != DBNull.Value)
                    {
                        dtbData.Value = Convert.ToDateTime(row["dataEstoque"]);
                    }
                }
                else
                {
                    //mostra pro usuario pel label
                    lblDescrição.Text = "Produto não localizado";
                    txtQtnd.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        private void btnLanca_Click(object sender, EventArgs e)
        {
            //tratamentos
            try
            {
                //ve se tem algum item
                if (string.IsNullOrEmpty(txtQtnd.Text))
                {
                    MessageBox.Show("Selecione um produto válido primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ve se tem algum valor no txt movimento
                if (!int.TryParse(txtMovimento.Text, out int qtdMovimento) || qtdMovimento <= 0)
                {
                    MessageBox.Show("Digite uma quantidade válida e maior que zero para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // verifica se o radio button ta chekado
                if (!rdbEntrada.Checked && !rdbSaida.Checked)
                {
                    MessageBox.Show("Selecione a movimentação: Entrada ou Saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int qtdAtual = Convert.ToInt32(txtQtnd.Text);
                int novaQtd = 0;

                // calculo da movimentação
                //ENTRADA (ADICIONAR)
                if (rdbEntrada.Checked)
                {
                    novaQtd = qtdAtual + qtdMovimento;
                }
                //SAIDA(TIRAR)
                else if (rdbSaida.Checked)
                {
                    novaQtd = qtdAtual - qtdMovimento;

                    // trava caso tente remover mais do que tem
                    if (novaQtd < 0)
                    {
                        MessageBox.Show("Estoque insuficiente para realizar esta saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //UPDATE
                //Aqui ele pega tudo q o user digitou e manda pro banco
                CmdSql.Clear();
                CmdSql.Append("UPDATE tb_estoque SET QtndEstoque = @QtndNova, dataEstoque = @DataEstoque ");
                CmdSql.Append("WHERE CodEstoque = @CodEstoque");

                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@QtndNova", novaQtd);
                Conexao.Cmd.Parameters.AddWithValue("@DataEstoque", dtbData.Value);
                Conexao.Cmd.Parameters.AddWithValue("@CodEstoque", txtCodigo.Text);

                Conexao.StrSql = CmdSql.ToString();
                int resultado = Conexao.ExecutarCmd();

                //resultado ==> linhas atualizadas
                //se houver alteração na linha ele manda uma caixinha do usuario :)
                if (resultado > 0)
                {
                    MessageBox.Show("Estoque atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o estoque: " + ex.Message);
            }
            
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            Hide();
        }
    }
}