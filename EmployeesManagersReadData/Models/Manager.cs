using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagersReadData.Models
{
    internal class Manager : Employee
    {
        public int NumberOfEmployees { get; set; }

        public Manager(int numberOfEmployees, string name, int age) : base(name, age)
        {
            NumberOfEmployees = numberOfEmployees;
            Name = name;
            Age = age;
        }

        public Manager() { }

        public static List<Employee> ReadData()
        {
            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = new StreamReader("C:\\Users\\dovis\\source\\repos\\EmployeesManagersReadData\\EmployeesManagersReadData\\employeesData.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length <= 2)
                    {
                        employees.Add(new Employee(values[0], int.Parse(values[1])));

                    }
                    else
                    {
                        employees.Add(new Manager(int.Parse(values[2]), values[0], int.Parse(values[1])));

                    }
                }
                return employees;
            }
        }

        public void WriteData()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\dovis\\source\\repos\\EmployeesManagersReadData\\EmployeesManagersReadData\\employeesData.txt", true))
            {
                sw.WriteLine($"{Name},{Age},{NumberOfEmployees}");
            }

        }



    }
}
