using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;

namespace VY.SocialMedia.Data.Contracts.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<PostEntities> PostRepository { get; }
        IRepository<UserEntities> UserRepository { get; }
        IRepository<CommentEntities> CommentRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
