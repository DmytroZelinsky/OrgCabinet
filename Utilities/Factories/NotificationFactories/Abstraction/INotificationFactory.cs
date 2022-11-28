using EntityLayer.Entities.Notification;
using EntityLayer.Entities.Notification.Interface;

namespace Utilities.Factories.NotificationFactories.Abstraction
{
	public interface INotificationFactory
	{
		Notification CreateUpdateNotification(INotifiable currentEntity, INotifiable newEntity);

		Notification CreateDeleteNotification(INotifiable entity);

		Notification CreateAddNotification(INotifiable entity);
	}
}
