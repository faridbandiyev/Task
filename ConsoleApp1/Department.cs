using DepartmentTask.MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTask
{
    public class Department
    {
        public string Name { get; }
        public int EmployeeLimit { get; }
        private int employeeCount;
        private Employee[] employees;

        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            employees = new Employee[EmployeeLimit];
            employeeCount = 0;
        }

        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set
            {
                employees[index] = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (employeeCount >= EmployeeLimit)
                throw new CapacityLimitException($"Department '{Name}' has reached its employee limit.");

            employees[employeeCount++] = employee;
        }
    }

}
