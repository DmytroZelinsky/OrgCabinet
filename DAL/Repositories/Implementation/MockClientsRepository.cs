
using DAL.Repositories.Abstraction;
using EntityLayer.Entities.User;

namespace DAL.Repositories.Implementation
{
	public class MockClientsRepository : IClientsRepository
	{
		public void Create(Client client)
		{
			client.Id = MockData.Clients.Count + 1;
			MockData.Clients.Add(client);
		}

		public void Delete(int id)
		{
			MockData.Clients.RemoveAll(c => c.Id == id);
		}

		public Client Get(int id)
		{
			return MockData.Clients.First(c => c.Id == id);
		}

		public IEnumerable<Client> GetList()
		{
			return MockData.Clients;
		}
	}
}
