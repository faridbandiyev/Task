using DepartmentTask;
using DepartmentTask.MyExtensions;

try
{
    Department hrDepartment = new Department("HR", 3);

    Employee emp1 = new Employee("Angelina Jolie", 30, 50000);
    Employee emp2 = new Employee("Michael Jackson", 28, 60000);
    Employee emp3 = new Employee("Hulk", 35, 70000);
    Employee emp4 = new Employee("Farid Bandiyev", 18, 1000000000);

    hrDepartment.AddEmployee(emp1);
    hrDepartment.AddEmployee(emp2);
    hrDepartment.AddEmployee(emp3);
    hrDepartment.AddEmployee(emp4);

    foreach (Employee emp in hrDepartment)
    {
        Console.WriteLine(emp.ShowInfo());
    }
}
catch (CapacityLimitException ex)
{
    Console.WriteLine($"CapacityLimitException: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}