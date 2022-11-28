namespace EntityLayer.Entities.User
{
	public class User : BaseEntity
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime BirthDate { get; set; }

		public string PhoneNumber { get; set; }

		public string? EmailAddress { get; set; }

		public Address ResidenceAddress { get; set; }
	}
}
