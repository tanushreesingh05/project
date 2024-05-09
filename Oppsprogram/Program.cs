using System;
using System.Collections;
using System.Collections.Generic;


//Program of Queue implementation using array
namespace Oppsprogram
{
   class Queue
    {
        int[] arr;
        int size;
        int rear=-1;
        int front = 0;

       public Queue(int size)
        {
            arr = new int[size];
            this.size = size;
        }

        public bool IsEmpty()
        {
            return rear == -1;
        }
        //enqueue
        public void add(int data)
        {
            if (rear == arr.Length - 1)
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            rear++;
            arr[rear] = data;
        }
       

        public int remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            int removeditem = arr[front];
            front++;
           
           
            
            return removeditem;
        }

        public int peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }

            return arr[front];
        }
    }

    
    

    class Program
    {
        static void Main(string[] args)
        {

            Queue q = new Queue(5);
            q.add(1);
            q.add(2);
            q.add(3);
            q.add(4);
            q.add(5);

            Console.WriteLine("Front value of queue : " + q.peek());

            while (!q.IsEmpty())
            {
                Console.WriteLine(q.peek());
                q.remove();
            }





        }
    }
}