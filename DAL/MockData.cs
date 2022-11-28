using EntityLayer.Entities;
using EntityLayer.Entities.Notification;
using EntityLayer.Entities.Service;
using EntityLayer.Entities.User;
using EntityLayer.Enums;

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
					City = "Львів",
					Street = "вул. Стрийська",
					Number = "67",
					PostalCode = "12345"
				},
			}
		};

		public static List<Specialist> Specialists = new List<Specialist>()
		{
			new Specialist()
			{
				Id = 1,

				SpecialistId = 11,

				DateCreated = DateTime.Parse("12.03.2022"),

				FirstName = "Саша",

				LastName = "Гнідець",

				BirthDate = DateTime.Parse("21.05.2002"),

				PhoneNumber = "+380663469374",

				EmailAddress = "gerhy2433@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Львів",
					Street = "Виликого",
					Number = "99",
					PostalCode = "6537"
				}
			}
		};

		public static List<Client> Clients = new List<Client>()
		{
			new Client()
			{
				Id = 1,

				DateCreated = DateTime.Parse("12.03.2022"),

				FirstName = "Марко",

				LastName = "Яців",

				BirthDate = DateTime.Parse("21.05.2002"),

				PhoneNumber = "+386433411374",

				EmailAddress = "ggwey433@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Харків",
					Street = "Просо",
					Number = "1",
					PostalCode = "53753"
				},

				CurrentAddress= new Address()
				{
					City = "Львів",
					Street = "Виликого",
					Number = "99",
					PostalCode = "6537"
				},
			}
		};


		public static List<Service> Services { get; set; } = new List<Service>()
		{
			new Service()
			{
				Id = 1,

				ClientId = 1,

				SpecialistId = 11,
				
				EmployeeId = 11,
				
				ServiceType = ServiceType.Evacuation,

				DateCreated = DateTime.Parse("07.09.2022")
			}
		};

		public static List<Notification> Notifications { get; set; } = new List<Notification>()
		{

		};
	}
}
