using System.Collections;

namespace colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();

            myQueue.Enqueue("First Element");
            myQueue.Enqueue("Second Element");
            myQueue.Enqueue("Third Element");
            myQueue.Enqueue("Fourth Element");

            Queue myQueueClone =  (Queue)myQueue.Clone();

            Console.WriteLine("Queue size: " + myQueue.Count);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Element " + (i + 1) + ": " + myQueue.Dequeue());
            }

            Console.WriteLine("Queue size after dequeue: " + myQueue.Count);
        }
    }
}
