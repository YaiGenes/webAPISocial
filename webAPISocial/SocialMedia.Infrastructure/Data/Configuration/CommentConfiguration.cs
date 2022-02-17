using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Infrastructure.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<CommentEntities>
    {
        public void Configure(EntityTypeBuilder<CommentEntities> buider)
        {
            buider.HasKey(e => e.CommentId);

            buider.Property(e => e.CommentId).ValueGeneratedNever();

            buider.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            buider.Property(e => e.CreatedDate).HasColumnType("datetime");

            buider.HasOne(d => d.PostNavId)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comentario_Publicacion");

            buider.HasOne(d => d.UserNavId)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comentario_Usuario");
        }
    }
}
