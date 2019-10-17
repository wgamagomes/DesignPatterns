using DomainNotification.Domain.Core.Bus;
using DomainNotification.Domain.SongBoundedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Application
{
    public class SongService : ISongService
    {
        private IMediatorHandler _bus;

        public SongService(IMediatorHandler bus)
        {
            _bus = bus;
        }
        public void Remove(Guid id)
        {
            var command = new DeleteSongCommnad { Id = id };
            _bus.SendCommand(command);
        }
        public void Save(Guid artistId, string title)
        {
            var command = new NewSongCommnad { ArtistId = artistId, Title = title };
            _bus.SendCommand(command);
        }
    }
}
