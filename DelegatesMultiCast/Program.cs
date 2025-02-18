using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMultiCast
{
    internal class Program
    {
        public delegate void OurDel();
        static void Main(string[] args)
        {
            OurGame cargame = new OurGame();

            OurDel objDel = new OurDel(cargame.Start);

            objDel();


            objDel += new OurDel(cargame.Jump);
            objDel += new OurDel(cargame.ExtraFuelTank);

            Console.WriteLine("after adding 2 methods in invocation list of delegate");

            objDel();

            objDel += new OurDel(cargame.ExtraFuelTank);
            objDel += new OurDel(cargame.ExtraFuelTank);

            Console.WriteLine("after adding 5 methods in invocation list of delegate");
            objDel();

            objDel += new OurDel(cargame.Fly);
            Console.WriteLine("after adding 6 methods in invocation list of delegate");

            objDel();

            objDel -= new OurDel(cargame.ExtraFuelTank);
            Console.WriteLine("AFTER removing one extra fuel tank");
            objDel();


            objDel -= new OurDel(cargame.Fly);

            objDel -= new OurDel(cargame.ExtraFuelTank);

            Console.WriteLine("after removing two extrafuel tank and fly");

            objDel();

            Console.ReadKey();


        }
    }
}
