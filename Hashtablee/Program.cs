using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtablee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                { "hdd","harddisk" },
                {"ram","random access memory" },
                {"cd","compact disk" },
                {"kb","kilo byte" }

            };

            Console.WriteLine("stored valued count \t"+ht.Count);

            Console.WriteLine("keys");
            foreach(var k in ht.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("values");
            foreach(var k in ht.Values)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("key \t value");
            foreach(var k in ht.Keys)
            {
                Console.WriteLine(k + "\t\t" + ht[k]);
            }

            Hashtable ht2 = new Hashtable()
            {
                { 1,"harddisk" },
                {2,"random access memory" },
                {6,"compact disk" },
                {3,"kilo byte" }

            };

            Console.WriteLine("stored valued count \t" + ht2.Count);

            Console.WriteLine("keys");

            foreach (var k in ht2.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("values");
            foreach (var k in ht2.Values)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("key \t value");
            foreach (var k in ht2.Keys)
            {
                Console.WriteLine(k + "\t\t" + ht2[k]);
            }


            Console.WriteLine("SORTED LIST");
            SortedList st = new SortedList()
            {
                { 1,"harddisk" },
                {2,"random access memory" },
                {6,"compact disk" },
                {3,"kilo byte" }

            };

            Console.WriteLine("stored valued count \t" + st.Count);

            Console.WriteLine("keys");
            foreach (var k in st.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("values");
            foreach (var k in st.Values)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("key \t value");
            foreach (var k in st.Keys)
            {
                Console.WriteLine(k + "\t\t" + st[k]);
            }




            Console.ReadKey();
        }
    }
}
