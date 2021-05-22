using System.Collections.Generic;
using System.Linq;
using MVCDemo.Models;

namespace MVCDemo.Data
{
    public class MockRepository : IEmployeeRepository
    {
        private IList<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Anna", LastName = "Nowak", Email = "anowak@gmail.com"},
            new Employee { Id = 2, FirstName = "Jan", LastName = "Kowalski", Email = "jkowalski@gmail.com"},
            new Employee { Id = 3, FirstName = "Ola", LastName = "Kowalczyk", Email = "okowalczyk@gmail.com" },
            new Employee { Id = 4, FirstName = "Adam", LastName = "Malinowski", Email = "amalinowski@gmail.com"}
        };

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(x => x.Id == updatedEmployee.Id);

            if (employee != null)
            {
                var index = employees.IndexOf(employee);
                employees[index] = updatedEmployee;
            }

            return updatedEmployee;
        }


        public void Delete(int id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);
            employees.Remove(employee);
        }

        public Employee Insert(Employee employee)
        {
            var max = employees.Max(x => x.Id) + 1;
            employee.Id = max;
            employees.Add(employee);

            return employee;
        }
    }
}
