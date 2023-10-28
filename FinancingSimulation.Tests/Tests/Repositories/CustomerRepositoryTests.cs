using Bogus;
using FinancingSimulation.Infraestructure.Repositories;
using FinancingSimulation.Tests.Infraestructure._fixtures.Repositories;
using Xunit;

namespace FinancingSimulation.Tests.Tests.Repositories
{
	public class CustomerRepositoryTests : IClassFixture<CustomerRepositoryFixture>
    {
        private readonly CustomerRepositoryFixture _fixture;
        private readonly Faker _faker;
        private readonly CustomerRepository _customerRepository;

        public CustomerRepositoryTests(CustomerRepositoryFixture fixture)
        {
            _fixture = fixture;
            _faker = new Faker();
			_customerRepository = _fixture.NewInstance();
        }

        [Fact]
        public async Task TestGetByIdAsync_ShoudReturnNotNullObject_GivenValidInput()
        {
            //Arrange
            var id = _faker.Random.Int(min: 1, max: 1000);

            //Act
            var customer = await _customerRepository.GetByIdAsync(id);

            //Assert
            Assert.NotNull(customer);
        }

        [Fact]
        public async Task TestGetAllAsync_ShoudReturnNotEmptyList_GivenValidInput()
        {
            //Act
            var customers = await _customerRepository.GetAllAsync();

            //Assert
            Assert.NotEmpty(customers);
        }
    }
}