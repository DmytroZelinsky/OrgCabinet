namespace EntityLayer.Entities.User
{
	public class Employee : User
	{
		public int EmployeeId { get; set; }

		public ICollection<Service.Service> ProcessedServices { get; set; }
	}
}
