using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroAlunoReciclarte.Data.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Logradouro);
            builder.Property(e => e.Numero);
            builder.Property(e => e.Complemento);
            builder.Property(e => e.CEP);
            builder.Property(e => e.Contato);
            builder.Property(e => e.Bairro);
            builder.Property(e => e.Cidade);
            builder.Property(e => e.Status);


        }
    }
}
