using System;

namespace Oppsprogram
{
    // Program of stack DS
    class MyStack
    {
        int maxsize;
        int[] stackArray;
        int top;

        public MyStack(int size)
        {
            maxsize = size;
            stackArray = new int[maxsize];
            top = -1;
        }

        // Push operation
        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            top++;
            stackArray[top] = value;
        }

        // Pop operation
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            int val = stackArray[top];
            top--;
            Console.WriteLine("Popped element: " + val);
            return val;
        }

        // Peek operation
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return stackArray[top];
        }

        // Utility function to check if the stack is empty
        public bool IsEmpty()
        {
            return (top == -1);
        }

        // Utility function to check if the stack is full
        public bool IsFull()
        {
            return (top == maxsize - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack(5);

            s.Push(10);
            s.Push(20);
            s.Push(30);

            Console.WriteLine("Top element: " + s.Peek());

            s.Pop();
            s.Pop();

            Console.WriteLine("Top element after popping: " + s.Peek());
        }
    }
}