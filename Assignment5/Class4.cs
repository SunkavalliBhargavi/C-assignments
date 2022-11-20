using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Class4
    {
        class Employee
        { 
            int id;
            int salary;
            string name;
            string department;

            public override string ToString()
            {
                return id + " " + name + " " +
                salary + " " + department;
            }
         
            static void Main(string[] args)
            {


                List<Employee> emp = new List<Employee>()
                {


        new Employee{ id = 201, name = "Deepika",
                    salary = 12000, department = "HR" },
        new Employee{ id = 202, name = "Prameela",
                    salary = 15000, department = "Development" },
        new Employee{ id = 203, name = "Kaveri",
                    salary = 13000, department = "HR" },
        new Employee{ id = 204, name = "Saketh",
                    salary = 12000, department = "Designing" },
        new Employee{ id = 205, name = "Abhi",
                    salary = 15000, department = "Development" }
                };

             
                IEnumerable<Employee> result = emp.Where(x => x.name[0] == 'D');

          
                Console.WriteLine("ID Name Salary Department");
                
                foreach (Employee e in result)
                {

                    
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
