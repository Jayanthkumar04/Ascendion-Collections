using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassess
{
    public class Program
    {
        static void Main(string[] args)
        {

            OurGen<int> obji = new OurGen<int>(12);

            OurGen<string> objs = new OurGen<string>("sam");

            OurGen<float> objf = new OurGen<float>(23.647f);

            obji.Display();

            objs.Display();

            objf.Display();

            Console.ReadKey();

        }
    }
}
