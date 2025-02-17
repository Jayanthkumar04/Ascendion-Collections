using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassess
{
    public class OurGen<T>
    {
        T ourField;

        public OurGen(T ourParam)
        {
            ourField = ourParam;
        }

        public void Display()
        {
            Console.WriteLine("stored value: \t"+ourField+"\nData Type:\t"+ourField.GetType());
        }



    }
}
