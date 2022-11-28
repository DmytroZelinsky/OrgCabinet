using DAL.Repositories.Abstraction;
using EntityLayer.Entities.Notification;

namespace DAL.Repositories.Implementation
{
	public class MockNotificationRepository : INotificationRepository
	{
		public void Create(Notification notification)
		{
			notification.Id = MockData.Notifications.Count + 1;
			MockData.Notifications.Add(notification);
		}

		public IEnumerable<Notification> GetList()
		{
			return MockData.Notifications;
		}
	}
}
