using DomainNotification.Domain.Core;
using DomainNotification.Domain.MethodExtension;
using System;

namespace DomainNotification.Domain.SongBoundedContext
{
    public class Song : Entity
    {
        public Song(Guid artistId, string title)
        {
            ArtistId = artistId;
            Title = title;
        }
        public Guid ArtistId { get; private set; }
        public string Title { get; private set; }


        public void UpdateTitle(string title)
        {
            if (title.IsNotNullOrEmpty())
            {
                Title = title;
            }
        }
    }
}
