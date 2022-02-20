using System.Collections.Generic;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;

namespace VY.SocialMedia.Business.Contracts.Services
{
    public interface IPostService
    {
        IEnumerable<PostEntities> GetPosts();
        Task<PostEntities> GetPostById(int id);
        Task InsertPost(PostEntities post);
        Task<bool> UpdatePost(PostEntities post);
        Task<bool> DeletePost(int id);
    }
}