using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company("Aas", 3);
            Employee e = new Employee(1, "DAS", 231, "MENTOR");
            
            c.AddEmployee(e);
            c.GetEmployees();
        }

    }

    class Employee
    {
        public int No;
        public string FullName;
        public double Salary;
        public string Position;

        public Employee(int no, string fullname, double salary, string position)
        {
            No = no;
            FullName = fullname;
            Salary = salary;
            Position = position;
        }
    }

    class Company
    {
        public int Limit;
        private Employee[] Employees = {};
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                   Console.WriteLine("Boyuk herfle baslamalidir.");
                   return;
                }
                for (int i = 0; i < value.Length; i++) 
                {
                    if (!char.IsLetter(value[i]) && !char.IsDigit(value[i]) && value[i] != ' ')
                    {
                        throw new Exception("Name Error.");
                    }
                }
            }
        }

        public Company(string name, int limit)
        {
            Name = name;
            Limit = limit;
        }

        public void AddEmployee(Employee employee)
        {
            if (Limit > Employees.Length)
            {
                Array.Resize(ref Employees, Employees.Length +1);
                Employees[Employees.Length - 1] = employee;
            } 
        }

        public void GetEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.FullName);
            }
        }

        public Employee SearchEmployee(Employee employee)
        {
            foreach (Employee item in Employees)
            {
                if (item.FullName == employee.FullName)
                {
                    return item;
                }
            }

            return null;
        }
    }
}