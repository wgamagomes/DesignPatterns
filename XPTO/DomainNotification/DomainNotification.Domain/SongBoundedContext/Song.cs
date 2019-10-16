using DomainNotification.Domain.Core;

namespace DomainNotification.Domain.SongBoundedContext
{
    public class Song : Entity
    {
        public Artist Artist { get; set; }
        public string Title { get; set; }
    }
}
