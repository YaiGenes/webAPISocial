using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SocialMedia.Core.Entities
{
    public partial class CommentEntities
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }

        public virtual PostEntities PostNavId { get; set; }
        public virtual UserEntities UserNavId { get; set; }
    }
}
