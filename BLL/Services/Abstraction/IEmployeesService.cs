using EntityLayer.Entities.User;

namespace BLL.Services.Abstraction
{
	public interface IEmployeesService
	{
		IEnumerable<Employee> GetEmployeesTrees();

		Employee GetEmployeeDetails(int employeeId);
	}
}
