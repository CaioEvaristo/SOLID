using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Employee: IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        //Quando um método é declarado como virtual, ele permite que as classes derivadas forneçam sua própria implementação desse método usando a palavra-chave override. Isso permite que você modifique o comportamento padrão do método na classe base.

        // Single Responsibility Principle (Princípio da responsabilidade única)
        public virtual CalculateSalary()
        {
            Salary = 10000;
            return Salary;
        }
    }
}