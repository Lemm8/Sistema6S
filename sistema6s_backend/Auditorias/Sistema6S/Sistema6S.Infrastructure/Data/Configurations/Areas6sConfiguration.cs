using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema6S.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema6S.Infrastructure.Data.Configurations
{
    class Areas6sConfiguration : IEntityTypeConfiguration<Areas6s>
    {
        public void Configure(EntityTypeBuilder<Areas6s> builder)
        {
            builder.HasKey(e => e.AreaId);

            builder.ToTable("areas_6s");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
