using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroAlunoReciclarte.Data.Map
{
    public class FiliacaoMap : IEntityTypeConfiguration<Filiacao>

    {
        public void Configure(EntityTypeBuilder<Filiacao> builder)
        {
            builder.HasKey( x => x.Id);
            builder.Property(x => x.NomePai);
            builder.Property(x => x.NomeMae);
            builder.Property(x => x.Cpf);
            builder.Property(x => x.Profissao);
            builder.Property(x => x.Status);
        }
    }
}
