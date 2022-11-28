using BLL.Services.Abstraction;
using EntityLayer.Entities.Notification;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrgCabinet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationsController : ControllerBase
	{
		private readonly INotificationsService _notificationsService;

		public NotificationsController(INotificationsService notificationsService)
		{
			_notificationsService = notificationsService;
		}

		[HttpGet]
		public IEnumerable<Notification> Get()
		{
			return _notificationsService.GetNotifications();
		}
	}
}
