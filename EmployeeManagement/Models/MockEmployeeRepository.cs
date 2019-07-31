using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id=1, Name="Iman", Department =  "IT", Email = "iman@gmail.com" },
                new Employee() { Id=2, Name="Ishak", Department =  "HR", Email = "ishak@gmail.com" },
                new Employee() { Id=3, Name="Mukta", Department =  "IT", Email = "mukta@gmail.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee getEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
