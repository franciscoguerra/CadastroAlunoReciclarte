using CadastroAlunoReciclarte.Map;
using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;
using CadastroAlunoReciclarte.Context;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly CadastroAlunoReciclarteDbContext _dbContext;
        public AlunoRepositorio(CadastroAlunoReciclarteDbContext cadastroAlunoReciclarteDbContext)
        {
            _dbContext = cadastroAlunoReciclarteDbContext;
        }

        public async Task<List<Aluno>> IBuscarTodosAlunos()
        {
            return await _dbContext.Alunos.ToListAsync();
        }

        public async Task<Aluno> BuscarAlunoPorId(int id)
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Id == id);
            
        }

        public async Task<Aluno> BuscarAlunoCPF(string cpf)
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Cpf == cpf);
        }

        public async Task<Aluno> BuscarAlunoPorNome(string nome)
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Nome == nome);
        }

        public async Task<List<Aluno>> BuscarTodosAlunos()
        {
            return await _dbContext.Alunos.ToListAsync();
        }

        public async Task<Aluno> CadastrarAluno(Aluno aluno)
        {
            await _dbContext.Alunos.AddAsync(aluno);
            await _dbContext.SaveChangesAsync();

            return aluno;
        }
        public async Task<Aluno> AtualizarAluno(Aluno aluno, int id)
        {
            Aluno buscarAlunoPorId = await BuscarAlunoPorId(id);
            if(buscarAlunoPorId == null) 
            {
                throw new Exception($"Aluno não encontrada para esse ID:{id}");
            }

            buscarAlunoPorId.Nome= aluno.Nome;
            buscarAlunoPorId.DataNascimento = aluno.DataNascimento;
            buscarAlunoPorId.Sexo= aluno.Sexo;
            buscarAlunoPorId.Rg= aluno.Rg;
            buscarAlunoPorId.EmissorRg= aluno.EmissorRg;
            //buscarAlunoPorId.Cpf = aluno.Cpf;
            buscarAlunoPorId.Nacionalidade=aluno.Nacionalidade;
            buscarAlunoPorId.CorRaca= aluno.CorRaca;
            buscarAlunoPorId.CodigoINEP= aluno.CodigoINEP;
            buscarAlunoPorId.CartaoSUS= aluno.CartaoSUS;
            buscarAlunoPorId.Situacao= aluno.Situacao;
            buscarAlunoPorId.Etapa= aluno.Etapa;
            buscarAlunoPorId.TurmaId= aluno.TurmaId;
            buscarAlunoPorId.EscolaId= aluno.EscolaId;
            buscarAlunoPorId.EnderecoId= aluno.EnderecoId;
            buscarAlunoPorId.FiliacaoId= aluno.FiliacaoId;

            _dbContext.Update(buscarAlunoPorId);
            await _dbContext.SaveChangesAsync();

            return buscarAlunoPorId;

        }

        public async Task<bool> DeletarAluno(int id)
        {
            Aluno buscarPorId = await BuscarAlunoPorId(id);
            if(buscarPorId == null )
            {
                throw new Exception($"Aluno não encontrado para esse ID:{id}");
            }

            _dbContext.Remove(buscarPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //Task<Aluno> IAlunoRepositorio.BuscarTodosAlunos()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
