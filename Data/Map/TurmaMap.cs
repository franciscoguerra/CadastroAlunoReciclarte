using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroAlunoReciclarte.Data.Map
{
    public class TurmaMap : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Classe);
            builder.Property(x => x.Turno);
            builder.Property(x => x.AnoLetivo);
            builder.Property(x => x.QuantidadeAlunos);
            builder.Property(x => x.Status);
            builder.Property(x => x.Curso);
        }
    }
}
