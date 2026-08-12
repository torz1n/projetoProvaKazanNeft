using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace primeiraProva
{
    public partial class Form1 : Form
    {
        static string conexaoString = @"Server =.\sqlexpress;Database=Session2;Trusted_Connection=TRUE;";
        SqlConnection conexao = new SqlConnection(conexaoString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                conexao.Open();
                MessageBox.Show("Conexão bem-sucedida!");
            }
            catch (Exception mensagemErro)//mensagem exibida caso o try não for executado
            {
                MessageBox.Show("Erro ao conectar: " + mensagemErro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //define a query do banco de dados
            string queryBanco = "SELECT isAdmin FROM Employees WHERE Username = @usuario AND Password = @senha AND Username IS NOT NULL";

            SqlCommand comando = new SqlCommand(queryBanco, conexao); //quero executar um comandoBancoDeDados, com tal descrição e nessa conexão.
            //Para dar valor para @usuario e @senha, dependendo do que o usuario digitou
            comando.Parameters.AddWithValue("@usuario", txtUsuarioLogin.Text);
            comando.Parameters.AddWithValue("@senha", txtSenhaLogin.Text);

            try
            {
                //abre a conexão com o banco
                conexao.Open();
                SqlDataReader leitorDados = comando.ExecuteReader();//mande o comando definido para o banco ler ele

                if (leitorDados.Read())
                {
                    MessageBox.Show($"Bem Vindo{txtUsuarioLogin.Text}");
                    // [ ] é um indexador
                    bool administrador = (bool)leitorDados["isAdmin"];
                    //criar as telas para responsavel ou gerente com if/else
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorretos!");
                }
            }
            catch (Exception erroAoTentar)
            {
                //verifica se existe algum erro caso o try não rode
                MessageBox.Show("Erro: " + (erroAoTentar.Message)); //precisa acompanhar "Message" pois o texto só precisa receber uma string, nao outras informacoes do erro

            }
            finally
            {
                conexao.Close();
            }
                
            
        }

        private void botaoCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
