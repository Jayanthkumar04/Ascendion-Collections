using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnAppDelegate
{
    public class OurClass
    {
        public static string Welcome(string name)
        {
            return "welcome to delegate mr.\\ms. " + name;
        }

        public string Display(string msg)
        {
            return "here is msg for you . " + msg;
        }
    }
}
