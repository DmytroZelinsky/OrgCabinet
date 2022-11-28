using DAL.Repositories.Abstraction;
using EntityLayer.Entities.User;

namespace DAL.Repositories.Implementation
{
	public class MockEmployeeRepository : IEmployeesRepository
	{
		public Employee Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employee> GetList()
		{
			throw new NotImplementedException();
		}
	}
}
