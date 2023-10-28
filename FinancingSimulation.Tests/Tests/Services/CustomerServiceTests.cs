using Bogus;
using FinancingSimulation.Business.Services;
using FinancingSimulation.Tests.Infraestructure._fixtures.Services;
using Xunit;

namespace FinancingSimulation.Tests.Tests.Services
{
    public class CustomerServiceTests : IClassFixture<CustomerServiceFixture>
	{
		private readonly CustomerServiceFixture _fixture;
		private readonly Faker _faker;
		private readonly CustomerService _customerService;

		public CustomerServiceTests(CustomerServiceFixture fixture)
		{
			_fixture = fixture;
			_faker = new Faker();
			_customerService = _fixture.NewInstance();
		}

		[Fact]
		public async Task TestGetByIdAsync_ShoudReturnNotNullObject_GivenValidInput()
		{
			//Arrange
			var id = _faker.Random.Int(min: 1, max: 1000);

			//Act
			var customer = await _customerService.GetByIdAsync(id);

			//Assert
			Assert.NotNull(customer);
		}

		[Fact]
		public async Task TestGetAllAsync_ShoudReturnNotNullObject()
		{
			//Act
			var  customer = await _customerService.GetAllAsync();

			//Assert
			Assert.NotNull(customer);
		}

        [Fact]
		public async Task TestDeleteByIdAsync_ShoudReturnNotEmptyList_GivenValidInput()
		{
			//Arrange
			var id = _faker.Random.Int(min: 1, max: 1000);

			//Act
			//var customer = await _customerService.DeleteByIdAsync(id);


			//Assert
			//Assert.NotEmpty(customer);
		}
	}
}