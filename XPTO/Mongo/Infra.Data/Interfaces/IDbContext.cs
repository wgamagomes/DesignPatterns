using MongoDB.Driver;

namespace Infra.Data.Interfaces
{
    public interface IDbContext
    {
        IMongoCollection<TDocument> DbSet<TDocument>();
    }
}
