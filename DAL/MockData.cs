using EntityLayer.Entities;
using EntityLayer.Entities.Service;
using EntityLayer.Entities.User;

namespace DAL
{
	public static class MockData
	{
		public static List<Employee> Employees { get; set; } = new List<Employee>()
		{
			new Employee()
			{
				Id = 1,

				EmployeeId = 11,

				DateCreated = DateTime.Parse("06.08.2022"),

				FirstName = "Роман",

				LastName = "Прокопів",

				BirthDate = DateTime.Parse("12.09.2002"),

				PhoneNumber = "+380679879374",

				EmailAddress = "RomanProkopiv@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Lviv",
					Street = "Striiska",
					Number = "67",
					PostalCode = "12345"
				}
			}
		};

		public static List<Specialist> Specialists = new List<Specialist>()
		{
			new Specialist()
			{

			}
		};

		public static List<Service> Services { get; set; } = new List<Service>()
		{
			new Service()
			{
				Id = 1,

			}
		};
	}
}
