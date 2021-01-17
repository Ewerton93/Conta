using Conta.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conta.Dados.Mapeamento
{
    public class BancoMap : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.HasKey(fp => fp.Id);


            builder
                .Property(fp => fp.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder
               .Property(fp => fp.Descricao)
               .IsRequired()
               .HasMaxLength(50);
        }

    }
}
