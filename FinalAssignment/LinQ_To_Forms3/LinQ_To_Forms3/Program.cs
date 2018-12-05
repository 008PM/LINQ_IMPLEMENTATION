using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_To_Forms3
{
    class Program
    {
        static void Main(string[] args)
        {

            //------------------>>>>Instances hub------------------------>>>
            Read_AnimalData read = new Read_AnimalData();
            Selection sobj = new Selection();
            Sorting_Operations spobj = new Sorting_Operations();
            Grouping_Operations gobj = new Grouping_Operations();
            Aggregation Aobj = new Aggregation();
            //------------------>>>>Instances hub------------------------>>>


            //--------------------->>>Console Options---------------------------->>
            Console.WriteLine("1.Read All details operation");
            Console.WriteLine("2.Selection operation with where condition");
            Console.WriteLine("3.Sorting operations !");
            Console.WriteLine("4.Grouping Operations !");
            Console.WriteLine("5.Aggregation Operations !");
            //--------------------->>>Console Options---------------------------->>


            while (true)
            {
                Console.WriteLine("Kindly Enter Your Choice :");
                string Choice = Console.ReadLine();
                Console.WriteLine(Choice);
                switch (Choice)
                {
                    case "1":
                        Console.WriteLine("FILTERING OPERATIONS");
                        read.Load_Data();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("FILTERING OPERATIONS");
                        sobj.selection_Operation();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("SORTING OPERATIONS");
                        spobj.sorting_Operation();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("GROUPING OPERATIONS");
                        gobj.grouping_Operation();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("AGGREGATION OPERATIONS");
                        Aobj.aggregation_Operation();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;




                }
            }


        }
    }
}
