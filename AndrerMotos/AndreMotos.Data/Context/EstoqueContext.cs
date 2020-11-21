using AndreMotos.Dominio.EstoqueRoot;
using System.Configuration;
using System.Data.Entity;

namespace AndreMotos.Data.Context
{
    public class EstoqueContext : DbContext
    {

        public EstoqueContext() : base(ConfigurationManager.ConnectionStrings["StrConexao"].ConnectionString)
        {

        }

       // public static DbCompiledModel StrConexao { get; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produtos");

            modelBuilder.Entity<Produto>().HasKey(pk => pk.ID);

            modelBuilder.Entity<Produto>()
              .Property(p => p.ID)
              .HasColumnName("ID")
              .HasColumnType("int")
              .IsRequired()
              .HasColumnOrder(1);

            modelBuilder.Entity<Produto>()
              .Property(p => p.ID)
              .HasColumnName("ID")
              .HasColumnType("int")
              .IsRequired()
              .HasColumnOrder(2);

            modelBuilder.Entity<Produto>()
              .Property(p => p.NomeProduto)
              .HasColumnName("NomeProduto")
              .HasColumnType("varchar")
              .HasMaxLength(150)
              .IsRequired()
              .HasColumnOrder(3);

            modelBuilder.Entity<Produto>()
             .Property(p => p.CodigoProduto)
             .HasColumnName("CodigoProduto")
             .HasColumnType("int")
             .IsRequired()
             .HasColumnOrder(4);

            modelBuilder.Entity<Produto>()
             .Property(p => p.ValorUnitario)
             .HasColumnName("ValorUnitario")
             .HasColumnType("float")
             .IsRequired()
             .HasColumnOrder(5);

            modelBuilder.Entity<Produto>()
             .Property(p => p.Descricao)
             .HasColumnName("Descricao")
             .HasColumnType("varchar")
             .HasMaxLength(150)
             .IsRequired()
             .HasColumnOrder(6);


            base.OnModelCreating(modelBuilder);
        }
    }
}
