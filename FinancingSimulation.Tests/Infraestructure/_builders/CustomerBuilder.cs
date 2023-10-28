using Bogus;
using FinancingSimulation.Domain.Models;

namespace FinancingSimulation.Tests.Infraestructure._builders
{
    public class CustomerBuilder
	{
		protected int CustomerId;
		protected int Age;
		protected string? Name;
		protected string? Document;
		protected string? Address;

		public Customer New()
		{
			return new Faker<Customer>()
				.RuleFor(r => r.CustomerId, f => f.Random.Int(min: 1, max: 99999))
				.RuleFor(r => r.Name, f => f.Random.String2(length: 100))
				.RuleFor(r => r.Age, f => f.Random.Int(min: 1, max: 120))
				.RuleFor(r => r.Document, f => f.Random.Int(min: 1, max: 99999).ToString())
				.RuleFor(r => r.Address, f => f.Random.String2(length: 100))
				.Generate();
		}

		public Customer Build(bool newObject = true)
		{
			if (newObject)
				return new CustomerBuilder().New();

			return new Customer
			{
				CustomerId = CustomerId,
				Name = Name,
				Age = Age,
				Document = Document,
				Address = Address
			};
		}

		public CustomerBuilder WithCustomerId(int customerId)
		{
			CustomerId = customerId;

			return this;
		}

		public CustomerBuilder WithName(string name)
		{
			Name = name;

			return this;
		}

		public CustomerBuilder WithAge(int age)
		{
			Age = age;

			return this;
		}

		public CustomerBuilder WithDocument(string document)
		{
			Document = document;

			return this;
		}
        public CustomerBuilder WithAddress(string address)
        {
            Address = address;

            return this;
        }
    }
}