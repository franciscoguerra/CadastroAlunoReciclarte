using CadastroAlunoReciclarte.Model;

namespace CadastroAlunoReciclarte.Repositorios.Interfaces
{
    public interface ICursoRepositorio
    {
        Task<Curso> BuscarCursoPorId(int id);
        Task<Curso> BuscarTodosCursos();
        Task<Curso> AdionarCurso(Curso curso);
        Task<Curso> AtualizarCurso(Curso curso, int id);
        Task<bool> DeletarCurso(int id);

    }
}
