using Microsoft.EntityFrameworkCore;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Implementation.Data.Configuration;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VY.SocialMedia.Data.Implementation.Data
{
    public partial class SocialMediaContext : DbContext
    {
        public SocialMediaContext()
        {
        }

        public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<CommentEntities> Comment { get; set; }
        public virtual DbSet<PostEntities> Post { get; set; }
        public virtual DbSet<UserEntities> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
