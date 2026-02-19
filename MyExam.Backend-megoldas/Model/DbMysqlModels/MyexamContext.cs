using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace MyExam.Backend.Model.DbMysqlModels;

public partial class MyexamContext : DbContext
{
    public MyexamContext()
    {
    }

    public MyexamContext(DbContextOptions<MyexamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FinalExam> FinalExams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseMySql("server=localhost;database=myexam;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_hungarian_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<FinalExam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("erettsegi")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Jegy)
                .HasColumnType("int(1)")
                .HasColumnName("jegy");
            entity.Property(e => e.Név)
                .HasMaxLength(13)
                .HasColumnName("név");
            entity.Property(e => e.Osztály)
                .HasMaxLength(4)
                .HasColumnName("osztály");
            entity.Property(e => e.Tantárgy)
                .HasMaxLength(10)
                .HasColumnName("tantárgy");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
