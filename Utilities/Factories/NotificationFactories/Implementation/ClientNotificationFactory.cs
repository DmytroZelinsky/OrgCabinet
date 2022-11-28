using EntityLayer.Constants;
using EntityLayer.Entities.Notification;
using EntityLayer.Entities.Notification.Interface;
using EntityLayer.Entities.User;
using EntityLayer.Enums;
using System.Text;
using Utilities.Extenstions;
using Utilities.Factories.NotificationFactories.Abstraction;

namespace Utilities.Factories.NotificationFactories.Implementation
{
	public class ClientNotificationFactory : INotificationFactory
	{
		public Notification CreateAddNotification(INotifiable entity)
		{
			if (entity is Client client)
			{
				return new ServiceNotification()
				{
					Type = NotificationType.ClientNotification,
					DateCreated = DateTime.Now,
					NotificationString = string.Format(NotificationTemplates.CLIENT_ADDED_NOTIFICATION, client.Id)
				};
			}
			else
			{
				throw new Exception();
			}
		}

		public Notification CreateDeleteNotification(INotifiable entity)
		{
			if (entity is Client client)
			{
				return new ServiceNotification()
				{
					Type = NotificationType.ClientNotification,
					DateCreated = DateTime.Now,
					NotificationString = string.Format(NotificationTemplates.CLIENT_DELETED_NOTIFICATION, client.Id)
				};
			}
			else
			{
				throw new Exception();
			}
		}

		public Notification CreateUpdateNotification(INotifiable currentEntity, INotifiable newEntity)
		{
			if (currentEntity is Client currentClient && newEntity is Client newClient)
			{
				var variance = currentClient.DetailedCompare(newClient);

				var changedDetails = new StringBuilder();

				foreach (var field in variance)
				{
					changedDetails.AppendLine($"{field.Prop} : {field.valA} -> {field.valB}");
				}

				return new ServiceNotification()
				{
					Type = NotificationType.ServiceNotification,
					DateCreated = DateTime.Now,
					NotificationString = string.Format(NotificationTemplates.CLIENT_CHANGED_NOTIFICATION, currentClient.Id, changedDetails.ToString())
				};
			}
			else
			{
				throw new Exception();
			}
		}
	}
}
