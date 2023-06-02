namespace CadastroAlunoReciclarte.Model
{
    public class Turma
    {
        public int Id { get; set; }
        public string? Classe { get; set; }
        public string? Turno { get; set; }
        public DateTime AnoLetivo { get; set; }
        public int IdAluno { get; set; }
        public IList<Aluno>? Alunos { get; set; }
        public int QuantidadeAlunos { get; set; }
        public bool Status { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }

        public void NaoEcluirTurma()
        {
            if(IdAluno != 0)
            {
                throw new Exception("Não é possivel excluir Classe associado a alunos");
            }
        }
 
        public void QtdsAlunos()
        {
            if(QuantidadeAlunos < IdAluno)
            {
                throw new Exception("Não é possivel adiconar aluno, turma com valor maxímo de Alunos");
            }
        }

        public void CadastroAluno()
        {
            if(String.IsNullOrEmpty(Classe)) 
            {
                throw new Exception("E obrigatorio o aluno está vinculado a uma turma!");
            }
        }

    }
}
