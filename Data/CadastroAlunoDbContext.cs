
using CadastroAlunoReciclarte.Data.Map;
using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Map
{
    public class CadastroAlunoDbContext : DbContext
    {
        public CadastroAlunoDbContext(DbContextOptions<CadastroAlunoDbContext> options)
            :base(options) 
        { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Filiacao> Filiacaos { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new AlunoMap());
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
