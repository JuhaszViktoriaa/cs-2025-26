using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyExam.Desktop.DbSqliteModels;

public partial class RestaurantsContext : DbContext
{
    public RestaurantsContext()
    {
    }

    public RestaurantsContext(DbContextOptions<RestaurantsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=restaurants.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("restaurants");

            entity.Property(e => e.Id).HasColumnType("INT");
            entity.Property(e => e.Income).HasColumnType("INT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
