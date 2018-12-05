using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Xml.Linq;

namespace LinQ_To_XML
{
    class Grouping
    {
        public void grouping_Operations()
        {
            Console.WriteLine();
            Console.WriteLine();
            var document = XDocument.Load("Animal_Details.xml").Element("Animals").Elements("Animal");


            var GroupByClassification = from element in document
                                        group element by element.Value
                                        into newgroup
                                        orderby newgroup.Key
                                        select newgroup.Key;
            //var GroupBy_Type = document.

            foreach (var item in GroupByClassification)
            {
                Console.WriteLine(" "+item+" ");
               
            }

        }
    }
}
