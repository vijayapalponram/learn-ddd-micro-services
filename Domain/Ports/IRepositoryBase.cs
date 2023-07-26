namespace Domain.Ports
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);

        Task<T> AddAsync(T entity);
    }
}
