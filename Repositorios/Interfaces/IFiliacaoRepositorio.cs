using CadastroAlunoReciclarte.Model;

namespace CadastroAlunoReciclarte.Repositorios.Interfaces
{
    public interface IFiliacaoRepositorio
    {
        Task<Filiacao> BuscarFiliacaoId(int id);
        Task<Filiacao> BuscarFiliacaoCpf(string cpf);

        Task<Filiacao>  AdicionarFiliacao(Filiacao filiacao);
        Task<Filiacao> AtualizarFiliacao(Filiacao filiacao, int id);
        Task<bool> DeletarFiliacao(int id);
    }
}
