using CadastroAlunoReciclarte.Model;

namespace CadastroAlunoReciclarte.Repositorios.Interfaces
{
    public interface IAlunoRepositorio
    {
        Task<Aluno> BuscarAlunoPorId(int id);
        Task<Aluno> BuscarAlunoPorNome(string nome);
        Task<List<Aluno>> BuscarTodosAlunos();
        Task<Aluno> BuscarAlunoCPF(string cpf);
        Task<Aluno> CadastrarAluno(Aluno aluno);
        Task<Aluno> AtualizarAluno(Aluno aluno, int id);
        Task<bool> DeletarAluno(int id);
    }
}

