/*
Evaluate Expression
Asked in:  
Yahoo
Google
Facebook
Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, /. Each operand may be an integer or another expression.

Examples:

  ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
  ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
  */
using System.Collections.Generic;

namespace Programming.Stacks_and_Queues
{
    public class EvaluateExpression
    {
        public int EvalExpression(List<string> A)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == "+")
                {
                    int val1 = stack.Pop();
                    int val2 = stack.Pop();
                    stack.Push(val1 + val2);
                }
                else if (A[i] == "*")
                {
                    int val1 = stack.Pop();
                    int val2 = stack.Pop();
                    stack.Push(val1 * val2);
                }
                else if (A[i] == "/")
                {
                    int val1 = stack.Pop();
                    int val2 = stack.Pop();
                    stack.Push(val1 / val2);
                }
                else if (A[i] == "-")
                {
                    int val1 = stack.Pop();
                    int val2 = stack.Pop();
                    stack.Push(val1 - val2);
                }
                else
                {
                    stack.Push(int.Parse(A[i]));
                }
            }
            return stack.Peek();
        }
        public static void Main(string[] args)
        {
            EvaluateExpression obj = new EvaluateExpression();
            var result = obj.EvalExpression(new List<string> { "2", "1", "+", "3", "*" });
        }
    }
}
