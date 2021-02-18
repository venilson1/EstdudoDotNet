using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pagina
    {
        private string MySqlConnection()
        {
            return ConfigurationManager.AppSettings["MySqlConnection"];
        }

        public DataTable ListaBD()
        {
            MySqlConnection connection = new MySqlConnection(MySqlConnection());
            
                string queryString = "select * from paginas";

                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                
                DataTable table = new DataTable();
                adapter.Fill(table); //opens and closes the DB connection automatically !! (fetches from pool)
                return table; //envia esses dados para Business
        }

        public void Salvar(int id, string nome, string conteudo, DateTime time) 
        {
            MySqlConnection connection = new MySqlConnection(MySqlConnection());

            string queryString = "insert into paginas(nome, data, conteudo) values('"+ nome +"','" + time.ToString("yyyy-MM-dd HH:mm:ss") +"','" + conteudo +"')";
            if(id != 0)
            {
                queryString = "UPDATE `paginas` SET nome='"+ nome+ "', Conteudo='" + conteudo + "', Data='" + time.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=" + id;
            }
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
