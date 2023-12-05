﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DidactEngine.Models.Entities;

namespace DidactEngine.Services.Contexts.Configurations
{
    public partial class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> entity)
        {
            entity.ToTable(nameof(Organization));
            entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
            entity.Property(e => e.Active).IsRequired().HasDefaultValue(true);
            entity.Property(e => e.RowVersion).IsRowVersion().IsConcurrencyToken();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Organization> entity);
    }
}