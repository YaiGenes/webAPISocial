using System;

namespace SocialMedia.Core.Entities
{
    public class PostEntities
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
