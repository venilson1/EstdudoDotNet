using System.Collections.Generic;
namespace SmartSchool_WebAPI.Models
{
    public class Professor
    {
        public Professor(int _id, string _nome)
        {
            this.Id = _id;
            this.Nome = _nome;

        }
        public Professor(){}
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}