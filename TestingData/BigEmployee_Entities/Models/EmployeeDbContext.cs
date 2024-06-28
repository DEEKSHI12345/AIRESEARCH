using System;
using System.Collections.Generic;
using BigEmployee_PL.BigEmployee_Entities;
using Microsoft.EntityFrameworkCore;

namespace BigEmployee_PL.BigEmployee_DAL;

public partial class EmployeeDbContext : DbContext
{
    public EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeDataRecord> EmployeeDataRecords { get; set; }

   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.20.12.197;Initial Catalog=ReportingTool;User ID=reportuser;Password=reportpassword;TrustServerCertificate=yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeDataRecord>(entity =>
        {
            entity.HasKey(e => e.EmplId).HasName("PK__Employee__D33EA41DF24EFFC2");

            entity.ToTable("EmployeeDataRecord");

            entity.Property(e => e.EmplId).HasColumnName("emplId");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EverBenched)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LeaveOrNot)
                .HasMaxLength(10)
                .IsUnicode(false);
        });



        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
