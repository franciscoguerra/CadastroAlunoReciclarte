using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroAlunoReciclarte.Data.Map
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.Sexo).IsRequired();
            builder.Property(x => x.Rg).IsRequired();
            builder.Property(x => x.EmissorRg).IsRequired();
            builder.Property(x => x.cpf).IsRequired();
            builder.Property(x => x.Nacionalidade).IsRequired();
            builder.Property(x => x.CorRaca).IsRequired();
            builder.Property(x => x.CodigoINEP).IsRequired();
            builder.Property(x => x.CartaoSUS).IsRequired();
            builder.Property(x => x.Situacao).IsRequired();
            builder.Property(x => x.Etapa).IsRequired();
            builder.Property(X => X.Status).IsRequired();
           
        }
    }
}
