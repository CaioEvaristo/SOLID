using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    // Princípio da Substituição de Liskov (Liskov Substitution Principle)
    public class PermanentEmployee 
    {
        // Princípio da Responsabilidade Única (Single Responsibility Principle)
        public override void CalculateSalary()
        {
            Salary = 15000;
            return Salary;
        }
    }
}