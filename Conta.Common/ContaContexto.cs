//using Conta.Dominio.Entidade;
//using Microsoft.EntityFrameworkCore;

//namespace Conta.Common
//{
//    public class ContaContexto : DbContext
//    {
//        public DbSet<ContaBancaria> ContaBancarias { get; set; }
//        public DbSet<Banco> Bancos { get; set; }

//        public ContaContexto(DbContextOptions options) : base(options)
//        { }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {   
            
//            modelBuilder.ApplyConfiguration(new BancoMap());
//            modelBuilder.ApplyConfiguration(new ContaBancariaMap());
            
//            base.OnModelCreating(modelBuilder);
//        }
//    }
//}
