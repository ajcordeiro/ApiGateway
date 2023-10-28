using FinancingSimulation.Business.Services;
using FinancingSimulation.Domain.Contracts.Repositories;
using FinancingSimulation.Domain.Models;
using FinancingSimulation.Tests.Infraestructure._builders;
using Moq;

namespace FinancingSimulation.Tests.Infraestructure._fixtures.Services
{
    public class CustomerServiceFixture
    {
        public Mock<ICustomerRepository> CustomerRepositoryMock { get; set; }

        public CustomerService NewInstance()
        {
            ConfigureMocks();

            return new CustomerService(CustomerRepositoryMock.Object);
        }

        private void ConfigureMocks()
        {
            CustomerRepositoryMock = new Mock<ICustomerRepository>();

            CustomerRepositoryMock.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new CustomerBuilder().Build());

            CustomerRepositoryMock.Setup(x => x.GetAllAsync())
                .ReturnsAsync(new List<Customer> { new CustomerBuilder().Build(), new CustomerBuilder().Build() });

            CustomerRepositoryMock.Setup(x => x.DeleteByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new CustomerBuilder().Build());
        }
    }
}