using FinancingSimulation.Domain.Contracts.Repositories.Base;
using FinancingSimulation.Domain.Contracts.Services.Base;

namespace FinancingSimulation.Business.Services.Base
{
	public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
	{
		protected IBaseRepository<TEntity> _repository;

		public BaseService(IBaseRepository<TEntity> repository)  => _repository = repository;
	
		public async Task DeleteByIdAsync(int id)
		{
			await _repository.DeleteByIdAsync(id);
		}

		public async Task<ICollection<TEntity>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _repository.GetByIdAsync(id);
		}

		public async Task<int> InsertAsync(TEntity obj)
		{
			return await _repository.InsertAsync(obj);
		}

		public async Task UpdateAsync(TEntity obj)
		{
			await _repository.UpdateAsync(obj);
		}
	}
}