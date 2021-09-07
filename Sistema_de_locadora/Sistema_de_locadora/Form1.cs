using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;//CONEXAO COM O BANCO DE DADOS
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_locadora
{
    public partial class FormLocadora : Form
    {
        public FormLocadora()
        {
            InitializeComponent();
        }
        //CONEXAO BANCO DE DADOS
        private MySqlConnectionStringBuilder conexaoBanco() //FUNÇÃO CHAMADA conexaoBanco QUE RETORNA O MySqlConnectonStringBuilder, O MySqkConnectionSpringBuilder É A CONEXÃO COM O BANCO DE DADOS
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();//CRIA UMA NOVA CONEXAO
            conexaoBD.Server = "localhost";//SERVIDOR
            conexaoBD.Database = "locadora";//BANCO DE DADOS
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;//RETORNA A CONEXAO COM O BANCO DE DADOS

        }

        private void FormLocadora_Load(object sender, EventArgs e)
        {
            atualizarDataGrid();//AO ABRIR O FORM IRA CHAMAR A FUNÇÃO atualizarDataGrid
        }

        private void atualizarDataGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM filmes WHERE ativoFilme = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dglocadora.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dglocadora.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//DESCRIÇÃO
                    row.Cells[3].Value = reader.GetString(3);//CATEGORIA
                    row.Cells[4].Value = reader.GetString(4);//ANO
                    dglocadora.Rows.Add(row);//ADICIONA A LINHA DA TABELA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não deu boa chefe");
                Console.WriteLine(ex.Message);
            }
        }

        private void limparCampos()
        {
            tbAno.Clear();
            tbNome.Clear();
            tbCategoria.Clear();
            tbDiscricao.Clear();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO filme (nomeFilme,categoriaFilme,descricaoFilme,anoLivro) " + "VALUES ('" + tbNome.Text + "', '" + tbCategoria.Text + "','" + tbDiscricao.Text + "', " + Convert.ToInt16(tbAno.Text) + ")";
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("Deu boa chefe");
                atualizarDataGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
