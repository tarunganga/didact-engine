﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DidactCore.Entities;

namespace DidactEngine.Services.Contexts.Configurations
{
    public partial class HyperQueueConfiguration : IEntityTypeConfiguration<HyperQueue>
    {
        public void Configure(EntityTypeBuilder<HyperQueue> entity)
        {
            entity.ToTable(nameof(HyperQueue));
            entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(255);
            entity.Property(e => e.Active).IsRequired().HasDefaultValue(true);
            entity.Property(e => e.RowVersion).IsRowVersion().IsConcurrencyToken();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<HyperQueue> entity);
    }
}