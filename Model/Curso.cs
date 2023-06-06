using System.Numerics;

namespace CadastroAlunoReciclarte.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Professor { get; set; }
        public int CargaHoraria { get; set; }
        public int Modulos { get; set; }
        public bool Status { get; set; }
        public DateTime Horarios { get; set; }
        public IList<Aluno>? Alunos { get; set; }
        public IList<Turma>? Turmas { get; set; }  

        

        public void NaoExcluirCurso()
        {
            int turma = Turmas.Count;
            
            if(turma !=0)
            {
                throw new Exception("não é possivel excluir o curso associado a uma turma!");
            }

        }
    }
}
