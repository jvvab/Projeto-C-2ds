using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_banco01
{
    public partial class FrmFuncionarios : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        public FrmFuncionarios()
        {
            InitializeComponent();
            Listar();
        }


        public void Listar()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_funcionarios = "select * from tb_funcionarios";

                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_funcionarios, con);

                con.Open();
                executacmdMySql_select.ExecuteNonQuery();


                DataTable tabela_funcionarios = new DataTable();

                MySqlDataAdapter da_funcionarios = new MySqlDataAdapter(executacmdMySql_select);

                da_funcionarios.Fill(tabela_funcionarios);

                DgvListaFuncionarios.DataSource = tabela_funcionarios;

                con.Close();
            }
            catch (Exception erro)
            {
                string mensagem = "Ocorreu um erro na sua listagem! Foi o erro: " + erro;
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, rg, cpf,  email, senha, cargo, nivel, telefone, celular, cep, endereco, complemento, bairro, cidade, estado;
                int numero;


                nome = txtnome.Text;
                rg = txtrg.Text;
                cpf = txtcpf.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;
                cargo = txtcargo.Text;
                nivel = txtnivel.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text;
                cep = txtcep.Text;
                endereco = txtendereco.Text;
                numero = int.Parse(txtnumero.Text);
                complemento = txtcomplemento.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                estado = txtestado.Text;



                string sql_insert = @"insert into tb_funcionarios (tb_funcionarios_nome,
                                                                  tb_funcionarios_rg,
                                                                  tb_funcionarios_cpf,
                                                                  tb_funcionarios_email,
                                                                  tb_funcionarios_senha,
                                                                  tb_funcionarios_cargo,
                                                                  tb_funcionarios_nivel_acesso,
                                                                  tb_funcionarios_telefone,
                                                                  tb_funcionarios_celular,
                                                                  tb_funcionarios_cep,
                                                                  tb_funcionarios_endereco,
                                                                  tb_funcionarios_numero,
                                                                  tb_funcionarios_complemento,
                                                                  tb_funcionarios_bairro,
                                                                  tb_funcionarios_cidade,
                                                                  tb_funcionarios_estado)
                                                           values(@nome, 
                                                                  @rg,
                                                                  @cpf,
                                                                  @email,
                                                                  @senha,
                                                                  @cargo,
                                                                  @nivel,
                                                                  @telefone,
                                                                  @celular,
                                                                  @cep,
                                                                  @endereco,
                                                                  @numero,
                                                                  @complemento,
                                                                  @bairro,
                                                                  @cidade,
                                                                  @estado)";


                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@rg", rg);
                executacmdMySql_insert.Parameters.AddWithValue("@cpf", cpf);
                executacmdMySql_insert.Parameters.AddWithValue("@email", email);
                executacmdMySql_insert.Parameters.AddWithValue("@senha", senha);
                executacmdMySql_insert.Parameters.AddWithValue("@cargo", cargo);
                executacmdMySql_insert.Parameters.AddWithValue("@nivel", nivel);
                executacmdMySql_insert.Parameters.AddWithValue("@telefone", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@celular", celular);
                executacmdMySql_insert.Parameters.AddWithValue("@cep", cep);
                executacmdMySql_insert.Parameters.AddWithValue("@endereco", endereco);
                executacmdMySql_insert.Parameters.AddWithValue("@numero", numero);
                executacmdMySql_insert.Parameters.AddWithValue("@complemento", complemento);
                executacmdMySql_insert.Parameters.AddWithValue("@bairro", bairro);
                executacmdMySql_insert.Parameters.AddWithValue("@cidade", cidade);
                executacmdMySql_insert.Parameters.AddWithValue("@estado", estado);


                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Funcionario cadastrado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            catch (Exception erro)
            {
                string mensagem = "Ocorreu um erro no seu cadastro! Foi o erro: " + erro;
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Listar();

        }

        private void Btnatt_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, rg, cpf, email, senha, cargo, nivel, telefone, celular, cep, endereco, complemento, bairro, cidade, estado;
                int numero, codigo;

                codigo = int.Parse(txtcodigo.Text);
                nome = txtnome.Text;
                rg = txtrg.Text;
                cpf = txtcpf.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;
                cargo = txtcargo.Text;
                nivel = txtnivel.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text;
                cep = txtcep.Text;
                endereco = txtendereco.Text;
                numero = int.Parse(txtnumero.Text);
                complemento = txtcomplemento.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                estado = txtestado.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql_update_funcionario = @"update tb_funcionarios set
                                                                  tb_funcionarios_nome = @nome,
                                                                  tb_funcionarios_rg = @rg,
                                                                  tb_funcionarios_cpf = @cpf,
                                                                  tb_funcionarios_email = @email,
                                                                  tb_funcionarios_senha = @senha,
                                                                  tb_funcionarios_cargo = @cargo,
                                                                  tb_funcionarios_nivel_acesso = @nivel,
                                                                  tb_funcionarios_telefone = @telefone,
                                                                  tb_funcionarios_celular = @celular,
                                                                  tb_funcionarios_cep = @cep,
                                                                  tb_funcionarios_endereco = @endereco,
                                                                  tb_funcionarios_numero = @numero,
                                                                  tb_funcionarios_complemento = @complemento,
                                                                  tb_funcionarios_bairro = @bairro,
                                                                  tb_funcionarios_cidade = @cidade,
                                                                  tb_funcionarios_estado = @estado";

                MySqlCommand executaMySql_update_funcionarios = new MySqlCommand(sql_update_funcionario, con);


                executaMySql_update_funcionarios.Parameters.AddWithValue("@id", codigo);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@nome", nome);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@rg", rg);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@cpf", cpf);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@email", email);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@senha", senha);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@cargo", cargo);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@nivel", nivel);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@telefone", telefone);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@celular", celular);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@cep", cep);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@endereco", endereco);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@numero", numero);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@complemento", complemento);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@bairro", bairro);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@cidade", cidade);
                executaMySql_update_funcionarios.Parameters.AddWithValue("@estado", estado);


                executaMySql_update_funcionarios.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Atualização feita com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                Listar();
            }
            catch (Exception erro)
            {
                string mensagem = "Ocorreu um erro na sua atualização! Foi o erro: " + erro;

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void DgvListaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = DgvListaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = DgvListaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = DgvListaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = DgvListaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = DgvListaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = DgvListaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            txtcargo.Text = DgvListaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            txtnivel.Text = DgvListaFuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = DgvListaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = DgvListaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = DgvListaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = DgvListaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = DgvListaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = DgvListaFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = DgvListaFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = DgvListaFuncionarios.CurrentRow.Cells[15].Value.ToString();
            txtestado.Text = DgvListaFuncionarios.CurrentRow.Cells[16].Value.ToString();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr1 = MessageBox.Show("Deseja realmente excluir esse cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr1 == DialogResult.Yes)
                {
                    DialogResult dr2 = MessageBox.Show("Tem certeza disso?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        MySqlConnection con = new MySqlConnection(conexao);


                        int id = int.Parse(txtcodigo.Text);

                        string sql_delete_funcionarios = @"delete from tb_funcionarios   
                                                      where tb_funcionarios_id = @id";

                        con.Open();

                        MySqlCommand executacmdMySql_delete_fornecedor = new MySqlCommand(sql_delete_funcionarios, con);

                        executacmdMySql_delete_fornecedor.Parameters.AddWithValue("@id", id);


                        executacmdMySql_delete_fornecedor.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Funcionario excluido com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);






                    }

                    else
                    {
                        MessageBox.Show("Operação cancelada!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }

                else
                {
                    MessageBox.Show("Operação cancelada!", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception erro)
            {
                string mensagem = "Ocorreu um erro na sua exclusão! Foi o erro: " + erro;
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Listar();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            FrmInicio TelaInicio = new FrmInicio();
            this.Hide();
            TelaInicio.ShowDialog();
        }
    }
}
