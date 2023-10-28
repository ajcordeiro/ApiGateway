using FinancingSimulation.Infraestructure.Data.Context;
using FinancingSimulation.Infraestructure.Repositories;
using FinancingSimulation.Tests.Infraestructure._builders;
using Moq;

namespace FinancingSimulation.Tests.Infraestructure._fixtures.Repositories
{
	public class CustomerRepositoryFixture
	{
		public Mock<IContext> ContextMock { get; set; }

		public CustomerRepository NewInstance()
		{
			ConfigureMocks();

			return new CustomerRepository(ContextMock.Object);
		}

		private void ConfigureMocks()
		{
			ContextMock = new Mock<IContext>();

			ContextMock.Setup(x => x.Customers.FindAsync(It.IsAny<int>()))
				.ReturnsAsync(new CustomerBuilder().Build());

			//ContextMock.Setup(x => x.GetAllAsync())
			//	.ReturnsAsync(new List<Customer> { new CustomerBuilder().Build(), new CustomerBuilder().Build() });
		}
	}
}