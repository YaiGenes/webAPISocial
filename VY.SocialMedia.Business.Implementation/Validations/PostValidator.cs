using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using VY.SocialMedia.Dtos.DTOs;

namespace VY.SocialMedia.Business.Implementation.Validations
{
    public class PostValidator : AbstractValidator<PostDTO>
    {
        public PostValidator()
        {
            RuleFor(post => post.Description)
                .NotNull()
                .Length(10, 500);

            RuleFor(post => post.CreatedDate)
                .NotNull()
                .LessThanOrEqualTo(DateTime.UtcNow);
        }
    }
}
