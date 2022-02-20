using System.Collections.Generic;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;

namespace VY.SocialMedia.Data.Contracts.Interfaces
{
    public interface IPostRepository : IRepository<PostEntities>
    {
        Task<IEnumerable<PostEntities>> GetPostByUser(int userId);
    }
}