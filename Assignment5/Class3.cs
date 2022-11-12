using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Class3
    {
        public class Q3
        {
            // Main Method
            static public void Main()
            {
                EmpDetails emp = new EmpDetails();
                LinkedList<String> my_list = new LinkedList<String>();

                my_list.AddLast("Zoya");

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Please Enter The Player 1 ID : ");
                    emp.Emp1_Id = Convert.ToInt32(Console.ReadLine());
                    my_list.AddLast(emp.Emp1_Id.ToString());

                    Console.WriteLine("Please Enter The Player 1 Name : ");
                    emp.Emp1_Name = Console.ReadLine().ToString();
                    my_list.AddLast(emp.Emp1_Name.ToString());


                    Console.WriteLine("Please Enter The Player 1 Company : ");
                    emp.Emp1_Company = Console.ReadLine().ToString();
                    my_list.AddLast(emp.Emp1_Company.ToString());


                    foreach (string str in my_list)
                    {
                        Console.WriteLine(str);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
