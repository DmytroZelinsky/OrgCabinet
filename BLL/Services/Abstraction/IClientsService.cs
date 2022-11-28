using EntityLayer.Entities.User;

namespace BLL.Services.Abstraction
{
	public interface IClientsService
	{
		IEnumerable<Client> GetClients();

		Client GetClient(int clientId);

		void CreateClient(Client client);
	}
}
