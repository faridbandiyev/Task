using DepartmentTask;
using DepartmentTask.MyExtensions;

try
{
    Department hrDepartment = new Department("HR", 2);

    Employee emp1 = new Employee("John Doe", 30, 50000);
    Employee emp2 = new Employee("Jane Smith", 28, 60000);
    Employee emp3 = new Employee("Mike Johnson", 35, 70000);

    hrDepartment.AddEmployee(emp1);
    hrDepartment.AddEmployee(emp2);
    hrDepartment.AddEmployee(emp3);

}
catch (CapacityLimitException ex)
{
    Console.WriteLine($"CapacityLimitException: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}