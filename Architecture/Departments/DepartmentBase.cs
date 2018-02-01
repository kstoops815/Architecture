using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class DepartmentBase
    {
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public int EmployeeCount { get; set; }

        public DepartmentBase(string name, string supervisor, int employeeCount)
        {
            Name = name;
            Supervisor = supervisor;
            EmployeeCount = employeeCount;
        }

        public string toString()
        {
            return $"{Name}, {Supervisor}, {EmployeeCount}";
        }
    }

}
