using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Overriding
    {
        //creating a class person
        public class Person
        {
            //writing a method eat
            public virtual void eat()
            {
                Console.WriteLine("Eating");
            }
            //creating a base class for person class
            public class Man : Person
            {
                //overriding a method eat 
                public override void eat()
                {
                    Console.WriteLine(" Eating.....");
                }

            }
            //testing the overriding
            public class overRiding
            {
                public static void Main()
                {
                    Man M = new Man();
                    M.eat();
                }
            }
        }
    }
}
