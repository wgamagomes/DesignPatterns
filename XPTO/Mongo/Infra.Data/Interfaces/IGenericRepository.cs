using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IGenericRepository<TDocument> where TDocument : Document
    {
        Task InsertAsync(TDocument document);

        Task DeleteAsync(Expression<Func<TDocument, bool>> filter);

        Task<TDocument> UpdateAsync(TDocument document);

        Task<List<TDocument>> FindAsync();

        Task<List<TDocument>> FindAsync(Expression<Func<TDocument, bool>> filter);
    }
}
