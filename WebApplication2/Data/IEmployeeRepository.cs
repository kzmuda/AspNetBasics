using System.Collections.Generic;
using MVCDemo.Models;

namespace MVCDemo.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee Update(Employee updatedEmployee);

        void Delete(int id);

        Employee Insert(Employee employee);
    }
}
