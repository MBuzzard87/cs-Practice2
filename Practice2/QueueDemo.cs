using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class QueueDemo
    {


        public QueueDemo()
        {
            Queue<int> queue = new Queue<int>();


            for(int i = 1; i <= 3; i++)
            {
                queue.Enqueue(i);
                
            }

            Console.WriteLine("The value at the frontofthe queue is: {0}", queue.Peek());

            if(queue.Count > 0)
            {
                int removed = queue.Dequeue();

                Console.WriteLine("The value removed from the queue was: {0}." +
                    "The value at the front is now: {1}", removed, queue.Peek());
            } else
            {
                Console.WriteLine("There are no values within the queue");
            }
            









        }


    }
}
