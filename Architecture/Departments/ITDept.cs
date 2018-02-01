using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Departments
{
    class ITDept : DepartmentBase
    {
        public ITDept(string name, string supervisor, int employeeCount) : base(name, supervisor, employeeCount)
        {
        }

        string TypeOfSupport { get; set; }

    }
}
