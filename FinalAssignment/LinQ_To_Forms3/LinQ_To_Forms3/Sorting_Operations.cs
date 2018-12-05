using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_To_Forms3
{
    class Sorting_Operations
    {
        internal void sorting_Operation()
        {
            DataClasses1DataContext context1 = new DataClasses1DataContext();

            //--------------------->>Name in alphabetical order---------------------->>>//
            var OrderByAscendoing = from animal in context1.Tables orderby animal.Animal_Name select animal;
            Console.WriteLine("The names in Alphabetical order are:");
            foreach (var ascend in OrderByAscendoing)
            {
                Console.WriteLine("Name: {0}", ascend.Animal_Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //--------------------->.Name of the animals in descinding order of sleeping hours------>>
            var OrderByDescendingOrder = from sleepy1 in context1.Tables orderby sleepy1.Animal_SleepTime descending select sleepy1;
            foreach(var sleepyfellows in OrderByDescendingOrder)
            {
                Console.WriteLine("Name:{0},Sleeping Hours:{1}",sleepyfellows.Animal_Name,sleepyfellows.Animal_SleepTime);
            }

        }
    }
}
