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
           // builder.Property(x => x.Horarios).UseCollation("en-US");
        }
    }
}
