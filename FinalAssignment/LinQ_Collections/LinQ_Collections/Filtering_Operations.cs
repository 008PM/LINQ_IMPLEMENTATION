using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQ_Collections
{
    class Filtering_Operations
    {
        
        List<String> collection = new List<string>();
        internal void Where_Filtering()
        {
            collection.Add("Raven");
            collection.Add("Mitch");
            collection.Add("Tensor");
            collection.Add("Razor");
            collection.Add("Fishner");
            collection.Add("Dan");
            collection.Add("Tan");
            collection.Add("Mak");
            collection.Add("Ream");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Actual List :");
            foreach(string st in collection)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("The filtered lists");
            Console.WriteLine();
            Console.WriteLine("Words having more than 3 letters");
            IEnumerable<String> query = from word in collection where word.Length > 3 select word;

            foreach (string str in query)
            {
                Console.WriteLine(str);//printing values 
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Words having exactly 3 letters");
            IEnumerable<String> query1 = from word in collection where word.Length == 3 select word;

            foreach (string str1 in query1)
            {
                Console.WriteLine(str1);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Words having more than 4 letters");
            IEnumerable<string> query2 = from word in collection where word.Length > 4 select word;
            foreach (string str2 in query2)
            {
                Console.WriteLine(str2);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Words ending with r");
            IEnumerable<string> query3 = from word in collection where word.EndsWith("r") select word;
            foreach(string str in query3)
            {
                Console.WriteLine(str);
            }



        }
    }
}
