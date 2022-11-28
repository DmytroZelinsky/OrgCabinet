using BLL.Services.Abstraction;
using DAL.Repositories.Abstraction;
using EntityLayer.Entities.User;
using Utilities.Factories.NotificationFactories.Implementation;

namespace BLL.Services.Implementation
{
	public class ClientsService : IClientsService
	{
		private readonly IClientsRepository _clientsRepository;
		private readonly INotificationRepository _notificationRepository;

		public ClientsService(IClientsRepository clientsRepository, INotificationRepository notificationRepository)
		{
			_clientsRepository = clientsRepository;
			_notificationRepository = notificationRepository;
		}

		public void CreateClient(Client client)
		{
			_clientsRepository.Create(client);

			var factory = new ClientNotificationFactory();

			var notification = factory.CreateAddNotification(client);

			_notificationRepository.Create(notification);
		}

		public Client GetClient(int clientId)
		{
			return _clientsRepository.Get(clientId);
		}

		public IEnumerable<Client> GetClients()
		{
			return _clientsRepository.GetList();
		}
	}
}
