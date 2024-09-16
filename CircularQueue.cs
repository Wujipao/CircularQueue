using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CircularQueueClass<T> //<T> 
    {
        // Array to store queue elements
        T[] queue;
        // Size of the queue
        int size;
        //Index of the front element
        int front;
        //Index of the rear element
        int rear;
        //Current number of elements
        int count;

        public CircularQueueClass(int s)  // Constructor to initialize the queue with a given size
        {
            this.size = s;
            this.queue = new T[s];
            this.front = 0;
            this.rear = -1;
            this.count = 0;
        }
        public bool isEmpty() //to check if the queue is empty
        {
            return count == 0;
        }
        public bool isFull() //to check if the queue is full
        {
            return count == size;
        }
        public void Enqueue(T value) //to add an element to the queue
        {
            if (isFull())
            {
                Console.WriteLine("Your Queue is full.");
            }
            rear = (rear+1) % size; // ex: rear = ((-1)+1) % 5 = 0
            queue[rear] = value; // ex: queue[0] = value (value will be added at index 0)
            count++; //increment number of counts
        }
        public void Dequeue() //to remove the element from the queue
        {
            if (isEmpty())
            {
                Console.WriteLine("Your Queue is empty. Nothing can be dequeued.");
            }
            T dequeued = queue[front]; //ex: dequeued = queue[0] (let's say the value 1 is in this index)
            front = (front+1) % size; // front = (0+1) % 5 = 1 -- Therefore, front will be at index 1, logically removing the elemnt from index 0.
            count--; //decrement the number of counts
            Console.WriteLine("{0} is dequeued from the queue.", dequeued);
        }
        public int Count
        {
            get { return count; }
        }
        public void Display() //method to get a string representation of the queue in printing.
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            int i = front;
            int itemsDisplayed = 0;

            while (itemsDisplayed < count)
            {
                Console.Write(queue[i] + " ");
                i = (i + 1) % size;
                itemsDisplayed++;
            }
            Console.WriteLine();
        }
    }
}
