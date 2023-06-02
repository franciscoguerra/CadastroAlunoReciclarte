using CadastroAlunoReciclarte.Model;

namespace CadastroAlunoReciclarte.Repositorios.Interfaces
{
    public interface IEscolaRepositorio
    {
        Task<Escola> BuscarEscolaId(int id);
        Task<Escola> BuscarTodasEscolas();
        Task<Escola> AdiconarEscola(Escola escola);
        Task<Escola> AtualizarEscola(Escola escola, int id);
        Task<bool> DeletarEscola(int id); 
    }
}
