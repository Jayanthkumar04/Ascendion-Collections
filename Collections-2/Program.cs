using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    public class Program
    {
        static void Main(string[] args)
        {

            ArrayList studentList = new ArrayList()
            {
                "raj","anita","zoya",
                "roshan","gaurav"
            };

            Console.WriteLine("no of students "+studentList.Count);

            foreach(var n in studentList)
            {
                Console.WriteLine(n);
            }

            studentList.Sort();

            Console.WriteLine("sorted list");

            foreach(var n in studentList)
            {
                Console.WriteLine(n);
            }

            studentList.Reverse();

            Console.WriteLine("sorted list in descending order");

            foreach (var n in studentList)
            {
                Console.WriteLine(n);
            }
            studentList.Remove("raj");

            Console.WriteLine("student list after removing raj no of students \t"+studentList.Count);


            foreach (var n in studentList)
            {
               Console.WriteLine(n);
            
            }

            studentList.RemoveAt(1);
            Console.WriteLine("removing at index 1 no of students\t"+studentList.Count);

            foreach (var n in studentList)
            {
                Console.WriteLine(n);
            }

            studentList.Clear();
            Console.WriteLine("student list after clear() " + studentList.Count);

            Console.WriteLine("enter student name to add");

            string name = Console.ReadLine();

            studentList.Add(name);

            Console.WriteLine("student list after adding "+studentList.Count);

            foreach (var n in studentList)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();


        }
    }
}
