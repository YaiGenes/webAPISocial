using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VY.SocialMedia.Business.Contracts.Services;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Contracts.Interfaces;
using VY.SocialMedia.Data.Implementation.Repositories;

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
                throw new Exception("User doent exist");
            }

            if(post.Description.Contains("Sex"))
            {
                throw new Exception("Content not appropiate");
            }
            
            await _unitOfWork.PostRepository.Add(post);
            
        }

        public async Task<bool> UpdatePost(PostEntities post)
        {
            _unitOfWork.PostRepository.Update(post);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
