using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace ClassFundProject.DbMysqlModels;

public partial class OsztalypenzContext : DbContext
{
    public OsztalypenzContext()
    {
    }

    public OsztalypenzContext(DbContextOptions<OsztalypenzContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classfund> Classfunds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=osztalypenz;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_hungarian_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Classfund>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("classfund")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasColumnType("int(5)")
                .HasColumnName("amount");
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .HasColumnName("month");
            entity.Property(e => e.StudentName)
                .HasMaxLength(12)
                .HasColumnName("studentName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
