using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample_Delegate_
{
    public delegate void PrintDetails();

    
   

    public class Program
    {
        //event DelegateName EventName;

        event PrintDetails Print;

        void Show()
        {
            Console.WriteLine("This program illustarate how to subscibe objects to an event");

            Console.WriteLine("this method will not execute since the event has not been raised");
        }


        static void Main(string[] args)
        {

            Program objTestEvent = new Program();

            objTestEvent.Print += new PrintDetails(objTestEvent.Show);

            Console.WriteLine("do you wanna print if yes press p");

            string print = Console.ReadLine().ToLower();

            if(print == "p")
            {
                objTestEvent.Print.Invoke();
            }
            else
            {
                Console.WriteLine("you decided not to print");
            }

            Console.ReadKey();
        }
    }
}
