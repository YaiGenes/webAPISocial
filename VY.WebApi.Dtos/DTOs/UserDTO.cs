using System;
using System.Collections.Generic;
using System.Text;

namespace VY.SocialMedia.Dtos.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}
