using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Contracts.Interfaces;
using VY.SocialMedia.Data.Implementation.Data;

namespace VY.SocialMedia.Data.Implementation.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SocialMediaContext _context;
        private readonly IRepository<PostEntities> _postRepository;
        private readonly IRepository<UserEntities> _userRepository;
        private readonly IRepository<CommentEntities> _commentRepository;
        public UnitOfWork(SocialMediaContext context, IRepository<PostEntities> postRepository, IRepository<UserEntities> userRepository, IRepository<CommentEntities> commentRepository)
        {
            _context = context;
            _postRepository = postRepository;
            _userRepository = userRepository;
            _commentRepository = commentRepository;
        }
        public IRepository<PostEntities> PostRepository => _postRepository ?? new BaseRepository<PostEntities>(_context);

        public IRepository<UserEntities> UserRepository => _userRepository ?? new BaseRepository<UserEntities>(_context);

        public IRepository<CommentEntities> CommentRepository => _commentRepository ?? new BaseRepository<CommentEntities>(_context);

        public void Dispose()
        {
            if(_context != null)
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
