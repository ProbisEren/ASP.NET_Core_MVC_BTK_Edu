using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
 {
    public class RepositoryContext :DbContext // bu class veritabanı gibi işlem görücek, veritabanı gibi düşün burayı
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options ) // constructor
        : base (options)
        {
            
        }
    }
 }