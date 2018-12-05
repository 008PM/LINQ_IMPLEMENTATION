using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQ_Collections
{
    //Rise of complexity-------------------------->>>Increased difficulty
    class Grouping
    {
           public void Grouping_Operations()
        {
            //For all this magic the POCO classes lie in the joining !!
            List<StudentMarks> Marks = new List<StudentMarks>();
            Marks.Add(new StudentMarks { Name = "Martin", Marks = 56, section = "B",Stream ="Science"});
            Marks.Add(new StudentMarks { Name = "Ramdev", Marks = 26, section = "A", Stream = "Science" });
            Marks.Add(new StudentMarks { Name = "Zimmer", Marks = 96, section = "A", Stream = "Commerce" });
            Marks.Add(new StudentMarks { Name = "Raven", Marks = 76, section = "B", Stream = "Science" });
            Marks.Add(new StudentMarks { Name = "Toro", Marks = 56, section = "A", Stream = "Commerce" });
            Marks.Add(new StudentMarks { Name = "Caprio", Marks = 76, section = "B", Stream = "Commerce" });
            Marks.Add(new StudentMarks { Name = "Xavier", Marks = 76, section = "B", Stream = "HUmanities" });
            Marks.Add(new StudentMarks { Name = "Rozario", Marks = 56, section = "A", Stream = "HUmanities" });
            Marks.Add(new StudentMarks { Name = "Strange", Marks = 76, section = "B", Stream = "HUmanities" });


            //----------------------->>>>1st example of grouping---------------------------->>
            var Resulting_Group = from element in Marks group element by element.section into newgroup orderby newgroup.Key select newgroup;

            foreach(var element in Resulting_Group)//Rolling over the grouping variable ie section
            {
                //Making a division under this
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("section: {0}",element.Key);//Key is printed
                Console.WriteLine("{0}||{1}||{2}","Name","Marks","section");
                foreach (var subelelement in element)
                {
                    Console.WriteLine("{0}||{1}||{2}",subelelement.Name,subelelement.Marks,subelelement.section);
                }
            }

            //----------------------->>>>2nd example of grouping---------------------------->>//Key is the element upon which grouping is done
            var Mynew_Selecting_group = from element in Marks group element by element.Stream into newgroup1 orderby newgroup1.Key select newgroup1;

            foreach(var element in Mynew_Selecting_group)
            {  
                //Making a division under this
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("section: {0}",element.Key);//Printing 
                Console.WriteLine("{0}||{1}||{2}||{3}", "Name", "Marks", "section","Stream");

                foreach(var subelement in element)
                {
                    Console.WriteLine("{0}||{1}||{2}||{3}", subelement.Name, subelement.Marks, subelement.section, subelement.Stream);
                }
            }
            //--------------------------->>>>End of grouping games----------------------------->>>
           
        }

    }
}
