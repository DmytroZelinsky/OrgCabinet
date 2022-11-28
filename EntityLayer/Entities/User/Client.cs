using EntityLayer.Entities.Notification.Interface;

namespace EntityLayer.Entities.User
{
	public class Client : User, INotifiable
	{
		public Address CurrentAddress { get; set; }

		public string Notes { get; set; }

		public ICollection<Service.Service> Services { get; set; }
	}
}
