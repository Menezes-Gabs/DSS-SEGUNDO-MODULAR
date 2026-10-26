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
    public partial class FrmCliente : Form
    {
        ClsConexao Conexao = new ClsConexao();
        StringBuilder CmdSql = new StringBuilder();

        public FrmCliente()
        {
            InitializeComponent();
            dtgClientes.Visible = false; //dataGrid invisivel até clicar no botão de pesquisa geral
        }                
        //Classe para limpar campos do formulario e focar no cpf
        private void LimparCampos()
        {
            txtCPF.Clear();
            txtNome.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;

            dtgClientes.Visible = false;
            txtCPF.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {               
                //AQUI ELE TIRA OS PONTOS E TRAÇOS DO NUMERO E CPF, PQ ESTÁ LIMITADO NO BANCO DE DADOS
                string cpf = txtCPF.Text.Replace(".", "").Replace("-", "").Trim(); //xxx.xxx.xxx-xx
                string cel = txtCelular.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Trim(); // respeitando o formato (xx)xxxxx-xxxx ele apaga tudo q nao for numero
                string genero = rdbMasculino.Checked ? "Mas" : (rdbFeminino.Checked ? "Fem" : "");

                //1 valid~ção se a campos nulo
                //NOT NULL DO BANCO
                if (string.IsNullOrWhiteSpace(txtCPF.Text) ||
                    string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtCelular.Text))
                {
                    MessageBox.Show("Os campos CPF, Nome e Celular são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //2. validação se tem 11 numeros ou não, se não, sem cadastro
                if (cpf.Length != 11)
                {
                    MessageBox.Show("O CPF deve conter exatamente 11 números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCPF.Focus();
                    return;
                }

                //ação de insert no banco com os dados pegados do formulario
                //Limpar solicitações do banco para o codigo nao bugar e mandar codigo "sujo"
                CmdSql.Clear();
                CmdSql.Append("INSERT INTO tb_cliente (CPF_cliente, Nome_cliente, Cel_cliente, Email_cliente, Genero_cliente) ");
                CmdSql.Append("VALUES (@CPF, @Nome, @Cel, @Email, @Genero)");

                //Limpar solicitações do banco para o codigo nao bugar e mandar codigo "sujo"
                Conexao.Cmd.Parameters.Clear();

                Conexao.Cmd.Parameters.AddWithValue("@CPF", cpf);
                Conexao.Cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                Conexao.Cmd.Parameters.AddWithValue("@Cel", cel);
                Conexao.Cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                Conexao.Cmd.Parameters.AddWithValue("@Genero", genero);

                Conexao.StrSql = CmdSql.ToString();

                int resultado = Conexao.ExecutarCmd();

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }            
        }

        private void btnPesqGeral_Click(object sender, EventArgs e)
        {
            try
            {
                // 2. Query simplificada para evitar erros de digitação nos nomes das colunas
                CmdSql.Clear();
                CmdSql.Append("SELECT * FROM tb_cliente");

                Conexao.StrSql = CmdSql.ToString();
                DataSet DS = Conexao.RetornarDataSet();

                if (DS != null && DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    //mpostra a tabela do banco
                    dtgClientes.DataSource = DS.Tables[0];
                    dtgClientes.Visible = true;
                }
                else
                {
                    MessageBox.Show("Nenhum cliente cadastrado no sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgClientes.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa geral: " + ex.Message);
            }            
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = null; 
            try
            {   
            //tira os pontos, virgulas e espaços do codigo, deixa o banco padronizado
                string cpf = txtCPF.Text.Replace(".", "").Replace("-", "").Trim();
                
                if (string.IsNullOrEmpty(cpf)) return;

                CmdSql.Clear();
                CmdSql.Append("SELECT * FROM tb_cliente WHERE CPF_cliente = @CPF");

                Conexao.Cmd.Parameters.Clear(); 
                Conexao.Cmd.Parameters.AddWithValue("@CPF", cpf);

                Conexao.StrSql = CmdSql.ToString();

                dr = Conexao.RetornarDataReader();

                if (dr.Read())
                {
                    txtNome.Text = dr["Nome_cliente"].ToString();
                    txtCelular.Text = dr["Cel_cliente"].ToString();
                    txtEmail.Text = dr["Email_cliente"].ToString();

                    string genero = dr["Genero_cliente"].ToString();
                    rdbMasculino.Checked = (genero == "Mas");
                    rdbFeminino.Checked = (genero == "Fem");
                }
                else
                {
                    MessageBox.Show("Cliente não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa individual: " + ex.Message);
            }
            finally // O DataReader SEMPRE será fechado aqui
            {
                if (dr != null && !dr.IsClosed) dr.Close();               
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacao = MessageBox.Show(
                    "Deseja realmente excluir este cliente?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao == DialogResult.Yes)
                {                    
                    string cpf = txtCPF.Text.Replace(".", "").Replace("-", "").Trim();

                    CmdSql.Clear();
                    CmdSql.Append("DELETE FROM tb_cliente WHERE CPF_cliente = @CPF");

                    Conexao.Cmd.Parameters.Clear();
                    Conexao.Cmd.Parameters.AddWithValue("@CPF", cpf);

                    Conexao.StrSql = CmdSql.ToString();

                    int resultado = Conexao.ExecutarCmd();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
