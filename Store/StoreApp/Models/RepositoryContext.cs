using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext // bu class veritabanı gibi işlem görücek, veritabanı gibi düşün burayı
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) // constructor
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData( // Migration çalıştırıldığında, bu tabloya otomatik olarak şu satırları da ekle
                      // Yani sen migration oluşturup dotnet ef database update çalıştırdığında:
                      // elle tekrar tekrar veri girmemek için 
                new Product() { ProductId = 1, ProductName = "Computer", ProductPrice = 1500 },
                new Product() { ProductId = 2, ProductName = "Keyboard ", ProductPrice = 1500 },
                new Product() { ProductId = 3, ProductName = "Phone", ProductPrice = 2000 }

            );
        }
    }
}