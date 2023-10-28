namespace FinancingSimulation.Domain.Models
{
	public class Customer
	{
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Document { get; set; }
        public string? Address { get; set; }
    }
}