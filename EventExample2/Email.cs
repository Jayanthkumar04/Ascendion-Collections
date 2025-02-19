using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2
{
    public  class Email
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"We have sent the email to {e.Email}");
        }

    }
}
