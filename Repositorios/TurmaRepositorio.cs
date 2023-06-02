using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;

namespace CadastroAlunoReciclarte.Repositorios
{
    public class TurmaRepositorio : ITurmaRepositorio
    {

        public Task<Turma> BuscarTodasTurmas()
        {
            throw new NotImplementedException();
        }

        public Task<Turma> BuscarTurmasId(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Turma> AdiconarTurma(Turma turma)
        {
            throw new NotImplementedException();
        }

        public Task<Turma> AtualizarTurma(Turma turma, int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeletarTurma(int id)
        {
            throw new NotImplementedException();
        }
    }
}
