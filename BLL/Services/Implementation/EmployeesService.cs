using BLL.Services.Abstraction;
using DAL.Repositories.Abstraction;
using EntityLayer.Entities.User;

namespace BLL.Services.Implementation
{

	public class EmployeesService : IEmployeesService
	{
		private readonly IEmployeesRepository _employeesRepository;

		public EmployeesService(IEmployeesRepository employeesRepository)
		{
			_employeesRepository = employeesRepository;
		}

		public Employee GetEmployeeDetails(int employeeId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employee> GetEmployeesTrees()
		{
			return _employeesRepository.GetList();
		}
	}
}
