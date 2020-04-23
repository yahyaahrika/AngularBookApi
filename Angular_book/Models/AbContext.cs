using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular_book.Models
{
    public partial class AbContext : DbContext
    {
        public AbContext()
        {
        }

        public AbContext(DbContextOptions<AbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning 
//                //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("server=DESKTOP-HA0PHG4; database=Ab; integrated security=true");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Book>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.Author)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id)
//                    .HasColumnName("id")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.PublishedAt).HasColumnType("datetime");

//                entity.Property(e => e.Title)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
