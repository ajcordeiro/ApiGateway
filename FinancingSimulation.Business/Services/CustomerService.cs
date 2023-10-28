using FinancingSimulation.Business.Services.Base;
using FinancingSimulation.Domain.Contracts.Repositories;
using FinancingSimulation.Domain.Contracts.Services;
using FinancingSimulation.Domain.Models;

namespace FinancingSimulation.Business.Services
{
	public class CustomerService : BaseService<Customer>, ICustomerService
	{
		private readonly ICustomerRepository _repository;

		public CustomerService(ICustomerRepository repository) : base(repository) => _repository = repository;
		
	}
}