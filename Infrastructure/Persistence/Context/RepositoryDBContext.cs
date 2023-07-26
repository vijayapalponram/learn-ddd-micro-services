using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class RepositoryDBContext: DbContext, IRepositoryDBContext {
        public RepositoryDBContext(DbContextOptions<RepositoryDBContext> options): base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDBContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}