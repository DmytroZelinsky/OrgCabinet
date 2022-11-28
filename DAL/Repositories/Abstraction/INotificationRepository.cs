using EntityLayer.Entities.Notification;

namespace DAL.Repositories.Abstraction
{
	public interface INotificationRepository
	{
		IEnumerable<Notification> GetList();

		void Create(Notification client);
	}
}
