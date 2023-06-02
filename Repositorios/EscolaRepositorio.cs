using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;

namespace CadastroAlunoReciclarte.Repositorios
{
    public class EscolaRepositorio : IEscolaRepositorio
    {
        public Task<Escola> BuscarEscolaId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Escola> BuscarTodasEscolas()
        {
            throw new NotImplementedException();
        }

        public Task<Escola> AdiconarEscola(Escola escola)
        {
            throw new NotImplementedException();
        }

        public Task<Escola> AtualizarEscola(Escola escola, int id)
        {
            throw new NotImplementedException();
        }

      
        public Task<bool> DeletarEscola(int id)
        {
            throw new NotImplementedException();
        }
    }
}
