using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LinQ_Collections
{
    class Conversions
    {
        //--------------->>To list example--------------------------->>
        public void Conversion_Operations()
        {
            //Conversion of array to list
            Console.WriteLine("Conversion of array to list :----------->>Printing a list: ");
            int[] Random_Numbers= new int[10];
            for(int i=0;i<10;i++)
            {
                Random_Numbers[i]=i;
            }
            //Below snippet converts the array into the list
            List<int> converted_to_List = Random_Numbers.ToList();
            //Looping through and printing the values

            foreach(int item in converted_to_List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Casting example:------------------->>list ");
            ArrayList al = new ArrayList();
            for(int i=0;i<10;i++)
            {
                al.Add(i);//adding 10 numbers
            }
            IEnumerable<int> numbers = al.Cast<int>();
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
