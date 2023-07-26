using Domain.Ports;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly RepositoryDBContext _repositoryDBContext;

        public RepositoryBase(RepositoryDBContext repositoryDBContext){
            _repositoryDBContext = repositoryDBContext;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _repositoryDBContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T item)
        {
            await _repositoryDBContext.Set<T>().AddAsync(item);
            return item;
        }
    }
}