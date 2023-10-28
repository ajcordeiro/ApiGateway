using FinancingSimulation.Domain.Contracts.Repositories.Base;
using FinancingSimulation.Infraestructure.Data.Context;
using System.Data.Entity;

namespace FinancingSimulation.Infraestructure.Repositories.Base
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
	{
		protected IContext _context;
		protected DbSet<TEntity> _dbSet;

		public BaseRepository(IContext context)
        {
			_context = context;
			_dbSet = _context.Instance.Set<TEntity>();
		}

        public async Task DeleteByIdAsync(int id)
		{
			 await _dbSet.FindAsync(id);
		}

		public async Task<ICollection<TEntity>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task<int> InsertAsync(TEntity obj)
		{
			throw new NotImplementedException();
		}

		public async Task UpdateAsync(TEntity obj)
		{
			throw new NotImplementedException();
		}
	}
}