using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;

namespace CadastroAlunoReciclarte.Repositorios
{
    public class CursoRepositorio : ICursoRepositorio
    {
        public Task<Curso> BuscarCursoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Curso> BuscarTodosCursos()
        {
            throw new NotImplementedException();
        }
        public Task<Curso> AdionarCurso(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Task<Curso> AtualizarCurso(Curso curso, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarCurso(int id)
        {
            throw new NotImplementedException();
        }
    }
}
