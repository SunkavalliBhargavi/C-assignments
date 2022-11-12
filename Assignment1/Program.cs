using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEx
{
    public delegate void mydele(int a, int b);

    class Dele
    {
        public void add(int a, int b)
        {
            Console.WriteLine("The sum is" + (a + b));
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("The Difference is" + (a - b));
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            Dele obj = new Dele();
            mydele m = new mydele(obj.add);
            m(20, 30);
            mydele m1 = new mydele(obj.sub);
            m1(20, 30);
            Dele obj1 = new Dele();
            mydele m2 = new mydele(obj1.add);
            mydele m3 = new mydele(obj1.sub);
            m2 = m2 + m3;
            m2(30, 20);
        }
    }
}
