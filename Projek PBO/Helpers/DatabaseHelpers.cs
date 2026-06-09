using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Projek_PBO.Models;

namespace Projek_PBO.Helpers;

public partial class DatabaseHelpers : DbContext
{
    public DatabaseHelpers()
    {
    }

    public DatabaseHelpers(DbContextOptions<DatabaseHelpers> options)
        : base(options)
    {
    }

    public virtual DbSet<Buah> Buahs { get; set; }

    public virtual DbSet<Kebun> Kebuns { get; set; }

    public virtual DbSet<Panen> Panens { get; set; }

    public virtual DbSet<Pengguna> Penggunas { get; set; }

    public virtual DbSet<Penjualan> Penjualans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Projek PBO;Username=postgres;Password=FATH354");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Buah>(entity =>
        {
            entity.HasKey(e => e.IdBuah).HasName("buah_pkey");

            entity.ToTable("buah");

            entity.Property(e => e.IdBuah).HasColumnName("id_buah");
            entity.Property(e => e.Harga).HasColumnName("harga");
            entity.Property(e => e.NamaBuah)
                .HasMaxLength(100)
                .HasColumnName("nama_buah");
            entity.Property(e => e.Satuan)
                .HasMaxLength(20)
                .HasDefaultValueSql("'kg'::character varying")
                .HasColumnName("satuan");
            entity.Property(e => e.Stock).HasColumnName("stock");
        });

        modelBuilder.Entity<Kebun>(entity =>
        {
            entity.HasKey(e => e.IdKebun).HasName("kebun_pkey");

            entity.ToTable("kebun");

            entity.Property(e => e.IdKebun).HasColumnName("id_kebun");
            entity.Property(e => e.Lokasi)
                .HasMaxLength(200)
                .HasColumnName("lokasi");
            entity.Property(e => e.Luas)
                .HasPrecision(10, 2)
                .HasColumnName("luas");
            entity.Property(e => e.NamaKebun)
                .HasMaxLength(100)
                .HasColumnName("nama_kebun");
        });

        modelBuilder.Entity<Panen>(entity =>
        {
            entity.HasKey(e => e.IdPanen).HasName("panen_pkey");

            entity.ToTable("panen");

            entity.Property(e => e.IdPanen).HasColumnName("id_panen");
            entity.Property(e => e.BeratKg)
                .HasPrecision(10, 2)
                .HasColumnName("berat_kg");
            entity.Property(e => e.EstimasiPendapatan)
                .HasPrecision(14, 2)
                .HasColumnName("estimasi_pendapatan");
            entity.Property(e => e.IdBuah).HasColumnName("id_buah");
            entity.Property(e => e.IdKebun).HasColumnName("id_kebun");
            entity.Property(e => e.IdPetani).HasColumnName("id_petani");
            entity.Property(e => e.TanggalPanen).HasColumnName("tanggal_panen");

            entity.HasOne(d => d.IdBuahNavigation).WithMany(p => p.Panens)
                .HasForeignKey(d => d.IdBuah)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_panen_buah");

            entity.HasOne(d => d.IdKebunNavigation).WithMany(p => p.Panens)
                .HasForeignKey(d => d.IdKebun)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_panen_kebun");

            entity.HasOne(d => d.IdPetaniNavigation).WithMany(p => p.Panens)
                .HasForeignKey(d => d.IdPetani)
                .HasConstraintName("fk_panen_petani");
        });

        modelBuilder.Entity<Pengguna>(entity =>
        {
            entity.HasKey(e => e.IdPengguna).HasName("pengguna_pkey");

            entity.ToTable("pengguna");

            entity.HasIndex(e => e.Username, "pengguna_username_key").IsUnique();

            entity.Property(e => e.IdPengguna).HasColumnName("id_pengguna");
            entity.Property(e => e.NamaLengkap)
                .HasMaxLength(100)
                .HasColumnName("nama_lengkap");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .HasColumnName("role");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Penjualan>(entity =>
        {
            entity.HasKey(e => e.IdPenjualan).HasName("penjualan_pkey");

            entity.ToTable("penjualan");

            entity.Property(e => e.IdPenjualan).HasColumnName("id_penjualan");
            entity.Property(e => e.HargaJual)
                .HasPrecision(12, 2)
                .HasColumnName("harga_jual");
            entity.Property(e => e.IdPanen).HasColumnName("id_panen");
            entity.Property(e => e.NamaPembeli)
                .HasMaxLength(100)
                .HasColumnName("nama_pembeli");
            entity.Property(e => e.TanggalPenjualan)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("tanggal_penjualan");
            entity.Property(e => e.TotalPendapatan)
                .HasPrecision(14, 2)
                .HasColumnName("total_pendapatan");

            entity.HasOne(d => d.IdPanenNavigation).WithMany(p => p.Penjualans)
                .HasForeignKey(d => d.IdPanen)
                .HasConstraintName("fk_penjualan_panen");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
