using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsPrograms.Collection
{
    internal class genericIcompare
    {
        static void Main(string[] args)
        {
            Employee4 obj1 = new Employee4 { Salary = 20000, Name = "ABCD"};
            Employee4 obj2 = new Employee4 { Salary = 40000, Name = "WXYZ"};
            CheckSalary c = new CheckSalary();
            int result = c.Compare(obj1, obj2);

            if (result == 1)
            {
                Console.WriteLine("employee1 has higher salary than employee2");
            }
            else if (result == -1)
            {
                Console.WriteLine("employee 1 has less salary than employee2");
            }
            else
            {
                Console.WriteLine("employee1 and employee2 has equal salary");
            }


        }
    }
    public class Employee4
    {
        public int Salary { get; set; }
        public string Name { get; set; }
    }
    /*public class checksalary : IComparer<Employee4>
    {

    }*/
    public class CheckSalary : IComparer<Employee4>
    {
        public int Compare(Employee4 e, Employee4 e2)
        {
            if (e.Salary > e2.Salary)
            {
                return 1;
            }
            else if (e.Salary < e2.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
