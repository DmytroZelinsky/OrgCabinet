using EntityLayer.Entities.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstraction
{
	public interface INotificationsService
	{
		IEnumerable<Notification> GetNotifications();
	}
}
