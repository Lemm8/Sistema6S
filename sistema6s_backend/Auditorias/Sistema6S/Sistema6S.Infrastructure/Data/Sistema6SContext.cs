using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sistema6S.Core.Entities;

namespace Sistema6S.Infrastructure.Data
{
    public partial class Sistema6SContext : DbContext
    {
        public Sistema6SContext()
        {
        }

        public Sistema6SContext(DbContextOptions<Sistema6SContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Auditores> Auditores { get; set; }
        public virtual DbSet<Auditorias> Auditorias { get; set; }
        public virtual DbSet<Calificaciones> Calificaciones { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Areas>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("areas");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Auditores>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("auditores");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Auditorias>(entity =>
            {
                entity.HasKey(e => e.AuditoriaId);

                entity.ToTable("auditorias");

                entity.Property(e => e.FechaCompleto).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaTarget).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Auditorias)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__auditoria__AreaI__48CFD27E");

                entity.HasOne(d => d.Auditor)
                    .WithMany(p => p.Auditorias)
                    .HasForeignKey(d => d.AuditorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__auditoria__Audit__47DBAE45");

                entity.HasOne(d => d.Calificacion)
                    .WithMany(p => p.Auditorias)
                    .HasForeignKey(d => d.CalificacionId)
                    .HasConstraintName("FK__auditoria__Calif__49C3F6B7");
            });

            modelBuilder.Entity<Calificaciones>(entity =>
            {
                entity.HasKey(e => e.CalificacionId);

                entity.ToTable("calificaciones");
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.DepartamentoId);

                entity.ToTable("departamentos");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__departame__AreaI__4AB81AF0");
            });
        }
    }
}
