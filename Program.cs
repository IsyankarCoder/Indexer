using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    StringDataStore sd = new StringDataStore();
                sd[0] = "0";
                sd[1] = "2";
                sd[2] = "4"; 
                for (int i = 0; i < 10; i++)
                    Console.WriteLine(sd[i] + "-"); 
                Console.WriteLine(sd["0"]);
                Console.WriteLine(sd["1"]);
                Console.WriteLine(sd["2"]);
                Console.WriteLine(sd["3"]);*/

            Indexer.GenericDataStore<int> grades = new Indexer.GenericDataStore<int>();
            grades[0] = 100;
            grades[1] = 25;
            grades[2] = 34;
            grades[3] = 42;
            grades[4] = 12;
            grades[5] = 18;
            grades[6] = 2;
            grades[7] = 95;
            grades[8] = 75;
            grades[9] = 53;

            for (int i = 0; i < grades.Length; i++)
                Console.WriteLine(grades[i]);

            Console.WriteLine("---------------------------");

            GenericDataStore<string> names = new GenericDataStore<string>(5);
            names[0] = "Steve";
            names[1] = "Bill";
            names[2] = "James";
            names[3] = "Ram";
            names[4] = "Andy";

            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);

            Console.WriteLine("---------------------------");
            Console.WriteLine(names["3"]);

        }
    }
}
