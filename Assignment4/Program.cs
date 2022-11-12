using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Class1
    {
        class MyStack
        {
            int[] arr;
            int top;
            int Size;
            public MyStack(int size)
            {
                arr = new int[size];
                top = -1;
                Size = size;

            }

            public void Push(int item)
            {
                try
                {
                    arr[++top] = item;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            public int pop()
            {
                Console.WriteLine("Poped elements are:" + arr[top]);
                return arr[top--];
            }

            public void PrintStack()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                else if (top >= Size)
                {
                    Console.WriteLine("Stack is full");
                    return;
                }
                else
                {
                    for (int i = 0; i <= top; i++)
                    {
                        Console.WriteLine("Element" + (i + 1) + ":" + arr[i]);
                    }
                }
            }


        }
        class Program
        {
            static void Main()
            {
                StackException se = new StackException();
                se.Method();
            }
        }
        class StackException
        {
            public void Method()
            {
                MyStack S = new MyStack(5);
                S.Push(1);
                S.Push(2);
                S.Push(3);
                S.Push(4);
                S.Push(5);
                Console.WriteLine("Items:");
                S.PrintStack();
                S.pop();
                S.PrintStack();
                S.Push(5);
                S.Push(6);

            }
        }
    }
}

