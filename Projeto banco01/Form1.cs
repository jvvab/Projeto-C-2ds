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
    public partial class Form1 : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;


        public Form1()
        {
            InitializeComponent();
            ListarCliente();
        }


        public void ListarCliente()
        {
            //Recarregar itens da tabela
            try
            {

                //1 passo - conexao com banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //2 passo montar e executar o comando sql
                string sql_select_cliente = "select * from tb_cliente";

                //3 passo montar e organizar o comando sql
                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_cliente, con);
                con.Open();
                executacmdMySql_select.ExecuteNonQuery();


                //4 passo criar uma data table
                DataTable tabela_cliente = new DataTable();

                //5 passo criar o MySqlDataAdapter
                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select);

                da_cliente.Fill(tabela_cliente);

                //6 passo exicbir o data table no datagridview
                DgvListaCliente.DataSource = tabela_cliente;

                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu o erro: " + erro);
            }
        }




        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // Erros possiveis//
            lblnome2.Text = "";
            lblemail.Text = "";
            lbltel.Text = "";

            if (txtnome.Text =="" && txttelefone.Text =="" && txtemail.Text =="")
            {
                lblnome2.Text = "Digite um Nome";
                lbltel.Text = "Digite um Telefone";
                lblemail.Text = "Digite um Email";

            }

            else if (txtnome.Text == "" && txttelefone.Text =="")
            {
                lblnome2.Text = "Digite um Nome";
                lbltel.Text = "Digite um Telefone";
            }

            else if (txtnome.Text == "" && txtemail.Text == "")
            {
                lblnome2.Text = "Digite um Nome";
                lblemail.Text = "Digite um Email";
            }

            else if (txttelefone.Text == "" && txtemail.Text == "")
            {
                lbltel.Text = "Digite um Telefone";
                lblemail.Text = "Digite um Email";
            }

            else if (txtnome.Text == "" )
            {
                lblnome2.Text = "Digite um Nome";
            }

            else if (txttelefone.Text == "")
            {
                lbltel.Text = "Digite um Telefone";
            }

            else if (txtemail.Text == "")
            {
                lblemail.Text = "Digite um Email";
            }

            
            // Cadastrar Itens//
            else { 

            try
            {
                //Conexao com o banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //2 passo - pegar os dados da tela

                string nome, telefone, email;
                nome = txtnome.Text;
                telefone = txttelefone.Text;
                email = txtemail.Text;

                //3 passo - montar e executar o comando sql (Insert into)
                string sql_insert = @"insert into tb_cliente (tb_cliente_nome, tb_cliente_tel, tb_cliente_email) 
                                                            values (@cliente_nome, @cliente_tel, @cliente_email)";

                //Montar e organizar o comando
                MySqlCommand executacmdMysql_insert = new MySqlCommand(sql_insert, con);
                executacmdMysql_insert.Parameters.AddWithValue("@cliente_nome", nome);
                executacmdMysql_insert.Parameters.AddWithValue("@cliente_tel", telefone);
                executacmdMysql_insert.Parameters.AddWithValue("@cliente_email", email);

                //abri a conexao
                con.Open();

                //Executa comando sql
                executacmdMysql_insert.ExecuteNonQuery();


                //fechar a conexao
                con.Close();
                MessageBox.Show("Cliente Cadastrado com Sucesso!");



                txtnome.Text = "";
                txtemail.Text = "";
                txttelefone.Text = "";


                txtnome.Focus();



                lblnome2.Text = "";
                lblemail.Text = "";
                lbltel.Text = "";

            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu o erro: " + erro);
                
            }
            }

            ListarCliente();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnome.Focus();
        }

        private void DgvListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados de uma linha selecionada no data grid view

            txtcodigo.Text   = DgvListaCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text     = DgvListaCliente.CurrentRow.Cells[1].Value.ToString();
            txttelefone.Text = DgvListaCliente.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text    = DgvListaCliente.CurrentRow.Cells[3].Value.ToString();
        }

        private void Btnatt_Click(object sender, EventArgs e)
        {

            try
            {
                int codigo;
                string nome;
                string telefone;
                string email;


                codigo = int.Parse(txtcodigo.Text);
                nome = txtnome.Text;
                telefone = txttelefone.Text;
                email = txtemail.Text;



                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cliente = @"update tb_cliente
                                          set tb_cliente_nome = @nome,
                                              tb_cliente_tel = @tel,
                                              tb_cliente_email = @email
                                              where tb_cliente_id = @id";

                MySqlCommand executaMySql_Update_cliente = new MySqlCommand(sql_update_cliente, con);

                executaMySql_Update_cliente.Parameters.AddWithValue("@id", codigo);
                executaMySql_Update_cliente.Parameters.AddWithValue("@nome", nome);
                executaMySql_Update_cliente.Parameters.AddWithValue("@tel", telefone);
                executaMySql_Update_cliente.Parameters.AddWithValue("@email", email);

                executaMySql_Update_cliente.ExecuteNonQuery();

                MessageBox.Show("Atualização realizada com sucesso!!");
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu o erro: " + erro);
            }


            ListarCliente();
            











        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // botao excluir

            try
            {

                //1 conexao com o banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //2 receber os dados do cliente que sera excluido

                int id = int.Parse(txtcodigo.Text);

                string sql_delete_cliente = @"delete from tb_cliente
                                              where tb_cliente_id = @id";

                // abri a conexao
                con.Open();
                // Montar e organizar o sql command
                MySqlCommand executacmdMySql_delete = new MySqlCommand(sql_delete_cliente, con);

                executacmdMySql_delete.Parameters.AddWithValue("@id", id);

                //executar o comando

                executacmdMySql_delete.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Cliente excluido com sucesso!!");

                ListarCliente();


            }
            catch (Exception erro)
            {

                string mensagem = "Aconteceu o erro ao excluir. Erro: " + erro;
                MessageBox.Show(mensagem, "Atenção",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            FrmInicio TelaInicio = new FrmInicio();
            this.Hide();
            TelaInicio.ShowDialog();
        }
    }
}
