using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Context
{
    public class CadastroAlunoReciclarteDbContext : DbContext
    {
        public CadastroAlunoReciclarteDbContext()
        {
        }

        public CadastroAlunoReciclarteDbContext(DbContextOptions<CadastroAlunoReciclarteDbContext> options) : base(options)
        { 
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Filiacao> Filiacaos { get; set; }
       
    }
}
