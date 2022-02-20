using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VY.SocialMedia.Business.Contracts.Services;
using VY.SocialMedia.Business.Implementation.Exceptions;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Contracts.Interfaces;

namespace VY.SocialMedia.Business.Implementation.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> DeletePost(int id)
        {
            await _unitOfWork.PostRepository.Delete(id);

            return true;
        }

        public async Task<PostEntities> GetPostById(int id)
        {
            return await _unitOfWork.PostRepository.GetById(id);
        }

        public IEnumerable<PostEntities> GetPosts()
{
            return _unitOfWork.PostRepository.GetAll();
        }

        public async Task InsertPost(PostEntities post)
        {
            var user = await _unitOfWork.UserRepository.GetById(post.UserId);

            if (user == null)
            {
                throw new BusinessException("User doent exist");
            }

            var userPosts = await _unitOfWork.PostRepository.GetPostByUser(post.UserId);

            if (userPosts.Count() < 10)
            {
                var lastPost = userPosts.OrderByDescending(x => x.CreatedDate).FirstOrDefault();

                if((DateTime.Now - lastPost.CreatedDate).TotalDays < 7)
                {
                    throw new BusinessException("You are not able to publish within this week");
                }
            }

            if(post.Description.Contains("sex"))
            {
                throw new BusinessException("Content not appropiate");
            }
            
            await _unitOfWork.PostRepository.Add(post);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdatePost(PostEntities post)
        {
            _unitOfWork.PostRepository.Update(post);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
