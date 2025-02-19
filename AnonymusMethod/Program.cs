/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusMethod
{
        public delegate void OurDel(string name);

    public delegate double MathDel(double num1, double num2);
    public class Program
    {
        static void Main(string[] args)
        {

            OurDel ourDel = delegate (string s) { Console.WriteLine(s); };

            ourDel("Sameer");

            MathDel del = delegate (double fnum, double snum) { return fnum + snum; };

            double result = del(45.50, 30.30);

            Console.WriteLine("result: \t"+result);

            Console.ReadKey();



        }
    }
}
*/

//WITH HELP OF LAMBDA EXPRESSION (=>)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusMethod
{
    public delegate void OurDel(string name);

    public delegate double MathDel(double num1, double num2);
    public class Program
    {
        static void Main(string[] args)
        {

            OurDel ourDel = ( s ) => { Console.WriteLine(s); };

            ourDel("Sameer");

            MathDel del = (fnum, snum) => fnum * snum;

            //double result = del(45.50, 30.30);

            Console.WriteLine("result after multiplication: \t"+del(5,7));

            ourDel += (msg) => Console.WriteLine("here is a msg for you " + msg);

            ourDel("sam");

            Console.ReadKey();




        }
    }
}
