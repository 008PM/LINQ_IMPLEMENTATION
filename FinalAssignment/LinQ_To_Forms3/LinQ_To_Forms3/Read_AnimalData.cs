using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_To_Forms3
{
    class Read_AnimalData
    {
        public void Load_Data()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var MyAnimals = from listofanimal in context.Tables select listofanimal;
            //var list = context.Tables
            //      .Select(n => n);
            Console.WriteLine("----------------------------->>>>List of Animals------------------->>>>");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("OIUHYGF");
            foreach (var animal in MyAnimals)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine
               ("AnimalID:    {0}," +
               "Animal_Type:  {1}," +
               "Animal_Name:  {2}," +
               "Animal_Count: {3}," +
               "Animal_Diet   {4}," +
               "Animal_SleepTime{5}," +
               "Animal_WakingHours{6}",
               animal.Id,
               animal.Animal_Type,
               animal.Animal_Name,
               animal.Animal_Count,
               animal.Animal_Diet,
               animal.Animal_SleepTime,
               animal.Animal_WakingHours);
            }
        }
    }
}
