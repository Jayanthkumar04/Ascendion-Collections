using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses2
{
    public class OurGen<T,U> where T:class where U:struct
    {
        T ourField1;
        U ourField2;

        public OurGen(T ourField1,U ourField2)
        {
            this.ourField1 = ourField1;
            this.ourField2 = ourField2;
            
        }

        public void Display()
        {
            Console.WriteLine("stored value in :Field one\t "+ourField1+"\t Datatype:\t"+ourField1.GetType());

            Console.WriteLine("stored value in :Field Two\t " + ourField2 + "\t Datatype:\t" + ourField2.GetType());
        }


    }
}
