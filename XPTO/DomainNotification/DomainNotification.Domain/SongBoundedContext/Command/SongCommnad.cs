using System;
using System.Collections.Generic;
using System.Text;
using DomainNotification.Domain.Core.Commands;

namespace DomainNotification.Domain.SongBoundedContext
{
    public class SongCommnad : Command
    {
        public Guid Id { get; private set; }
        public Guid ArtistId { get; private set; }
        public string Title { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
