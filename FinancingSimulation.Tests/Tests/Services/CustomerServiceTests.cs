using Bogus;
using FinancingSimulation.Business.Services;
using FinancingSimulation.Domain.Contracts.Repositories;
using FinancingSimulation.Domain.Contracts.Services.Base;
using FinancingSimulation.Domain.Models;
using FinancingSimulation.Tests.Infraestructure._builders;
using FinancingSimulation.Tests.Infraestructure._fixtures.Services;
using Moq;
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
        public async Task TestGetAllAsync_ShoudReturnNotNullObject()
        {
            //Arrange
			var builder = new Faker<Customer>()
                .RuleFor(r => r.CustomerId, f => f.Random.Int(min: 1, max: 99999))
                .RuleFor(r => r.Name, f => f.Random.String2(length: 100))
                .RuleFor(r => r.Age, f => f.Random.Int(min: 1, max: 120))
                .RuleFor(r => r.Document, f => f.Random.Int(min: 1, max: 99999).ToString())
                .RuleFor(r => r.Address, f => f.Random.String2(length: 100))
                .Generate();

            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();

            //mock.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
            //     .ReturnsAsync(builder);


			mock.Setup(x => x.GetAllAsync())
				.Returns( builder);
				

			var c = await _customerService.GetAllAsync();

            //Act
            var customer = await _customerService.GetAllAsync();

            //Assert
            Assert.NotNull(customer);
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

		//[Fact]
		//public async Task TestGetAllAsync_ShoudReturnNotNullObject()
		//{
		//	//Act
		//	var  customer = await _customerService.GetAllAsync();

		//	//Assert
		//	Assert.NotNull(customer);
		//}


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