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
		private readonly ClientNotificationFactory _factory;

		public ClientsService(IClientsRepository clientsRepository, INotificationRepository notificationRepository)
		{
			_clientsRepository = clientsRepository;
			_notificationRepository = notificationRepository;
			_factory = new ClientNotificationFactory();
		}

		public void CreateClient(Client client)
		{
			_clientsRepository.Create(client);

			var notification = _factory.CreateAddNotification(client);

			_notificationRepository.Create(notification);
		}

		public void DeleteClient(int id)
		{
			var client = _clientsRepository.Get(id);

			var notification = _factory.CreateDeleteNotification(client);

			_notificationRepository.Create(notification);
		
			_clientsRepository.Delete(id);
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
