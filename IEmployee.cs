using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Interfaces
// Interface Segregation Principle ( Principio de segregação de interface)
namespace 
{
    public interface IEmployee
    {
        void CalculateSalary();
    }

    public interface IEmployeeRepository
    {
        void Save(Employee employee);
    }
}