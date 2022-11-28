using EntityLayer.Entities.User;

namespace DAL.Repositories.Abstraction
{
	public interface IEmployeesRepository
	{
		IEnumerable<Employee> GetList();

		Employee Get(int id);
	}
}
