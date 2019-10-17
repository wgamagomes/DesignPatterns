using DomainNotification.Domain.SongBoundedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Application
{
    public interface ISongService
    {
        void Remove(Guid id);
        void Save(Guid artistId, string title);
    }
}
