using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_To_Forms3
{
    class Selection
    {
        public void selection_Operation()
        {
            DataClasses1DataContext context1 = new DataClasses1DataContext();
            Console.WriteLine("The list of sleepy fellows are");
            var More_Sleepy_Animals = from sleepy in context1.Tables where sleepy.Animal_SleepTime > 8 select sleepy;

            foreach(var sleepers in More_Sleepy_Animals)
            {
                Console.WriteLine("Animal Name:{0}",sleepers.Animal_Name);
            }
        }
    }
}
