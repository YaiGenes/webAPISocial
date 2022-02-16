using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class MongoRepo : IPostRepository
    {
        public async Task<IEnumerable<PostEntities>> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new PostEntities
            {
                PostId = x,
                UserId = x * 2,
                Description = $"Description{x} inyectando a mongo",
                CreatedDate = DateTime.Now,
                Image = $"https://picsum.photos/id/{x*5}/200/300",
            });
            await Task.Delay(10);
            return posts;

        }
    }
}
