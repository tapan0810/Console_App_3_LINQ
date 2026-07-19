using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_3_LINQ.Linq
{
    public class Linq_Queries
    {

        List<int> numbers = new List<int>()
        {
            10,20,30,40,50,60,70,80,90,100
        };

        List<int> nums = new List<int>()
        {
            1,2,2,3,3,3,4,5,5,6,6,7,7
        };

        List<string> names = new List<string>()
        {
            "John","Jane","Jack","Jill","James","Jenny"
        };

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
            public string Department { get; set; } = string.Empty;
            public int Salary { get; set; }
        }

        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "John", Age = 30, Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Jane", Age = 25, Department = "HR", Salary = 40000 },
            new Employee { Id = 3, Name = "Jack", Age = 35, Department = "Finance", Salary = 60000 },
            new Employee { Id = 4, Name = "Jill", Age = 28, Department = "IT", Salary = 55000 },
            new Employee { Id = 5, Name = "James", Age = 32, Department = "HR", Salary = 45000 },
            new Employee { Id = 6, Name = "Jenny", Age = 29, Department = "Finance", Salary = 65000 }
        };
    }
}
