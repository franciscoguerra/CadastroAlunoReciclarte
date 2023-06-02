using CadastroAlunoReciclarte.Model;

namespace CadastroAlunoReciclarte.Repositorios.Interfaces
{
    public interface IEnderecoRepositorio
    {
        Task<Endereco>  BuscarEnderecoPorId(int id);
        Task<Endereco> BuscarCEP(string cep);
        Task<Endereco>  AdiconarEndereco(Endereco endereco); 
        Task<Endereco> AtualizarEndreco(Endereco endereco, int id);
        Task<bool> DeletarEndereco(int id);
    }
}
