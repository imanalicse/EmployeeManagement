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
                new Employee() { Id=1, Name="Iman", Department =  Dept.HR, Email = "iman@gmail.com" },
                new Employee() { Id=2, Name="Ishak", Department =  Dept.IT, Email = "ishak@gmail.com" },
                new Employee() { Id=3, Name="Mukta", Department =  Dept.Payroll, Email = "mukta@gmail.com" }
            };
        }

        public Employee Add(Employee employee)
        {           
            employee.Id =  _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
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
