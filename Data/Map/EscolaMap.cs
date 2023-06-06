using CadastroAlunoReciclarte.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroAlunoReciclarte.Data.Map
{
    public class EscolaMap : IEntityTypeConfiguration<Escola>
    {
        public void Configure(EntityTypeBuilder<Escola> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome);
            builder.Property(e => e.DataMatricula);
            builder.Property(e => e.Transporte);
            builder.Property(e => e.AtvPropostaPelaEscola);
            builder.Property(e => e.Beneficios);
            builder.Property(e => e.Regresso);
            builder.Property(e => e.AlertaEmergencia);
            builder.Property(e => e.PortadorNescessidades);
            builder.Property(e => e.Status);
        }
    }
}
