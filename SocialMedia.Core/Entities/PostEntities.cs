using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VY.SocialMedia.Data.Contracts.Entities
{
    public partial class PostEntities : BaseEntity
    {
        public PostEntities()
        {
            Comments = new HashSet<CommentEntities>();
        }

        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual UserEntities UserNavId { get; set; }
        public virtual ICollection<CommentEntities> Comments { get; set; }
    }
}
