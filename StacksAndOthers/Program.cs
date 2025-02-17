using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndOthers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************STACKSSS************************");

            Stack stack = new Stack();

            stack.Push("jayanht");

            stack.Push("ram");

            Console.WriteLine("stored values \t"+stack.Count);

            foreach(var  item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("pop result :\t " + stack.Pop());


            Console.WriteLine("peek result: \t"+stack.Peek());
            Console.WriteLine("stored values :after peek\t"+stack.Count);

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("peek result:\t"+stack.Peek());

            Console.WriteLine("stored value after peek \t"+stack.Count);

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**************QUEUES**********************");

            Queue queue = new Queue();

            queue.Enqueue ("jayanht");

            queue.Enqueue("ram");

            queue.Enqueue("zaheer");

            Console.WriteLine("stored values \t" + queue.Count);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dequeue result :\t " + queue.Dequeue());


            Console.WriteLine("peek result: \t" + queue.Peek());
            Console.WriteLine("stored values :after peek\t" + queue.Count);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("peek result:\t" + queue.Peek());

            Console.WriteLine("stored value after peek \t" + queue.Count);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
 
        }
    }
}
