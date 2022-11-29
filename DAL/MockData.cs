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
			},
			new Employee()
			{
				Id = 2,

				EmployeeId = 12,

				DateCreated = DateTime.Parse("06.08.2022"),

				FirstName = "Антон",

				LastName = "Буданов",

				BirthDate = DateTime.Parse("12.09.2002"),

				PhoneNumber = "+380679879374",

				EmailAddress = "hrethtrhrt@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Львів",
					Street = "вул. Стрийська",
					Number = "67",
					PostalCode = "12345"
				},
			},
			new Employee()
			{
				Id = 3,

				EmployeeId = 13,

				DateCreated = DateTime.Parse("06.08.2022"),

				FirstName = "Василь",

				LastName = "Конопенко",

				BirthDate = DateTime.Parse("12.09.2002"),

				PhoneNumber = "+380679879374",

				EmailAddress = "hrethtrhrt@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Львів",
					Street = "вул. Стрийська",
					Number = "67",
					PostalCode = "12345"
				},
			},
			new Employee()
			{
				Id = 4,

				EmployeeId = 14,

				DateCreated = DateTime.Parse("06.08.2022"),

				FirstName = "Віталік",

				LastName = "Підпільний",

				BirthDate = DateTime.Parse("12.09.2002"),

				PhoneNumber = "+380679879374",

				EmailAddress = "hrethtrhrt@gmail.com",

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
			},
			new Specialist()
			{
				Id = 2,

				SpecialistId = 12,

				DateCreated = DateTime.Parse("12.06.2022"),

				FirstName = "Богдан",

				LastName = "Молодець",

				BirthDate = DateTime.Parse("21.05.2002"),

				PhoneNumber = "+380663469374",

				EmailAddress = "gerhy2433@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Львів",
					Street = "Маленького",
					Number = "65",
					PostalCode = "543743"
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
					Street = "Великого",
					Number = "99",
					PostalCode = "6537"
				},
			},
			new Client()
			{
				Id = 2,

				DateCreated = DateTime.Parse("25.01.2022"),

				FirstName = "Ярослав",

				LastName = "Прокук",

				BirthDate = DateTime.Parse("21.03.2001"),

				PhoneNumber = "+386453611374",

				EmailAddress = "yrty456@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Миколаїв",
					Street = "Кероль",
					Number = "56",
					PostalCode = "87594"
				},

				CurrentAddress= new Address()
				{
					City = "Львів",
					Street = "Великого",
					Number = "99",
					PostalCode = "6537"
				},
			},
			new Client()
			{
				Id = 3,

				DateCreated = DateTime.Parse("03.05.2022"),

				FirstName = "В'ячеслав",

				LastName = "Бородько",

				BirthDate = DateTime.Parse("21.03.1998"),

				PhoneNumber = "+386453784864",

				EmailAddress = "teryery@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Запоріжжя",
					Street = "Скоротко",
					Number = "78",
					PostalCode = "74863"
				},

				CurrentAddress= new Address()
				{
					City = "Львів",
					Street = "Великого",
					Number = "99",
					PostalCode = "6537"
				},
			},
			new Client()
			{
				Id = 4,

				DateCreated = DateTime.Parse("03.05.2022"),

				FirstName = "Соломія",

				LastName = "Беренько",

				BirthDate = DateTime.Parse("21.03.1998"),

				PhoneNumber = "+386453784864",

				EmailAddress = "teryery@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Запоріжжя",
					Street = "Скоротко",
					Number = "78",
					PostalCode = "74863"
				},

				CurrentAddress= new Address()
				{
					City = "Львів",
					Street = "Великого",
					Number = "99",
					PostalCode = "6537"
				},
			},
			new Client()
			{
				Id = 5,

				DateCreated = DateTime.Parse("03.05.2022"),

				FirstName = "Вікторія",

				LastName = "Цемко",

				BirthDate = DateTime.Parse("21.03.1998"),

				PhoneNumber = "+386453784864",

				EmailAddress = "teryery@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Суми",
					Street = "Скоротко",
					Number = "78",
					PostalCode = "74863"
				},

				CurrentAddress= new Address()
				{
					City = "Львів",
					Street = "Великого",
					Number = "99",
					PostalCode = "6537"
				},
			},
			new Client()
			{
				Id = 6,

				DateCreated = DateTime.Parse("03.05.2022"),

				FirstName = "Дмитро",

				LastName = "Мороз",

				BirthDate = DateTime.Parse("21.03.1998"),

				PhoneNumber = "+386453784864",

				EmailAddress = "teryery@gmail.com",

				ResidenceAddress = new Address()
				{
					City = "Харків",
					Street = "Скоротко",
					Number = "78",
					PostalCode = "74863"
				},

				CurrentAddress= new Address()
				{
					City = "Львів",
					Street = "Великого",
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

				SpecialistId = 12,
				
				EmployeeId = 12,
				
				ServiceType = ServiceType.Evacuation,

				DateCreated = DateTime.Parse("07.09.2022")
			},
			new Service()
			{
				Id = 2,

				ClientId = 2,

				SpecialistId = 12,

				EmployeeId = 11,

				ServiceType = ServiceType.JobProviding,

				DateCreated = DateTime.Parse("06.08.2022")
			},
			new Service()
			{
				Id = 3,

				ClientId = 3,

				SpecialistId = 12,

				EmployeeId = 11,

				ServiceType = ServiceType.Evacuation,

				DateCreated = DateTime.Parse("06.08.2022")
			},
			new Service()
			{
				Id = 4,

				ClientId = 4,

				SpecialistId = 12,

				EmployeeId = 13,

				ServiceType = ServiceType.JobProviding,

				DateCreated = DateTime.Parse("06.08.2022")
			},
			new Service()
			{
				Id = 5,

				ClientId = 5,

				SpecialistId = 11,

				EmployeeId = 13,

				ServiceType = ServiceType.HouseHosting,

				DateCreated = DateTime.Parse("06.08.2022")
			},
			new Service()
			{
				Id = 6,

				ClientId = 6,

				SpecialistId = 11,

				EmployeeId = 13,

				ServiceType = ServiceType.MonetaryAid,

				DateCreated = DateTime.Parse("06.08.2022")
			}
		};

		public static List<Notification> Notifications { get; set; } = new List<Notification>()
		{
			new ClientNotification()
			{
				DateCreated = new DateTime(2022, 12, 31, 5, 10, 20),
				NotificationString = "Додано нового користувача: 7"
			},
			new ClientNotification()
			{
				DateCreated = new DateTime(2022, 12, 31, 5, 11, 20),
				NotificationString = "Додано нового користувача: 8"
			},
			new ClientNotification()
			{
				DateCreated = new DateTime(2022, 12, 31, 5, 12, 20),
				NotificationString = "Видалено користувача: 10"
			},
			new ClientNotification()
			{
				DateCreated = new DateTime(2022, 12, 31, 5, 13, 20),
				NotificationString = "Додано нового користувача: 5"
			},
		};
	}
}
