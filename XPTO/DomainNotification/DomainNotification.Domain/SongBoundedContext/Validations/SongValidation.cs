using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.SongBoundedContext.Validations
{
    public abstract class SongValidation: AbstractValidator<SongCommnad>
    {
        protected void ValidateId()
        {
            RuleFor(r => r.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("ID is required");
        }

        protected void ValidateArtistId()
        {
            RuleFor(r => r.ArtistId)
                .NotEqual(Guid.Empty)
                .WithMessage("Artist ID is required");
        }

        protected void ValidateTitle()
        {
            RuleFor(r => r.Title)
                .NotEmpty().WithMessage("Title is required")
                .Length(2, 50).WithMessage("Title must be between 2 and 50 characters");
        }
    }
}
