using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty.Modal
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        //List<Employee> employeeList = new List<Employee>();
        private List<Employee> _employee = new List<Employee>();
        public MockEmployeeRepository() {
            _employee.Add(new Employee() { id = 1, name = "nuthana", age = 22, email = "nuthana@gmail.com" });
            _employee.Add(new Employee() { id = 2, name = "nayana", age = 22, email = "nayana@gmail.com" });
            _employee.Add(new Employee() { id = 3, name = "avi", age = 22, email = "avi@gmail.com" });
            _employee.Add(new Employee() { id = 4, name = "namana", age = 22, email = "namana@gmail.com" });
        }

        public  IEnumerable<Employee> GetAllEmployee() {
            return _employee;
        }

        Employee IEmployeeRepository.GetEmployee(int id) {
            return _employee.FirstOrDefault(e => e.id == id);
        }
    }
}