using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;
using VY.SocialMedia.Data.Contracts.Interfaces;
using VY.SocialMedia.Dtos.DTOs;

namespace VY.SocialMedia.AppWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var posts = await _postRepository.GetPosts();
            var postDto = _mapper.Map<IEnumerable<PostDTO>>(posts);
            return Ok(postDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            var post = await _postRepository.GetPostById(id);
            var postDto = _mapper.Map<PostDTO>(post);

            return Ok(postDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostDTO postDto)
        {
            var post = _mapper.Map<PostEntities>(postDto);

            await _postRepository.InsertPost(post);
            return Ok(post);
        }
    }
}
