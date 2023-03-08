
using EmployeeWork.Models;

Employee e = new Employee();
Department d = new Department();
string name, surname;
double salary;
int EmployeeCount = 0;


while (EmployeeCount < d.EmployeeLimit)
{
    do
    {
        Console.WriteLine("Enter the employee's name");
        name = Console.ReadLine();
    } while (!e.CheckName(name));
    do
    {
        Console.WriteLine("Enter the employee's surname");
        surname = Console.ReadLine();
    } while (!e.CheckSurname(surname));
    do
    {
        Console.WriteLine("Enter the employee's salary");
        salary = Convert.ToDouble(Console.ReadLine());
    } while (!d.CheckSalary(salary));
    EmployeeCount++;    
}
Console.WriteLine("Qardash yer doldu :)");

