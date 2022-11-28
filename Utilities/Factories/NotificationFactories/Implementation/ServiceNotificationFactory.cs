using EntityLayer.Constants;
using EntityLayer.Entities.Notification;
using EntityLayer.Entities.Notification.Interface;
using EntityLayer.Entities.Service;
using EntityLayer.Enums;
using System.Text;
using Utilities.Extenstions;
using Utilities.Factories.NotificationFactories.Abstraction;

namespace Utilities.Factories.NotificationFactories.Implementation
{
	public class ServiceNotificationFactory : INotificationFactory
	{
		public Notification CreateAddNotification(INotifiable entity)
		{
			if (entity is Service service)
			{
				return new ServiceNotification()
				{
					Type = NotificationType.ServiceNotification,
					DateCreated = DateTime.Now,
					NotificationString = string.Format(NotificationTemplates.SERVICE_ADDED_NOTIFICATION, service.Id),
					EntityId = service.Id
				};
			}
			else
			{
				throw new Exception();
			}
		}

		public Notification CreateDeleteNotification(INotifiable entity)
		{
			if (entity is Service service)
			{
				return new ServiceNotification()
				{
					Type = NotificationType.ServiceNotification,
					DateCreated = DateTime.Now,
					NotificationString = string.Format(NotificationTemplates.SERVICE_DELETED_NOTIFICATION, service.Id),
					EntityId = service.Id
				};
			}
			else
			{
				throw new Exception();
			}
		}

		public Notification CreateUpdateNotification(INotifiable currentEntity, INotifiable newEntity)
		{
			if (currentEntity is Service currentService && newEntity is Service newService)
			{
				var variance = currentService.DetailedCompare(newService);

				var changedDetails = new StringBuilder();
				
				foreach(var field in variance)
				{
					changedDetails.AppendLine($"{field.Prop} : {field.valA} -> {field.valB}");
				}

				return new ServiceNotification()
				{
					Type = NotificationType.ServiceNotification,
					DateCreated = DateTime.Now,
					NotificationString = string.Format(NotificationTemplates.CLIENT_CHANGED_NOTIFICATION, currentService.Id, changedDetails.ToString())
				};
			}
			else
			{
				throw new Exception();
			}
		}
	}
}
