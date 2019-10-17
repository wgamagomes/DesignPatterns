using DomainNotification.Application;
using DomainNotification.Domain.Core.Bus;
using DomainNotification.Domain.Core.Notifications;
using DomainNotification.Domain.SongBoundedContext;
using DomainNotification.Domain.SongBoundedContext.CommandHandlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace DomainNotification.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

           services.AddMediatR(typeof(InMemoryBus));

            var serviceProvider = Register(services);


            TryNotify(serviceProvider);


            var service = serviceProvider.GetService<ISongService>();

            service.Save(Guid.NewGuid(), "Title");

            service.Save(Guid.NewGuid(), string.Empty);

            Console.ReadKey();
        }


        static void TryNotify(ServiceProvider serviceProvider)
        {
            var mediator = serviceProvider.GetService<IMediatorHandler>();
            mediator.RaiseEvent(new DomainNotification.Domain.Core.Notifications.DomainNotification("key", "value"));
        }


        private static ServiceProvider Register(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<NewSongCommnad>, SongCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteSongCommnad>, SongCommandHandler>();
            services.AddScoped<IDomainNotificationHandler, DomainNotificationHandler>();
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            services.AddScoped<ISongService, SongService>();

            return services.BuildServiceProvider();

        }
    }
}
