using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;

namespace CadastroAlunoReciclarte.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        public Task<Endereco> BuscarCEP(string cep)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> BuscarEnderecoPorId(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Endereco> AdiconarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> AtualizarEndreco(Endereco endereco, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarEndereco(int id)
        {
            throw new NotImplementedException();
        }
    }
}
