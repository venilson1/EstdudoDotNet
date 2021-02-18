using System.Collections.Generic;
namespace SmartSchool_WebAPI.Models
{
    public class Aluno
    {
        public Aluno(int _id, string _nome, string _sobrenome, string _telefone)
        {
            this.Id = _id;
            this.Nome = _nome;
            this.Sobrenome = _sobrenome;
            this.Telefone = _telefone;

        }

        public Aluno(){}
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}