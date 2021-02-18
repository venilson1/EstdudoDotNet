using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Crudzin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
            {

            try 
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud; password=''");
                connection.Open();

                command.Parameters.Clear();
                MySqlCommand command = new MySqlCommand(
                    "insert into paciente (" +
                    "cod, " +
                    "nome, " +
                    "estado, " +
                    "cidade, " +
                    "endereco) " +
                    "values(null, ?, ?, ?, ?)", connection);
                
                command.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                command.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = txtEstado.Text;
                command.Parameters.Add("@cidade", MySqlDbType.VarChar, 20).Value = txtCidade.Text;
                command.Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = txtEndereco.Text;

                //executar QUERIE
                command.ExecuteNonQuery();
                MessageBox.Show("Sucesso!");
                connection.Close();
                
            }
            catch
            {
                MessageBox.Show("Não Conectou");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud; password=''");
                connection.Open();

                MySqlCommand command = new MySqlCommand("delete from paciente where cod = ?", connection);
                command.Parameters.Clear();


                command.Parameters.Add("@cod", MySqlDbType.Int32).Value = txtCode.Text;


                //Tipo de comando que estamos trabalhando
                command.CommandType = CommandType.Text;
                //executar QUERIE
                command.ExecuteNonQuery();
                
                
                connection.Close();
                MessageBox.Show("Registro Removido");
            }
            catch(Exception err)
            {
                MessageBox.Show($"Não foi possivel deletar {err}");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud; password=''");
                connection.Open();

                MySqlCommand command = new MySqlCommand("select nome, estado, cidade, endereco from paciente where cod = ?", connection);
                command.Parameters.Clear();
                command.Parameters.Add("@cod", MySqlDbType.Int32).Value = txtCode.Text;

                //executar comando
                command.CommandType = CommandType.Text;

                //receber conteudo vindo do Banco
                MySqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                dataReader.Read();

                //mostrar os dados do BD no Input
                txtNome.Text = dataReader.GetString(0);
                txtEstado.Text = dataReader.GetString(1);
                txtCidade.Text = dataReader.GetString(2);
                txtEndereco.Text = dataReader.GetString(3);



                connection.Close();
            }   
            catch
            {
                MessageBox.Show("Codigo Não encontrado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_crud; password=''");
                connection.Open();


                MySqlCommand command = new MySqlCommand(
                    "update paciente set " +
                    "nome = ?, " +
                    "estado = ?, " +
                    "cidade = ?, " +
                    "endereco = ? " +
                    "where cod = ?", connection);
                command.Parameters.Clear();

                command.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                command.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = txtEstado.Text;
                command.Parameters.Add("@cidade", MySqlDbType.VarChar, 20).Value = txtCidade.Text;
                command.Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = txtEndereco.Text;
                command.Parameters.Add("@cod", MySqlDbType.Int32).Value = txtCode.Text;

                //mostrando o tipo que estamos trabalhando e executando
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Atualização com sucesso");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao Atualizar" + err);
            }
        }

    }
}
