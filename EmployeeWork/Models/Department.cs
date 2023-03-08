

namespace EmployeeWork.Models
{
    internal class Department
    {
        public string Name { get; set; }

        public int EmployeeLimit { get; set; } = 2;

        public double SalaryLimit { get; set; } = 250;

      

        public Employee[] Employees { get; set; } = new Employee[0];


        public void AddEmployee(Employee employee)
        {
            if (Employees.Length < EmployeeLimit)
            {
                var employees2 = Employees;
                Array.Resize(ref employees2, employees2.Length + 1);
                employees2[employees2.Length - 1] = employee;
                Employees = employees2;
            }
          

        }
        public bool CheckSalary(double Salary)
        {
            if (Salary >= SalaryLimit)
            {
                return true;
            }
            return false;
        }
    }
}
