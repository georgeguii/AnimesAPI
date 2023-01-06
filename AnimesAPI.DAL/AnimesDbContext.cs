﻿using AnimesAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimesAPI.DAL
{
    public class AnimesDbContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = Environment.GetEnvironmentVariable("ANIMES_CONNECTION_STRING");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anime>(p =>
            {
                p.ToTable("Animes");
                p.HasKey(p => p.Id);
                p.Property(p => p.Name).HasMaxLength(40).IsRequired();  //Ele identifica automaticamente q é uma string
                p.Property(p => p.Resume).HasColumnType("VARCHAR(256)");
                p.Property(p => p.Status).HasConversion<int>().IsRequired();
                p.Property(p => p.Studio).HasColumnType("VARCHAR(50)");
                p.Property(p => p.Source).HasConversion<int>().IsRequired();
                p.Property(p => p.Director).HasMaxLength(40);
                p.Property(p => p.IsDeleted).HasColumnType("BIT");

                p.HasIndex(i => i.Name).IsUnique();
            });

            modelBuilder.Entity<Genre>(p =>
            {
                p.ToTable("Genres");
                p.HasKey(p => p.Id);
                p.Property(p => p.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<Anime>()
                .HasMany(p => p.Genres)
                .WithMany(p => p.Animes)
                .UsingEntity(j => j.ToTable("AnimeGenres"));
            }
    }
}
