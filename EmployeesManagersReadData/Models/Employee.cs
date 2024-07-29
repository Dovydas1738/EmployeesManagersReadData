using EmployeesManagersReadData.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagersReadData.Models
{
    internal class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ReadData()
        {
            throw new NotImplementedException();
        }

        public void WriteData()
        {
            throw new NotImplementedException();
        }
    }
}
