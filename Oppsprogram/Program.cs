using System;
using System.Collections;
using System.Collections.Generic;


//Program of stack implementation using arraylist
namespace Oppsprogram
{
   

    
    public class Stack<T>
    {
        T[] arrayList;
        int top;

        public Stack(int size)
        {
            arrayList = new T[size];
                
                top = -1;

        }


         public bool IsEmpty()
        {
            return top == -1;
        }
        public void push(T val)

        {
            if (top == arrayList.Length - 1)
            {
                Console.WriteLine("Stack is Full");
                return;
            }

            top++;
            arrayList[top] = val;

        }
        public T pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                
            }
            T popItem = arrayList[top];
                top--;
            return popItem;
            

        }
        public T peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                
            }
            return arrayList[top];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(5);

            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            Console.WriteLine("Top if the stack value : " + stack.peek());
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.pop());
            }






        }
    }
}