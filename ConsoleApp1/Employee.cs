using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTask
{
    public class Employee : IPerson
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public decimal Salary { get; }

        public Employee(string name, int age, decimal salary)
        {
            Id = nextId++;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string ShowInfo()
        {
            return $"Id - {Id}, Name - {Name}, Age - {Age}, Salary - {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
