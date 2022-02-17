using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<PostEntities>> GetPosts();
        Task<PostEntities> GetPostById(int id);
        Task InsertPost(PostEntities post);
    }
}
