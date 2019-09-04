namespace Xpto.Behavioral.Mediator.Own.Interfaces
{
    public interface IRequestHandler<TRequest, TResult>
        where TRequest : IRequest<TResult>
    {
        TResult Handle(TRequest request);
    }

    public interface IRequestHandler<TRequest>
        where TRequest : IRequest
    {
        void Handle(TRequest request);
    }
}
