/*
Redundant Braces
Asked in:  
Amazon
Write a program to validate if the input string has redundant braces?
Return 0/1

0 -> NO
1 -> YES
Input will be always a valid expression

and operators allowed are only + , * , - , /

Example:

((a + b)) has redundant braces so answer will be 1
(a + (a + b)) doesn't have have any redundant braces so answer will be 0
*/
using System.Collections.Generic;

namespace Programming.Stacks_and_Queues
{
    public class RedundantBraces
    {
        public int isRedundantBraces(string A)
        {
            Stack<char> stack = new Stack<char>();
            int index = 0;
            while (index < A.Length)
            {
                char c = A[index];
                if (c == '(' || c == '+' || c == '-' || c == '*' || c == '/')
                    stack.Push(c);
                else if (c == ')')
                {
                    if (stack.Peek() == '(')
                        return 1;
                    else
                    {
                        while (stack.Count != 0 && stack.Peek() != '(')
                            stack.Pop();

                        stack.Pop();
                    }
                }
                index++;
            }
            return 0;
        }
        /*public static void Main(string[] args)
        {
            RedundantBraces obj = new RedundantBraces();
            var result = obj.isRedundantBraces("((a+b))");
        }*/
    }
}
