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
    public partial class FrmProduto : Form
    {
        ClsConexao Conexao = new ClsConexao();
        StringBuilder CmdSql = new StringBuilder();

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            ChamarGrid();
        }

        private void ChamarGrid()
        {
            try
            {
                Conexao.StrSql = "SELECT * FROM Produto";
                DataSet DS = Conexao.RetornarDataSet();
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a grade: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtDesc.Clear();
            txtValor.Clear();
            DTPprod.Value = DateTime.Now; // Reseta a data para hoje
            txtCodigo.Focus();
        }

        // BOTÃO PESQUISAR (SELECT)
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                // Padrão original de montagem da string SQL
                CmdSql.Clear();
                CmdSql.Append("SELECT * FROM Produto ");
                CmdSql.Append("WHERE CodProd = @CodProd");

                // Padrão original de injeção de parâmetros
                Conexao.Cmd.Parameters.Clear();
                Conexao.Cmd.Parameters.AddWithValue("@CodProd", txtCodigo.Text);

                Conexao.StrSql = CmdSql.ToString();

                // Usa o método da tua classe para retornar os dados em memória
                DataSet DS = Conexao.RetornarDataSet();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    // 1. Preenche os campos superiores com a primeira linha encontrada
                    DataRow row = DS.Tables[0].Rows[0];
                    txtDesc.Text = row["DescProd"].ToString();
                    txtValor.Text = row["ValorProd"].ToString();

                    if (row["VencProd"] != DBNull.Value)
                    {
                        DTPprod.Value = Convert.ToDateTime(row["VencProd"]);
                    }

                    // 2. Exibe o resultado no campo abaixo (DataGridView)
                    dataGridView1.DataSource = DS.Tables[0];

                    Height = 675;
                    Width = 325;
                }
                else
                {
                    MessageBox.Show("Produto não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                    ChamarGrid(); // Restaura a lista completa na grelha se não achar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        // BOTÃO CADASTRAR / SALVAR (INSERT) regra nova do dia 5/10
                private void btnAdicionar_Click(object sender, EventArgs e)
                {
                    try
                    {
                        CmdSql.Clear();
                        CmdSql.Append("INSERT INTO Produto (DescProd, ValorProd, VencProd) ");
                        CmdSql.Append("VALUES (@DescProd, @ValorProd, @VencProd)");

                        Conexao.Cmd.Parameters.Clear();
                        Conexao.Cmd.Parameters.AddWithValue("@DescProd", txtDesc.Text);
                        Conexao.Cmd.Parameters.AddWithValue("@ValorProd", Convert.ToDecimal(txtValor.Text));
                        Conexao.Cmd.Parameters.AddWithValue("@VencProd", DTPprod.Value);

                        Conexao.StrSql = CmdSql.ToString();

                        int resultado = Conexao.ExecutarCmd();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ChamarGrid();
                            LimparCampos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message);
                    }
                }
                    // BOTÃO EXCLUIR (DELETE)
                private void btnExcluir_Click_1(object sender, EventArgs e)
                {   
                    try
                    {
                        DialogResult confirmacao = MessageBox.Show(
                            "Deseja realmente excluir este produto?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (confirmacao == DialogResult.Yes)
                        {
                            CmdSql.Clear();
                            CmdSql.Append("DELETE FROM Produto WHERE CodProd = @CodProd");

                            Conexao.Cmd.Parameters.Clear();
                            Conexao.Cmd.Parameters.AddWithValue("@CodProd", txtCodigo.Text);

                            Conexao.StrSql = CmdSql.ToString();

                            int resultado = Conexao.ExecutarCmd();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ChamarGrid();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
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