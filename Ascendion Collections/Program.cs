using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascendion_Collections
{
    public  class Program
    {
        static void Main(string[] args)
        {

            var myVar = 12;

            var myVar2 = "jayanth";
            Console.WriteLine("myVar dataype is "+myVar.GetType());

            Console.WriteLine("myVar2 datatpe is "+myVar2.GetType());

            ArrayList al = new ArrayList()
            {
                "Sam",
                'A',
                DateTime.Now,
                12.45
            };

            Console.WriteLine("no of elements in the arrayList:\t "+al.Count);

            Console.WriteLine("capacity of arraylist\t"+al.Capacity);

            Console.WriteLine("**************elements of arraylist*******************");

            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
