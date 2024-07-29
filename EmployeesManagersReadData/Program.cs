using EmployeesManagersReadData.Contracts;
using EmployeesManagersReadData.Models;
using System;

namespace MyProgram
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Manager manager1 = new Manager();

            
            Console.WriteLine("Do you want to add a new employee? y/n");

            while (Console.ReadLine() == "y")
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());

                if (numberOfEmployees > 0)
                {
                    Manager manager = new Manager(numberOfEmployees, name, age);
                    manager.WriteData();
                }
                else
                {
                    Employee employee = new Employee(name, age);
                    employee.WriteData();
                }
                Console.WriteLine("Add another one? y/n");
            }

            foreach (Employee employee in employee1.ReadData())
            {

                if (employee is Manager)
                {
                    Console.WriteLine($"{employee.Name}, {employee.Age}, Manager, number of employees: {((Manager)employee).NumberOfEmployees}");
                }
                else
                {
                    Console.WriteLine($"{employee.Name}, {employee.Age}");
                }

            }


        }
    }
}