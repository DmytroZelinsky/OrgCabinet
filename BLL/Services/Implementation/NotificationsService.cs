using BLL.Services.Abstraction;
using DAL.Repositories.Abstraction;
using EntityLayer.Entities.Notification;

namespace BLL.Services.Implementation
{
	public class NotificationsService : INotificationsService
	{
		private readonly INotificationRepository _notificationRepository;

		public NotificationsService(INotificationRepository notificationRepository)
		{
			_notificationRepository = notificationRepository;
		}

		public IEnumerable<Notification> GetNotifications()
		{
			return _notificationRepository.GetList();
		}
	}
}
