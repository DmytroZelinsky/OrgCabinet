using EntityLayer.Entities.User;

namespace DAL.Repositories.Abstraction
{
	public interface IClientsRepository
	{
		IEnumerable<Client> GetList();

		Client Get(int id);

		void Create(Client client);

		void Delete(int id);
	}
}
