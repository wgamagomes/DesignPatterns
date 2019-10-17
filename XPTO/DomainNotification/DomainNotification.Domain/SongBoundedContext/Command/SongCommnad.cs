using DomainNotification.Domain.Core.Commands;
using System;

namespace DomainNotification.Domain.SongBoundedContext
{
    public abstract class SongCommnad : Command
    {
        public Guid Id { get;  set; }
        public Guid ArtistId { get;  set; }
        public string Title { get;  set; }
    }
}
