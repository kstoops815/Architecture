using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Departments
{
    class HumanResources : DepartmentBase
    {
        public string Race { get; set; }

        public HumanResources(string race, string name, string supervisor, int employeeCount) : base(name, supervisor, employeeCount)
        {
            race = Race;
        }

        private Dictionary<string, string> Resumes = new Dictionary<string, string>();

        public void AddResume(string name, string resume)
        {
            Resumes.Add(name, resume);

            foreach (KeyValuePair<string, string> paper in Resumes)
            {
                Console.WriteLine($"{paper.Key} {paper.Value}");
            }
        }
    }
}
