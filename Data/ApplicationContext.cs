using exemplo_dotnet_efcore.Domain;
using Microsoft.EntityFrameworkCore;

namespace exemplo_dotnet_efcore.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=SqlEFCore; Integrated Security=true");
        }
    }
}