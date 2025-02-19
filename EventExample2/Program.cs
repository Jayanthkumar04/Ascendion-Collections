using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order();
            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;
            Console.WriteLine("enter your mobile number");

            string mobile = Console.ReadLine();

            Console.WriteLine("enter your email address");

            string email = Console.ReadLine();


            Console.WriteLine("enter food items u wanted to order comma seperated!!!!!!!");
            string orderItems = Console.ReadLine();

            order.OrderPlace(email, mobile, orderItems);

            Console.ReadKey();



        }
    }
}
