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
    public partial class FrmLogin : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection(conexao);

                string email, senha;

                email = txtemail.Text;
                senha = txtsenha.Text;



                string sql = @"select * from tb_usuarios where email = @email and senha = @senha";


                MySqlCommand select = new MySqlCommand(sql, con);

                select.Parameters.AddWithValue("@email", email);
                select.Parameters.AddWithValue("@senha", senha);


                con.Open();

                MySqlDataReader dr = select.ExecuteReader();

                if (dr.Read()) 
                {

                    MessageBox.Show("Logado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("Bem vindo ao sistema!", "Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    FrmInicio TelaInicio = new FrmInicio();

                    this.Hide();
                    TelaInicio.Show();

                }
                else
                {
                    MessageBox.Show("Dados inseridos nao foram encontrados no nosso sistema!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }






            }
            catch (Exception erro)
            {


                string mensagem = "Ocorreu um erro no seu login! Foi o erro: " + erro;
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
