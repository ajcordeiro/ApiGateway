using FinancingSimulation.Domain.Contracts.Repositories;
using FinancingSimulation.Domain.Models;
using FinancingSimulation.Infraestructure.Data.Context;
using FinancingSimulation.Infraestructure.Repositories.Base;

namespace FinancingSimulation.Infraestructure.Repositories
{
	public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
	{
		private readonly IContext _context;

		public CustomerRepository(IContext context) : base(context) => _context = context;
		
	}
}