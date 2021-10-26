using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace U02Pa181G0250.Models
{
    public partial class villancicosContext : DbContext
    {
        public villancicosContext()
        {
        }

        public villancicosContext(DbContextOptions<villancicosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Villancico> Villancicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;password=Root;database=villancicos", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.25-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Villancico>(entity =>
            {
                entity.ToTable("villancico");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Compositor).HasMaxLength(50);

                entity.Property(e => e.Idioma).HasMaxLength(45);

                entity.Property(e => e.Información).HasColumnType("text");

                entity.Property(e => e.Letra)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VideoUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("VideoURL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
