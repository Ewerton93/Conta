using Conta.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conta.Dados.Mapeamento
{
    public class ContaBancariaMap : IEntityTypeConfiguration<ContaBancaria>
    {
        public void Configure(EntityTypeBuilder<ContaBancaria> builder)
        {
            builder.HasKey(fp => fp.Id);


            builder.HasOne(pe => pe.Banco);

            builder
                .Property(fp => fp.NumeroConta)
                .IsRequired()
                .HasMaxLength(50);

            builder
               .Property(fp => fp.NumeroAgencia)
               .IsRequired()
               .HasMaxLength(50);

            builder
               .Property(fp => fp.NumeroAgencia)
               .IsRequired()
               .HasMaxLength(50);

            builder
                .Property(fp => fp.Cpf)
                .HasMaxLength(100);

            builder
               .Property(fp => fp.Cnpj)
               .HasMaxLength(100);

            builder
               .Property(fp => fp.Nome)
               .HasMaxLength(100);

            builder
               .Property(fp => fp.RazaoSocial)
               .HasMaxLength(100);

        }
    }
}
