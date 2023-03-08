

namespace EmployeeWork.Models
{
    internal class Employee
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }

        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { 
                if(value>250)
                    _salary = value; }
        }


        public bool CheckName(string Name)
        {
            if (Name.All(Char.IsLetter) && Char.IsUpper(Name[0]))
            {
                return true;
            }
            return false;
        }

        public bool CheckSurname(string Surname)
        {
            if (Surname.All(Char.IsLetter) && Char.IsUpper(Surname[0]))
            {
                return true;
            }
            return false;
        }

  
    }
}
