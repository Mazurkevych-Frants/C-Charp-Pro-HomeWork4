using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Charp_Pro_HomeWork4_1
{
    internal class Employee
    {
        public string FullName { get; set; }
        public int Salary { get; set; }

        public Employee(string fullName, int salary)
        {
            FullName = fullName;
            Salary = salary;
        }

        public static Employee operator +(Employee employee, int changeSalary)
        {
            return new Employee(employee.FullName, employee.Salary + changeSalary);
        }


        public static Employee operator -(Employee employee, int changeSalary)
        {
            return new Employee(employee.FullName, employee.Salary - changeSalary);
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Salary == employee2.Salary;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }

        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }

        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
    }
}