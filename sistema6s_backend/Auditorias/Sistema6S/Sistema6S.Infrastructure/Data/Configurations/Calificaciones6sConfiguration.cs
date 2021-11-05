using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema6S.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema6S.Infrastructure.Data.Configurations
{
    class Calificaciones6sConfiguration : IEntityTypeConfiguration<Calificaciones6s>
    {
        public void Configure(EntityTypeBuilder<Calificaciones6s> builder)
        {
            builder.HasKey(e => e.CalificacionId);

            builder.ToTable("calificaciones_6s");
        }
    }
}
