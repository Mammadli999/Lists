using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Demo");
            list.Add("Demo1");
            list.Add("Demo12");
            list.Add("Demo3");

            //list.Clear();  //Herweyi Silir


            Console.WriteLine("------------");
            Console.WriteLine(list[1]);
            Console.WriteLine("------------");



            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
