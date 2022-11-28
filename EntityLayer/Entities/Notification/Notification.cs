using EntityLayer.Enums;

namespace EntityLayer.Entities.Notification
{
	public abstract class Notification : BaseEntity
	{
		public NotificationType Type { get; set; }
		
		public DateTime DateCreated { get; set; }

		public string NotificationString { get; set; }
	}
}
