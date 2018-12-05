using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_To_Forms3
{
    class Aggregation
    {
        internal void aggregation_Operation()
        {
            DataClasses1DataContext context1 = new DataClasses1DataContext();

            var Counting_Variable = (from elements in context1.Tables select elements.Animal_Count).Count();
            Console.WriteLine("The number of animal types in the zoo are :{0} ,including Summit and Vishal",Counting_Variable);

            //Findingbthe minimum sleeping hours

            var least_Sleeping_Hours = (from elements in context1.Tables select elements.Animal_SleepTime).Min();
            Console.WriteLine("The least sleeping hours is : {0}",least_Sleeping_Hours);

            //Higheset number in the a perticular category is:
            var Max_type = (from elements in context1.Tables select elements.Animal_Count).Max();
            IEnumerable<String> Max_type_Name = (from elements in context1.Tables where elements.Animal_Count == Max_type select elements.Animal_Name);

            Console.WriteLine("The max number for a variety is {0} and is of type {1}",Max_type, Max_type_Name.First());
            //sum of total number of animals in the zoo are

            var Total_Numberof_Animals = (from elements in context1.Tables select elements.Animal_Count).Sum();
            Console.WriteLine("The total number of animals in the the Zoo are : {0}", Total_Numberof_Animals);

            //Now calculating the average sleeping hours of animals

            var Avg_Sleeping_Hours = (from elements in context1.Tables select elements.Animal_SleepTime).Average();
            Console.WriteLine("The average sleeping of the animals in the zoo is : {0}", Avg_Sleeping_Hours);
        }
    }
}
