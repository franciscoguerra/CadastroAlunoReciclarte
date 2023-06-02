using CadastroAlunoReciclarte.Model;

namespace CadastroAlunoReciclarte.Repositorios.Interfaces
{
    public interface ITurmaRepositorio
    {
        Task<Turma> BuscarTurmasId(int id);
        Task<Turma> BuscarTodasTurmas();
        Task<Turma> AdiconarTurma(Turma turma);
        Task<Turma> AtualizarTurma(Turma turma, int id);
        Task<bool> DeletarTurma(int id);
    }
}
