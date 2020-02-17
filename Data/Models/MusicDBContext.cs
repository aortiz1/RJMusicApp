using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Models
{
    public partial class MusicDBContext : DbContext
    {
        public MusicDBContext()
        {
        }

        public MusicDBContext(DbContextOptions<MusicDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<AlbumArtist> AlbumArtist { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<ArtistGenre> ArtistGenre { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Label> Label { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=scm-ws044;Database=MusicDB;user id=devlocal;password=@Dev.Scio.19;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlbumArtist>(entity =>
            {
                entity.ToTable("Album_Artist");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumArtist)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_Album_Artist_Album");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.AlbumArtist)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_Album_Artist_Artist");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtistGenre>(entity =>
            {
                entity.ToTable("Artist_Genre");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistGenre)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_Artist_Genre_Artist");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.ArtistGenre)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_Artist_Genre_Genre");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

          
        }
    }
}
