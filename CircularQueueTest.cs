using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CircularQueueTest
    {
        public static void Main(string[] args)
        {
            CircularQueueClass<string> cqueue = new CircularQueueClass<string>(5);

            Console.WriteLine("Enter the values in the Queue:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + "st value: ");
                string value = Console.ReadLine();
                cqueue.Enqueue(value);
            }
            cqueue.Display();
            Console.WriteLine();    
            Console.WriteLine("Dequeueing...");
            for (int i = 0; i < 5; i++)
            {
                cqueue.Dequeue();
            }
            cqueue.Enqueue("hey");
            cqueue.Enqueue("ho");
            cqueue.Display();

            
        }
    }
}
