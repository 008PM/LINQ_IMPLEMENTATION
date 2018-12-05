using System;

namespace LinQ_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Joining jobj = new Joining();
            Filtering_Operations fobj = new Filtering_Operations();//An instance of filtering operations
            Selection sobj = new Selection();//An instance of the Selection class
            Sorting_Operations sortobj = new Sorting_Operations();
            Grouping gobj = new Grouping();
            Conversions cobj = new Conversions();
            Aggregation aobj = new Aggregation();

            Console.WriteLine("1.Where operation");
            Console.WriteLine("2.Iterate and read the elements of the Queue");
            Console.WriteLine("3.Selection operations !");
            Console.WriteLine("4.Sorting Operations !");
            Console.WriteLine("5.Grouping Operations !");
            Console.WriteLine("6.Conversion Operations !");
            Console.WriteLine("7.Aggregation Operations !");

            while (true)
            {
                Console.WriteLine("Kindly Enter Your Choice :");
                string Choice = Console.ReadLine();
                Console.WriteLine(Choice);
                switch (Choice)
                {
                    case "1":
                        Console.WriteLine("FILTERING OPERATIONS");
                        fobj.Where_Filtering();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("JOINING OPERATIONS");
                        jobj.Joining_Operation();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("SELECTION OPERATIONS");
                        sobj.Selection_Operation();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("SORTING OPERATIONS");
                        sortobj.sorting_Operation();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("Grouping OPERATIONS");
                        gobj.Grouping_Operations();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "6":
                        Console.WriteLine("Conversion OPERATIONS");
                        cobj.Conversion_Operations();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "7":
                        Console.WriteLine("Aggregation OPERATIONS");
                        aobj.Aggregation_Operations();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;




                }
            }
        }
    }
}
