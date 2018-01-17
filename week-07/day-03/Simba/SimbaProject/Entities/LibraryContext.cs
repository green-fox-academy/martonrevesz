using Microsoft.EntityFrameworkCore;
using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Entities
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookReader>()
           .HasKey(br => new { br.BookId, br.ReaderId });

            modelBuilder.Entity<BookReader>()
                .HasOne(br => br.Book)
                .WithMany(b => b.BookReaders)
                .HasPrincipalKey(b => b.BookId);

            modelBuilder.Entity<BookReader>()
                .HasOne(br => br.Reader)
                .WithMany(r => r.BooksReaders)
                .HasPrincipalKey(b => b.ReaderId);
        }
    }
}
