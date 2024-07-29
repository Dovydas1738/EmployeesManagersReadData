using EmployeesManagersReadData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagersReadData.Contracts
{
    public interface IEmployee
    {
        List<Employee> ReadData();
        void WriteData();
    }
}
