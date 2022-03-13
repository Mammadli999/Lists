using System;
using System.Collections;
using System.Collections.Generic;

namespace NonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //numbers[0] = 12;
            //numbers[1] = 22;
            //numbers[2] = 82;

            //Array.Resize(ref numbers, numbers.Length + 1);
            //numbers[3] = 44;

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList numbers = new ArrayList();

            //numbers.Add(1);
            //numbers.Add("Test");
            //numbers.Add(412);
            //numbers.Add(true);
            //numbers.Add(false);
            //numbers.Add(15.5);
            //numbers.Add(new DateTime(2022, 03, 13));
            //numbers.Add(DateTime.Now);
            //numbers.Add(DateTime.UtcNow);

            //numbers.RemoveAt(3); // Hansi Indexi Isteyisense Onu Silsin
            //numbers.Remove(1); // Hansi Deyeri Silsin
            //numbers.RemoveRange(0,7); // Hardan bawdasin Hara kimi silsin


            //Console.WriteLine($"count: {numbers.IndexOf(412)}");  // Deyer Hardadisa Onun Indexini Verir
            //numbers.Add("Test");
            //numbers.Add("Test1");
            //numbers.Add("Test1111");
            //numbers.Add("Test111");

            //numbers.Sort(new MyComparer());   // Ancag Eyni Weyleri Goturur Meselen String,String

            //numbers.Insert(1,"Yes"); // Hansi Indexe ne yazdirmag isteyirsense onu elave et

            //numbers.Reverse();   // Tersine Siralayir

            //Hashtable numbers = new Hashtable(); //

            //numbers.Add("bir", 111);
            //numbers.Add("iki", 22);
            //numbers.Add(0, 101);
            //numbers.Add(true, "Dogrudur");
            //numbers.Add(false, "Yanlishdir");
            //numbers.Add(11, "Test");
            //numbers.Add(10, "Test");

            //if (numbers.ContainsKey(11))
            //{
            //    Console.WriteLine("Acar Tapildi");
            //}
            //else
            //{
            //    Console.WriteLine("Acar Taplimadi");
            //}

            //Console.WriteLine(numbers["bir"]);
            //Console.WriteLine(numbers[0]);

            //Stack stack = new Stack();  // Revers kimi weydi

            //stack.Push(44);
            //stack.Push(14);                 // Elave Olaraq *queue* var, bu da yuxardan awagi duzur
            //stack.Push(13);
            //stack.Push(133);
            //stack.Push(444);


            //while (stack.Count > 0)
            //{
            //    object v = stack.Pop();
            //    Console.WriteLine(v);
            //}

            //foreach (DictionaryEntry item in numbers)
            //{
            //    Console.WriteLine($"Key: {item.Key} -> Value: {item.Value} ");
            //}

            SortedList list = new SortedList();   // MyComparer Elave olunanda tipi ferqli olanida goturur
            list.Add(4, "dort");
            list.Add(2, "iki"); 
            list.Add(3, "uc");
            list.Add(1, "bir");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}
