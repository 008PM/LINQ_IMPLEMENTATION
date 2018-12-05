using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ_To_XML
{
    class Selection
    {

        public void slection_Operations()
        {
          
            Console.WriteLine("Selection of names in the XML file");
            var document = XDocument.Load("Animal_Details.xml");
            var selected_animals = from animals in
                                                   document.Element("Animals").Elements("Animal")
                                                   select animals.Element("Name").Value;

            foreach (var animal in selected_animals)
            {
                Console.WriteLine(animal);
            }

        }

    }
}
