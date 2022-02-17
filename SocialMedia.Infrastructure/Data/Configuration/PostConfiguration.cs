using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VY.SocialMedia.Data.Contracts.Entities;

namespace VY.SocialMedia.Data.Implementation.Data.Configuration
{
    internal class PostConfiguration : IEntityTypeConfiguration<PostEntities>
    {
        public void Configure(EntityTypeBuilder<PostEntities> builder)
        {
            builder.HasKey(e => e.PostId);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.Image)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.HasOne(d => d.UserNavId)
                .WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Publicacion_Usuario");
        }
    }
}
