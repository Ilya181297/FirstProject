using Bloggers.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    internal class BloggersContext : DbContext
    {
        private readonly string _connectionString;
        public BloggersContext()
        {
            _connectionString = "Server = DESKTOP-F3VVNA6\\; Database = Bloggers; Trusted_Connection = true; TrustServerCertificate = True; ";
     //       Database.EnsureCreated();
        }
        public BloggersContext(DbContextOptions<BloggersContext> options)
            : base(options)
        { 
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Blogger> Blogger { get; set; }
        
    }
}
