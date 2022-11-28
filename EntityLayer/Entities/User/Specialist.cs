
namespace EntityLayer.Entities.User
{
	public class Specialist : User
	{
		public int SpecialistId { get; set; }

		public ICollection<Service.Service> ProvidedServices { get; set; }
	}
}
