using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LinQ_Collections
{
    class Aggregation
    {
        public void Aggregation_Operations()
        {
            Console.WriteLine("Counting operations :");
            int []somevalues = new int[10];

            for(int i=0;i<10;i++)
            {
                somevalues[i] = i;//filling the array
                Console.WriteLine(i);
            }
            int counting_Variable = somevalues.Count();
            Console.WriteLine("The number of elements in the the array is :");
            Console.WriteLine(counting_Variable);
            int Min_Variable = somevalues.Min();
            Console.WriteLine("The min value is :");
            Console.WriteLine(Min_Variable);
            int Max_Variable = somevalues.Max();
            Console.WriteLine("The max  value is :");
            Console.WriteLine(Max_Variable);
            int Sum_Of = somevalues.Sum();
            Console.WriteLine("The sum of the values are:");
            Console.WriteLine(Sum_Of);
            double Avg_of = somevalues.Average();
            Console.WriteLine("The average of the values are :");
            Console.WriteLine(Avg_of);          
            int Aggregate_Multiply_till_5 = somevalues.Aggregate(1, (seed, n)=>seed + n);
            Console.WriteLine("The aggregate of multiplication is :");
            Console.WriteLine(Aggregate_Multiply_till_5);


        }
    }
}
