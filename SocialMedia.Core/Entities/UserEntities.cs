using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SocialMedia.Core.Entities
{
    public partial class UserEntities
    {
        public UserEntities()
        {
            Comments = new HashSet<CommentEntities>();
            Posts = new HashSet<PostEntities>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<CommentEntities> Comments { get; set; }
        public virtual ICollection<PostEntities> Posts { get; set; }
    }
}
