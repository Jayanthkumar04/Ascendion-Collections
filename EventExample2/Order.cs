using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2
{
    public class Order
    {
        public event EventHandler<OrderEventArgs> OnCreated;

        public void OrderPlace(string email, string mobile, string orderItem)
        {
            Console.WriteLine("order placed for : "+orderItem);

            if(OnCreated != null)
            {
                OnCreated(this, new OrderEventArgs() { Email = email, Mobile = mobile });
            }

        }

    }
}
