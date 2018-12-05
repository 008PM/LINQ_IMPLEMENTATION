using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQ_Collections
{
    class Selection
    {
        List<String> collection1 = new List<string>();

        public void Selection_Operation()
        {


            collection1.Add("Raven");
            collection1.Add("Mitch");
            collection1.Add("Tensor");
            collection1.Add("Razor");
            collection1.Add("Fishner");
            collection1.Add("Dan");
            collection1.Add("Tan");
            collection1.Add("Mak");
            collection1.Add("Ream");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Actual List :");
            foreach (string st in collection1)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selection of substring");
            IEnumerable<string> mynewquery = from word in collection1 select word.Substring(0, 3);

            foreach(var n in mynewquery)
            {
                Console.WriteLine(n);
            }
        }
    }
}
