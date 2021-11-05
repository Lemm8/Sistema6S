using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sistema6S.Core.Entities;
using Sistema6S.Infrastructure.Data.Configurations;

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

        public virtual DbSet<Areas6s> Areas6s { get; set; }
        public virtual DbSet<Auditores6s> Auditores6s { get; set; }
        public virtual DbSet<Auditorias6s> Auditorias6s { get; set; }
        public virtual DbSet<Calificaciones6s> Calificaciones6s { get; set; }
        public virtual DbSet<Departamentos6s> Departamentos6s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Areas6sConfiguration());
            modelBuilder.ApplyConfiguration(new Auditores6sConfiguration());
            modelBuilder.ApplyConfiguration(new Auditorias6sConfiguration());
            modelBuilder.ApplyConfiguration(new Calificaciones6sConfiguration());
            modelBuilder.ApplyConfiguration(new Departamentos6sConfiguration());
        }
    }
}
