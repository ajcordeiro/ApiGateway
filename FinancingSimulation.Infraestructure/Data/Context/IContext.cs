using FinancingSimulation.Domain.Models;
using System.Data.Entity;

namespace FinancingSimulation.Infraestructure.Data.Context
{
	public interface IContext
	{
		public Context Instance { get; }

		public DbSet<Customer> Customers { get; }
	}
}