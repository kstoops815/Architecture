using Architecture.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResources hrDept = new HumanResources(race: "biracial", name: "HR", supervisor: "Sue", employeeCount: 5);

            var departments = new List<DepartmentBase>();

            departments.Add(hrDept);

            foreach (DepartmentBase dept in departments)
            {
                Console.WriteLine($"{dept.toString()}");
            }

            Console.ReadLine();

        }
    }
}
