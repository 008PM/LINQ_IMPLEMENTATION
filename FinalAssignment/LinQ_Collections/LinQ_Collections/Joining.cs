using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQ_Collections
{
    class Joining
    {
       public void Joining_Operation()
        {
            //----------------->>List of typw students<<----------------------//
            List<Student> Students = new List<Student>();

            Students.Add(new Student { Name = "Raven", StreamId = 1 });
            Students.Add(new Student { Name = "Zimmer", StreamId = 2 });
            Students.Add(new Student { Name = "Martin", StreamId = 1 });
            Students.Add(new Student { Name = "Ramdev", StreamId = 2 });

            //----------------->>List of typw studentmarks<<----------------------//
            List <StudentMarks> Marks = new List<StudentMarks>();
            Marks.Add(new StudentMarks { Name = "Martin", Marks = 56, section = "B" });
            Marks.Add(new StudentMarks { Name = "Ramdev", Marks = 26, section = "A" });
            Marks.Add(new StudentMarks { Name = "Zimmer", Marks = 96, section = "A" });
            // Marks.Add(new StudentMarks { Name = "Raven", Marks = 76, section = "B" });

            //------------------------------------------>>End of lists<<--------------------------------------------//
            //Generation of new customised list
            var mynewlist = (from S in Students join M in Marks on S.Name equals M.Name select new
            { 
                Name = S.Name,
                StreamId = S.StreamId,
                Marks = M.Marks,
                section = M.section

                
            });
            //------------------------>>>Iterating and running over ! the newly formed list<<-----------------//

            foreach(var e in mynewlist)
            {
                Console.WriteLine("Student name = {0},StreaId ={1},Marks = {2},section ={3}",e.Name,e.StreamId, e.Marks,e.section);
            }

        }

    }


    //-------------------------------------------------->>>POCO !! Classes<<----------------------------------------------------//
    class Student
    {
        public int StreamId { get; set; }
        public string Name { get; set; }
    }

    class StudentMarks
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string section { get; set; }
        public string Stream { get; set; }
    }
    //

}
