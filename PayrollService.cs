using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    // Princípio da Inversão de Dependência (Dependency Inversion Principle)
    // Princípio da Responsabilidade Única (Single Responsibility Principle)
    public class PayrollService
    {
         private readonly IEmployeeRepository _employeeRepository;

        public PayrollService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // Princípio da Responsabilidade Única (Single Responsibility Principle)
        public void ProcessPayroll(IEmployee employee)
        {
            employee.CalculateSalary();
            _employeeRepository.Save((Employee)employee);
        }
    }
}