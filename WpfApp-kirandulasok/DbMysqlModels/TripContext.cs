using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WpfApp1.DbMysqlModels;

public partial class TripContext : DbContext
{
    public TripContext()
    {
    }

    public TripContext(DbContextOptions<TripContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Trip> Trips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=trip;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_hungarian_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Trip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("trip")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Desposit)
                .HasColumnType("int(5)")
                .HasColumnName("desposit");
            entity.Property(e => e.Gender).HasMaxLength(6);
            entity.Property(e => e.HasMedicalNote).HasMaxLength(5);
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
