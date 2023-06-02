using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;

namespace CadastroAlunoReciclarte.Repositorios
{
    public class FiliacaoRepositorio : IFiliacaoRepositorio
    {
        public Task<Filiacao> BuscarFiliacaoCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<Filiacao> BuscarFiliacaoId(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Filiacao> AdicionarFiliacao(Filiacao filiacao)
        {
            throw new NotImplementedException();
        }

        public Task<Filiacao> AtualizarFiliacao(Filiacao filiacao, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarFiliacao(int id)
        {
            throw new NotImplementedException();
        }
    }
}
