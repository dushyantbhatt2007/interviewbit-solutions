/*
Implement two stacks in an array
Create a data structure twoStacks that represents two stacks. Implementation of twoStacks should use only one array, i.e., both stacks should use the same array for storing elements. Following functions must be supported by twoStacks.
push1(int x) –> pushes x to first stack
push2(int x) –> pushes x to second stack

pop1() –> pops an element from first stack and return the popped element
pop2() –> pops an element from second stack and return the popped element

Implementation of twoStack should be space efficient.
*/
using System;

namespace Programming.Array
{
    public class TwoStacksInArray
    {
        public int size, top1, top2;
        public int[] a;
        public TwoStacksInArray(int n)
        {
            a = new int[n];
            size = n;
            top1 = -1;
            top2 = size;
        }

        public void push1(int x)
        {
            if (top1 < top2 - 1)
            {
                top1++;
                a[top1] = x;
            }
            else
                Console.WriteLine("Stack overflow");
        }
        public void push2(int x)
        {
            if (top1 < top2 - 1)
            {
                top2--;
                a[top2] = x;
            }
            else
                Console.WriteLine("Stack overflow");
        }
        public int pop1()
        {
            if (top1 >= 0)
            {
                var temp = a[top1];
                top1--;
                return temp;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }
        public int pop2()
        {
            if (top2 < size)
            {
                var temp = a[top2];
                top2++;
                return temp;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }
        /*public static void Main(string[] args)
        {
            TwoStacksInArray obj = new TwoStacksInArray(5);
            obj.push1(5);
            obj.push2(10);
            obj.push2(15);
            obj.push1(11);
            obj.push2(7);
            Console.WriteLine("Popped element from" +
                              " stack1 is " + obj.pop1());
            obj.push2(40);
            Console.WriteLine("Popped element from" +
                              " stack2 is " + obj.pop2());
        }*/
    }
}
