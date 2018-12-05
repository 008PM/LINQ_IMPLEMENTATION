using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ_To_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------->>>Instance generation-------------------------->>>
            //XMLGenesis xobj = new XMLGenesis();
            Selection sobj = new Selection();
            Sorting sorobj = new Sorting();
            Grouping g = new Grouping();
            


            //---------------->>>Function call through oinstances------------------>>
            //xobj.XMLGeneration();
            sobj.slection_Operations();
            sorobj.sorting_Operations();
            g.grouping_Operations();
        }
    }
}
