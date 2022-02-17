using System;
using System.Collections.Generic;
using System.Text;

namespace VY.SocialMedia.Dtos.DTOs
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
    }
}
