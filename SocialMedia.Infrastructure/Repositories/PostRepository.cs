using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Contracts.Interfaces;
using VY.SocialMedia.Data.Implementation.Data;

namespace VY.SocialMedia.Data.Implementation.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PostEntities>> GetPosts()
        {
            var posts = await _context.Post.ToListAsync();
            return posts;
        }

        public async Task<PostEntities> GetPostById(int id)
        {
            var post = await _context.Post.FirstOrDefaultAsync(x => x.PostId == id);
            return post;
        }

        public async Task InsertPost(PostEntities post)
        {
            _context.Post.Add(post);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePost(PostEntities post)
        {
            var currentPost = await GetPostById(post.PostId);
            currentPost.CreatedDate = post.CreatedDate;
            currentPost.Description = post.Description;
            currentPost.Image = post.Image;
            currentPost.UserId = post.UserId;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeletePost(int id)
        {
            var currentPost = await GetPostById(id);

            _context.Post.Remove(currentPost);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
