﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Core.DTOs
{
    public class PostDTO
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
