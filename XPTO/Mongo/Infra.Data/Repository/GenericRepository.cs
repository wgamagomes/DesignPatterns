using Infra.Data.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class GenericRepository<TDocument> : IGenericRepository<TDocument> where TDocument : Document
    {  
        private IMongoCollection<TDocument> collection;

        public GenericRepository(IDbContext dbContext)
        {  
            this.collection = dbContext.DbSet<TDocument>();
        }

        public Task InsertAsync(TDocument document)
        {
            return collection.InsertOneAsync(document);
        }

        public Task DeleteAsync(Expression<Func<TDocument, bool>> filter)
        {
            return collection.FindOneAndDeleteAsync(filter);
        }

        public Task<TDocument> UpdateAsync(TDocument document)
        {
           return collection.FindOneAndReplaceAsync(d => d.Id == document.Id, document);           
        }

        public Task<List<TDocument>> FindAsync()
        {
            return collection.FindAsync(FilterDefinition<TDocument>.Empty).GetAwaiter().GetResult().ToListAsync();
        }
        public Task<List<TDocument>> FindAsync(Expression<Func<TDocument, bool>> filter)
        {
            return collection.FindAsync(filter).GetAwaiter().GetResult().ToListAsync();
        }
    }
}
