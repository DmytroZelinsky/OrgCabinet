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
			var employees = new List<Employee>(MockData.Employees);

			foreach(var employee in employees)
			{
				employee.ProcessedServices = MockData.Services.Where(s => s.EmployeeId == employee.EmployeeId).ToList();

				foreach (var processedService in employee.ProcessedServices)
				{
					processedService.Client = MockData.Clients.First(c => c.Id == processedService.ClientId);
					processedService.Specialist = MockData.Specialists.First(c => c.SpecialistId == processedService.SpecialistId);
				}
			}

			return employees;
		}
	}
}
