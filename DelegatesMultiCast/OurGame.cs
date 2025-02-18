using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMultiCast
{
    public class OurGame
    {
        public void Start()
        {
            Console.WriteLine("your car can start now");
        }
        public void Jump()
        {
            Console.WriteLine("your car can jump now");
        }

        public void ExtraFuelTank()
        {
            Console.WriteLine("your car have an extra fuel tank now");
        }

        public void Fly()
        {
            Console.WriteLine("your car can fly now");
        }

        public void Reverse()
        {
            Console.WriteLine("you can go reverse now with same speed ");
        }
    }
}
