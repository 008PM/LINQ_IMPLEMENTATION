using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ_To_XML
{
    class XMLGenesis
    {
        public void XMLGeneration()
        {
            XDocument xmlDocument = new XDocument(
        new XDeclaration("1.0", "utf-8", "yes"),

        new XComment("LINQ To XML Demo"),

        new XElement("Animals",                    //Root of the tree

            new XElement("Animal", new XAttribute("AnimalID", 101),    //Inside the tree --->>Leaf 1
                new XElement("Genera", "Mammal"),
                new XElement("Name", "Summit"),
                new XElement("Diet", "Cheese-Burger"),
                new XElement("Sleep_time", "20hrs"),
                new XElement("Wake_Time", "2hrs")
                ),

           new XElement("Animal", new XAttribute("AnimalID", 102),
              new XElement("Genera", "Mammal"),//Inside the tree ----->Leaf2
                new XElement("Name", "Tiger"),
                new XElement("Diet", "Summit"),
                new XElement("Sleep_time", "10hrs"),
                new XElement("Wake_Time", "11hrs")),


           new XElement("Animal", new XAttribute("AnimalID", 103),    //Inside the tree ----->Leaf3
             new XElement("Genera", "Mammal"),
                new XElement("Name", "Spider"),
                new XElement("Diet", "ButterFly"),
                new XElement("Sleep_time", "10hrs"),
                new XElement("Wake_Time", "13hrs")),



            new XElement("Animal", new XAttribute("AnimalID", 104),    //Inside the tree ----->Leaf4
                  new XElement("Genera", "Mammal"),
                 new XElement("Name", "Chameleon"),
                 new XElement("Diet", "Flies"),
                 new XElement("Sleep_time", "5hrs"),
                 new XElement("Wake_Time", "16hrs")),

           new XElement("Animal", new XAttribute("AnimalID", 105),    //Inside the tree ----->Leaf4
                 new XElement("Genera", "Mammal"),
                new XElement("Name", "Dragon"),
                new XElement("Diet", "Other Animals"),
                new XElement("Sleep_time", "10Hrs"),
                new XElement("Wake_Time", "14hrs")
               ),

            new XElement("Animal", new XAttribute("AnimalID", 106),    //Inside the tree ----->Leaf4
                  new XElement("Genera", "Mammal"),
                  new XElement("Name", "Octopus"),
                  new XElement("Diet", "Fishes"),
                 new XElement("Sleep_time", "5Hrs"),
                 new XElement("Wake_Time", "19hrs")

               ),

            new XElement("Animal", new XAttribute("AnimalID", 107),
                  new XElement("Genera", "Mammal"),//Inside the tree ----->Leaf5
                 new XElement("Name", "Cat"),
                 new XElement("Diet", "rats"),
                 new XElement("Sleep_time", "15hrs"),
                 new XElement("Wake_Time", "16hrs")
                )
                ));

            xmlDocument.Save(@"C:\Users\Prashob.M\source\repos\LinQ_To_XML\LinQ_To_XML\Animal_Details.xml");

        }
       
    }
}
