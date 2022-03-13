using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(true);
            stack.Push(1);
            stack.Push("False");

            Stack<int> gStack = new Stack<int>();
            gStack.Push(2);
            gStack.Push(12);
            gStack.Push(100);
            gStack.Push(444999);

            foreach (var item in gStack)
            {
                Console.WriteLine(item);
            }


        }
    }
}
