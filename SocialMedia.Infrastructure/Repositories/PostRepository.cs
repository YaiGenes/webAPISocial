using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Contracts.Interfaces;
using VY.SocialMedia.Data.Implementation.Data;

namespace VY.SocialMedia.Data.Implementation.Repositories
{
    public class PostRepository : BaseRepository<PostEntities>, IPostRepository
    {
        public PostRepository(SocialMediaContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PostEntities>> GetPostByUser(int userId)
        {
            return await _entities.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
