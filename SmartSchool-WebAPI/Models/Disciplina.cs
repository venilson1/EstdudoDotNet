using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Disciplina
    {
        public Disciplina(){ }
        public Disciplina(int _id, string _nome, int _professorId)
        {
            this.Id = _id;
            this.Nome = _nome;
            this.ProfessorId = _professorId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
    //Diciplina é vinculado a um professor
}