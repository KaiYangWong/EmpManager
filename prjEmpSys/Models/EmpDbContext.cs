using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace prjEmpSys.Models;

public partial class EmpDbContext : DbContext
{
    public EmpDbContext()
    {
    }

    public EmpDbContext(DbContextOptions<EmpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TEmployee> TEmployees { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source= LAPTOP-UDKUA47I;Initial Catalog= Company;User ID=sa;Password=123456; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TEmployee>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("tEmployee");

            entity.Property(e => e.EmpId).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OnBoard).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
