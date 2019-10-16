using DomainNotification.Domain.Core;
using System.Collections.Generic;

namespace DomainNotification.Domain.SongBoundedContext
{
    public class Artist : Entity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }

        public IEnumerable<Song> Songs { get; set; }

        public Artist()
        {
            Songs = new List<Song>();
        }
    }
}
