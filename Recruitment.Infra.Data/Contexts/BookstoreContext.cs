using Microsoft.EntityFrameworkCore;
using Recruitment.Domain.Entities;
using Recruitment.Infra.Data.Mappings;

namespace Recruitment.Infra.Data.Contexts
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext()
        {

        }

        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            :base(options)
        { }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=saulo-server.database.windows.net;Database=hbsis;Uid=saulomoura;Pwd=!Hbsis@Recruitment!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>(new BookstoreMap().Configure);
        }
    }
}
