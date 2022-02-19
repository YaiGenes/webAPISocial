using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VY.SocialMedia.Business.Contracts.Services;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Contracts.Interfaces;

namespace VY.SocialMedia.Business.Implementation.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<bool> DeletePost(int id)
        {
            return await _postRepository.DeletePost(id);
        }

        public async Task<PostEntities> GetPostById(int id)
        {
            return await _postRepository.GetPostById(id);
        }

        public async Task<IEnumerable<PostEntities>> GetPosts()
{
            return await _postRepository.GetPosts();
        }

        public async Task InsertPost(PostEntities post)
        {
            await _postRepository.InsertPost(post);
        }

        public async Task<bool> UpdatePost(PostEntities post)
        {
            return await _postRepository.UpdatePost(post);
        }
    }
}
