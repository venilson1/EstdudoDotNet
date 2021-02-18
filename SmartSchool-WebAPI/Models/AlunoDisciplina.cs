namespace SmartSchool_WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }
        public AlunoDisciplina(int _alunoId, Aluno _aluno, int _disciplinaId, Disciplina _disciplina)
        {
            this.AlunoId = _alunoId;
            this.Aluno = _aluno;
            this.DisciplinaId = _disciplinaId;
            this.Disciplina = _disciplina;

        }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}