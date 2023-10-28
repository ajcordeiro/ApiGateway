namespace FinancingSimulation.Domain.Contracts.Repositories.Base
{
	public interface IBaseRepository<TEntity> where TEntity : class
	{
		Task<int> InsertAsync(TEntity obj);
		Task<ICollection<TEntity>> GetAllAsync();
		Task<TEntity> GetByIdAsync(int id);
		Task DeleteByIdAsync(int id);
		Task UpdateAsync(TEntity obj);
	}
}