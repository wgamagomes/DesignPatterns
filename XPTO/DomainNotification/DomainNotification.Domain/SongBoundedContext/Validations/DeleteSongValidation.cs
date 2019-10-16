using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.SongBoundedContext.Validations
{
    public  class DeleteSongValidation: SongValidation
    {
        public DeleteSongValidation()
        {
            ValidateId();
        }
    }
}
