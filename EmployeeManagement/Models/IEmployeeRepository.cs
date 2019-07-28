using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee getEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
    }
}
