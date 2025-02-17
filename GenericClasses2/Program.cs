using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CLASS MUST BE REFERENCE TYPE
            //STRUCTURE MUST BE VALUE TYPE

            OurGen<string, int> ourGen1 = new OurGen<string, int>("DLSJFAS", 11);

            OurGen<object, float> ourGen2 = new OurGen<object, float>("ljdsfl", 13.4f);

            //OurGen<object, object> ourGen3 = new OurGen<object, object>("ljdsfl", 13.4f);


            ourGen1.Display();

            ourGen2.Display();

        }
    }
}
