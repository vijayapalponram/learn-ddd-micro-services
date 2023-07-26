using Domain.Aggregates;
using Domain.Ports;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class OrderRepository : RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(RepositoryDBContext repositoryDBContext) : base(repositoryDBContext)
        {
        }

        public async Task<Order> AddAsync(Order entity)
        {
            return await this.AddAsync(entity);
        }

        public async Task<Order> GetByIdAsync(Guid id)
        {
            return await this.GetByIdAsync(id);
        }
    }
}