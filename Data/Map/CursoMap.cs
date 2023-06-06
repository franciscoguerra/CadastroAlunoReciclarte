using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroAlunoReciclarte.Data.Map
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Professor);
            builder.Property(x => x.CargaHoraria);
            builder.Property(x => x.Modulos);
            builder.Property(x => x.Status);
            builder.Property(x => x.Horarios);
            builder.Property(X => X.Alunos);
            builder.Property(x => x.Turmas);

        }
    }
}
