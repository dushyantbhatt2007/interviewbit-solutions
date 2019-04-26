/*Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

push(x) – Push element x onto stack.
pop() – Removes the element on top of the stack.
top() – Get the top element.
getMin() – Retrieve the minimum element in the stack.
Note that all the operations have to be constant time operations.

Questions to ask the interviewer :

Q: What should getMin() do on empty stack? 
A: In this case, return -1.

Q: What should pop do on empty stack? 
A: In this case, nothing. 

Q: What should top() do on empty stack?
A: In this case, return -1
 NOTE : If you are using your own declared global variables, make sure to clear them out in the constructor. */

using System.Collections.Generic;

namespace Programming.Stacks_and_Queues
{
    public class MinStack
    {
        Stack<int> minStack = new Stack<int>();
        Stack<int> stack = new Stack<int>();
       
        public void Push(int x)
        {
            stack.Push(x);
            if (minStack.Count == 0 || x <= minStack.Peek())
                minStack.Push(x);
        }
        public void Pop()
        {
            if (stack.Count != 0)
            {
                var popped = stack.Pop();
                if (popped == minStack.Peek())
                    minStack.Pop();
            }
        }
        public int Top()
        {
            if (stack.Count == 0)
                return -1;
            return stack.Peek();
        }
        public int getMin()
        {
            if (minStack.Count == 0)
                return -1;
            return minStack.Peek();
        }
        /*public static void Main(string[] args)
        {
            MinStack obj = new MinStack();
            obj.Push(1);
            obj.Push(5);
            obj.Push(0);
            obj.Pop();
            var top = obj.Top();
            var min = obj.getMin();
        }*/
    }
}
