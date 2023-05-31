namespace CadastroAlunoReciclarte.Model
{
    public class Turma
    {
        public int Id { get; set; }
        public string Classe { get; set; }
        public string Turno { get; set; }
        public DateTime AnoLetivo { get; set; }
        public int IdAluno { get; set; }
        public IList<Aluno>? Alunos { get; set; }
        public bool Status { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }

    }
}
