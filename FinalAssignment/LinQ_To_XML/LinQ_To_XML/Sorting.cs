using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ_To_XML
{
    class Sorting
    {
        public void sorting_Operations()
        {
            Console.WriteLine();
            Console.WriteLine();
           var document = XDocument.Load("Animal_Details.xml");
            Console.WriteLine("Sorting in desceinding order");
           var sorted_Animals = from animals in
                                document.Descendants("Animal")
                                orderby animals.Element("Sleep_time").Value
                                select animals.Element("Sleep_time").Value;

            foreach(var sleepy in  sorted_Animals)
            {
                Console.WriteLine(sleepy);
            }
        }
        
    }
}
