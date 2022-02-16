using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<PostEntities> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new PostEntities
            {
                PostId = x,
                UserId = x * 2,
                Description = $"Description{x}",
                CreatedDate = DateTime.Now,
                Image = $"https://picsum.photos/id/{x*5}/200/300",
            });

            return posts;

        }
    }
}
