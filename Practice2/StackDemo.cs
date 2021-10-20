using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class StackDemo
    {

        public StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            if(stack.Count > 0)
            {
                stack.Pop();
            } else
            {
                Console.WriteLine("There are no items to pop");
            }


            for(int i = 1; i <= 10; i++)
            {
                stack.Push(i);
            }
            

            // Peek() will return the element at the top of the stack
            Console.WriteLine("The top value in the stack is: {0}", stack.Peek());
            // Pop() will remove the element at the top of the stack (make sure the stack is greater than 0)
            int popped = stack.Pop();
            Console.WriteLine("The top value in the stack is: {0} after popping: {1}", stack.Peek(), popped);


        }
        

    }
}
