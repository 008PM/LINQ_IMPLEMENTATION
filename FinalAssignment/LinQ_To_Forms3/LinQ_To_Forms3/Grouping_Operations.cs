using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_To_Forms3
{
    class Grouping_Operations
    {
        internal void grouping_Operation()
        {
            DataClasses1DataContext context1 = new DataClasses1DataContext();

            var GroupByClassification = from element in context1.Tables
                                        group element by element.Animal_Type
                                        into newgroup
                                        orderby newgroup.Key
                                        select newgroup;
            Console.WriteLine("Grouping based upon the type of the genera of animal :");
            foreach(var element in GroupByClassification)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("section: {0}", element.Key);//Key is printed
                Console.WriteLine("{0}||{1}", "Genera","Name");
                foreach (var subelement in element)
                {
                    Console.WriteLine("{0}||{1}", subelement.Animal_Type, subelement.Animal_Name);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Now grouping by diet");

                var Grouping_By_diet = from elements in context1.Tables
                                       group elements by elements.Animal_Diet
                                       into newgroup1
                                       orderby newgroup1.Key
                                       select newgroup1;
                foreach(var elements in Grouping_By_diet)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("section: {0}", elements.Key);//Key is printed
                    Console.WriteLine("{0}||{1}", "Diet", "Name");
                    
                    foreach(var sublement in elements)
                    {
                        Console.WriteLine("{0}||{1}", sublement.Animal_Diet, sublement.Animal_Name);
                    }
                }
                
            }
        }
    }
}
