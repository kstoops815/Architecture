using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Departments
{
    class Marketing : DepartmentBase
    {
        public Marketing(string name, string supervisor, int employeeCount) : base(name, supervisor, employeeCount)
        {
        }

        List<string> MarketingMaterials { get; set; }
    }
}
