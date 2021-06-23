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
    public partial class FrmFornecedores : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;

        public FrmFornecedores()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            //Recarregar itens da tabela
            try
            {

                //1 passo - conexao com banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //2 passo montar e executar o comando sql
                string sql_select_fornecedores = "select * from tb_fornecedores";

                //3 passo montar e organizar o comando sql
                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_fornecedores, con);
                con.Open();
                executacmdMySql_select.ExecuteNonQuery();


                //4 passo criar uma data table
                DataTable tabela_fornecedores = new DataTable();

                //5 passo criar o MySqlDataAdapter
                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select);

                da_cliente.Fill(tabela_fornecedores);

                //6 passo exicbir o data table no datagridview
                DgvListaFornecedores.DataSource = tabela_fornecedores;

                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu o erro: " + erro);
            }
        }




        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexao com o banco de dados
                MySqlConnection con = new MySqlConnection(conexao);


                //2 passo pegar os dados da tela

                string nome, cnpj, email, telefone, celular, cep, endereco, complemento, bairro, cidade, estado;
                int numero;


                nome = txtnome.Text;
                cnpj = txtcnpj.Text;
                email = txtemail.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text;
                cep = txtcep.Text;
                endereco = txtendereco.Text;
                numero = int.Parse(txtnumero.Text);
                complemento = txtcomplemento.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                estado = txtestado.Text;


                // montar o comando sql
                string sql_insert = @"insert into tb_fornecedores(tb_fornecedores_nome,
                                                                  tb_fornecedores_cnpj,
                                                                  tb_fornecedores_email,
                                                                  tb_fornecedores_telefone,
                                                                  tb_fornecedores_celular,
                                                                  tb_fornecedores_cep,
                                                                  tb_fornecedores_endereco,
                                                                  tb_fornecedores_numero,
                                                                  tb_fornecedores_complemento,
                                                                  tb_fornecedores_bairro,
                                                                  tb_fornecedores_cidade,
                                                                  tb_fornecedores_estado )
                                                           values(@nome, 
                                                                  @cnpj, 
                                                                  @email,
                                                                  @telefone,
                                                                  @celular,
                                                                  @cep,
                                                                  @endereco,
                                                                  @numero,
                                                                  @complemento,
                                                                  @bairro,
                                                                  @cidade,
                                                                  @estado)";


                // Montar e organizar o comando sql
                MySqlCommand executacmdMysql_insert = new MySqlCommand(sql_insert, con);
                executacmdMysql_insert.Parameters.AddWithValue("@nome", nome);
                executacmdMysql_insert.Parameters.AddWithValue("@cnpj", cnpj);
                executacmdMysql_insert.Parameters.AddWithValue("@email", email);
                executacmdMysql_insert.Parameters.AddWithValue("@telefone", telefone);
                executacmdMysql_insert.Parameters.AddWithValue("@celular", celular);
                executacmdMysql_insert.Parameters.AddWithValue("@cep", cep);
                executacmdMysql_insert.Parameters.AddWithValue("@endereco", endereco);
                executacmdMysql_insert.Parameters.AddWithValue("@numero", numero);
                executacmdMysql_insert.Parameters.AddWithValue("@complemento", complemento);
                executacmdMysql_insert.Parameters.AddWithValue("@bairro", bairro);
                executacmdMysql_insert.Parameters.AddWithValue("@cidade", cidade);
                executacmdMysql_insert.Parameters.AddWithValue("@estado", estado);

                //abri a conexao
                con.Open();

                //Executa comando sql
                executacmdMysql_insert.ExecuteNonQuery();

                // fechar conexao
                con.Close();
                MessageBox.Show("Fornecedor cadastrado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);




            }
            catch (Exception erro)
            {
                string mensagem = "Ocorreu um erro no seu cadastro! Foi o erro: " + erro;

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Listar();


        }

        private void DgvListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = DgvListaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = DgvListaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = DgvListaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = DgvListaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = DgvListaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = DgvListaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = DgvListaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = DgvListaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = DgvListaFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = DgvListaFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = DgvListaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = DgvListaFornecedores.CurrentRow.Cells[11].Value.ToString();
            txtestado.Text = DgvListaFornecedores.CurrentRow.Cells[12].Value.ToString();
        }

        private void Btnatt_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, cnpj, email, telefone, celular, cep, endereco, complemento, bairro, cidade, estado;
                int codigo, numero;

                codigo = int.Parse(txtcodigo.Text);
                nome = txtnome.Text;
                cnpj = txtcnpj.Text;
                email = txtemail.Text;
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

                string sql_update_fornecedores = @"update tb_fornecedores set 
                                                                  tb_fornecedores_nome = @nome,
                                                                  tb_fornecedores_cnpj = @cnpj,
                                                                  tb_fornecedores_email = @email,
                                                                  tb_fornecedores_telefone = @telefone,
                                                                  tb_fornecedores_celular = @celular,
                                                                  tb_fornecedores_cep = @cep,
                                                                  tb_fornecedores_endereco = @endereco,
                                                                  tb_fornecedores_numero = @numero,
                                                                  tb_fornecedores_complemento = @complemento,
                                                                  tb_fornecedores_bairro = @bairro,
                                                                  tb_fornecedores_cidade = @cidade,
                                                                  tb_fornecedores_estado = @estado
                                                                  where tb_fornecedores_id = @id";

                MySqlCommand executaMySql_update_fornecedores = new MySqlCommand(sql_update_fornecedores, con);

                executaMySql_update_fornecedores.Parameters.AddWithValue("@id", codigo);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@nome", nome);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@cnpj", cnpj);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@email", email);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@telefone", telefone);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@celular", celular);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@cep", cep);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@endereco", endereco);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@numero", numero);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@complemento", complemento);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@bairro", bairro);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@cidade", cidade);
                executaMySql_update_fornecedores.Parameters.AddWithValue("@estado", estado);




                executaMySql_update_fornecedores.ExecuteNonQuery();
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

                        string sql_delete_fornecedor = @"delete from tb_fornecedores   
                                                      where tb_fornecedores_id = @id";

                        con.Open();

                        MySqlCommand executacmdMySql_delete_fornecedor = new MySqlCommand(sql_delete_fornecedor, con);

                        executacmdMySql_delete_fornecedor.Parameters.AddWithValue("@id", id);


                        executacmdMySql_delete_fornecedor.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Fornecedor excluido com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);






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
