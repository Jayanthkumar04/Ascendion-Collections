using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2
{
    public class OrderEventArgs : EventArgs
    {

        public string Email { get; set; }

        public string Mobile { get; set; }
    }
}
