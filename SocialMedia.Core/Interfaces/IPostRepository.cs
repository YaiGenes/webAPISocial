using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;

namespace VY.SocialMedia.Data.Contracts.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<PostEntities>> GetPosts();
        Task<PostEntities> GetPostById(int id);
        Task InsertPost(PostEntities post);
    }
}
