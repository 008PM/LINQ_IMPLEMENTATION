using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQ_Collections
{
    
    class Sorting_Operations
    {
        List<int> ls = new List<int>();

        public void sorting_Operation()
        {
            Console.WriteLine("Enter the value to be sorted :");
            for (int i = 0; i < 6; i++)
            {
                int p = Convert.ToInt32(Console.ReadLine());
                ls.Add(p);
                //Console.WriteLine(p);
            }
            Console.WriteLine("The List is sorted in ascending order :");
            Console.WriteLine();
            Console.WriteLine();
            var MyNewQuery = from element in ls orderby element select element;
            foreach (var element in MyNewQuery)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("The list of now sorted in descending order :");
            Console.WriteLine();
            Console.WriteLine();
            var Descending_Query_Variable = from element in ls orderby element descending select element;//descending order
            foreach (var p in Descending_Query_Variable)
            {
                Console.WriteLine(p);
            }
            //---------------------------->>>>Game of thenby and stuffs<<----------------------------------------//
            List<StudentMarks> Marks = new List<StudentMarks>();
            Marks.Add(new StudentMarks { Name = "Martin", Marks = 56, section = "B" });
            Marks.Add(new StudentMarks { Name = "Ramdev", Marks = 26, section = "A" });
            Marks.Add(new StudentMarks { Name = "Zimmer", Marks = 96, section = "A" });
            Marks.Add(new StudentMarks { Name = "Raven", Marks = 76, section = "B" });
            Console.WriteLine("Original List:");
            foreach (var m in Marks)
            {
                Console.WriteLine("Name:{0},Marks:{1},section{2}", m.Name, m.Marks, m.section);
            }
            Console.WriteLine("The list of now sorted in alphabetical order thenByDescending order :");

            //Below snippet 1st orders the elemnt by their name then orders the remains by their marks
            var MyThenByResult = Marks.OrderBy(element => element.Name).ThenByDescending(element => element.Marks);
            //Above snippet hits 2 birds with single bullet-------------------------->>>
            Console.WriteLine("Checking the results of the sorting !!");
            Console.WriteLine("Elements of list Alphabetical order:");

            foreach(var element in MyThenByResult)
            {
                Console.WriteLine(element.Name);
            }
            Console.WriteLine();
            Console.WriteLine(" Elements of list Descending order:");
            foreach(var element in MyThenByResult)
            {
                Console.WriteLine(element.Marks);
            }
            //----------------->>>Trying Reverse------------------------->>>>
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Reversal Example :");
            IEnumerable<StudentMarks> Student_Marks = Marks;
            IEnumerable<StudentMarks> Reverse_result = Student_Marks.Reverse();
            foreach(var element in Reverse_result)
            {
                Console.WriteLine("Name: {0},Marks: {1},section:{2}",element.Name,element.Marks,element.section);
            }
        
        }
    }
}
