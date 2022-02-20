using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VY.SocialMedia.Data.Contracts.Entities;

namespace VY.SocialMedia.Data.Implementation.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<UserEntities>
    {
        public void Configure(EntityTypeBuilder<UserEntities> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("userId");

            builder.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.BirthDate).HasColumnType("date");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);
        }
    }
}
