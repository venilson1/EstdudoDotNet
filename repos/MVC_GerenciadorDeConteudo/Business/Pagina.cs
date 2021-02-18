using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pagina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Time { get; set; }

        public List<Pagina> Lista()
        {
            var lista = new List<Pagina>();
            var paginaDB = new Database.Pagina(); //retorna os dados do banco de dados 
            foreach (DataRow row in paginaDB.ListaBD().Rows)
            {
                //recebe os dados em formato string, precisando ser alterados
                var pagina = new Pagina();
                pagina.Id = Convert.ToInt32(row["id"]); //["id"] => headers do BD
                pagina.Nome = row["nome"].ToString(); //["nome"] => headers do BD
                pagina.Conteudo = row["conteudo"].ToString();//["conteu"] => headers do BD
                pagina.Time = Convert.ToDateTime(row["data"]);//["data"] => headers do BD

                lista.Add(pagina);
            }
            return lista; //envia esses dados para o controle
        }

        public void Save()
        {
            new Database.Pagina().Salvar(this.Id, this.Nome, this.Conteudo, this.Time);
        }
    }
}
