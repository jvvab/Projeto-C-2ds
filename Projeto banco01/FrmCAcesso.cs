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
    public partial class FrmCAcesso : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        public FrmCAcesso()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome, email, email2, senha, senha2;

            nome = txtnome.Text;
            email = txtemail.Text;
            email2 = txtemail2.Text;
            senha = txtsenha.Text;
            senha2 = txtsenha2.Text;


            try
            {
                if (email == email2 && senha == senha2)
                {
                    MySqlConnection con = new MySqlConnection(conexao);


                    string sql = @"insert into tb_usuarios(nome, email, email2, senha, senha2) 
                                            values(@nome, @email, @email2, @senha, @senha2)";


                    MySqlCommand executa = new MySqlCommand(sql, con);


                    executa.Parameters.AddWithValue("@nome", nome);
                    executa.Parameters.AddWithValue("@email", email);
                    executa.Parameters.AddWithValue("@email2", email2);
                    executa.Parameters.AddWithValue("@senha", senha);
                    executa.Parameters.AddWithValue("@senha2", senha2);


                    con.Open();


                    executa.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Acesso cadastrado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("As credenciais nao batem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch (Exception erro)
            {
                string mensagem = "Ocorreu um erro no seu cadastro! Foi o erro: " + erro;
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
