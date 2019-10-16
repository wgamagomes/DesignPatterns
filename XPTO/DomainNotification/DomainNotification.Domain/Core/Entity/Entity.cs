using System;

namespace DomainNotification.Domain.Core
{

    public abstract class Entity
        {
            protected Entity()
            {
                Id = Guid.NewGuid();
            }

            public Guid Id { get; private set; }

        }
    }
