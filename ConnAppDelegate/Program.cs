using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnAppDelegate
{
    public class Program
    {
        public delegate string OurDel(string name);
        static void Main(string[] args)
        {
        
            OurDel del = new OurDel(OurClass.Welcome);

            Console.WriteLine(del("suresh"));

            Console.ReadKey();

            OurClass ourClass = new OurClass();
            OurDel del2 = new OurDel(ourClass.Display);
            Console.WriteLine(del2("lets discuss delegates"));

            Console.ReadKey();

        
        }
    }
}
