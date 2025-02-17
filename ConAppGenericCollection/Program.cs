using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGenericCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*

            List<string> list = new List<string>()
            {
                "amit",
                "sam",
                "zoya",
                "rohan",
                "Vinit"
            };

            Console.WriteLine("no of items: \t"+list.Count);

            Console.WriteLine("Capicity \t"+list.Capacity);

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            list.Add("Rohith");list.Add("Deep"); list.Add("Zen");list.Add("Noyan");

            Console.WriteLine("after adding more items");

            Console.WriteLine("no of items:\t"+list.Count);

            Console.WriteLine("capacity\t"+list.Capacity);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("enter name to search from the list");
            string name = Console.ReadLine();

            if(list.Contains(name))
            {
                Console.WriteLine("Found at index "+list.IndexOf(name));
            }

            else
            {
                Console.WriteLine("no such name "+name+"exist in list");
            }

            Console.ReadKey();

            */


            /*

            Console.WriteLine("*************SORTED LIST******************************");

            SortedList<int, string> productList = new SortedList<int, string>()
            {
                {1,"digital camera" },
                {2,"ear phones" },
                {3,"IPhone" },
                {4,"Washing machine" }
            };

            foreach(var product in productList)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("key \t\t value");

            foreach(var k in productList.Keys)
            {
                Console.WriteLine(k + "\t" + productList[k]);
            }

            Console.WriteLine();
            */


            Console.WriteLine("*************   DICTONARY     *************************");

            Dictionary<int, string> productList = new Dictionary<int, string>()
            {
                {1,"digital camera" },
                {11,"ear phones" },
                {9,"IPhone" },
                {3,"Washing machine" }
            };

            foreach (var product in productList)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("key \t\t value");

            foreach (var k in productList.Keys)
            {
                Console.WriteLine(k + "\t" + productList[k]);
            }

            Console.WriteLine();




        }
    }
}
