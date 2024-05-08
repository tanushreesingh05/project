using System;

namespace Oppsprogram
{
    // Program of stack DS implementation using LinkedList

   public  class Node
    {
      public int data;
       public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    class MyStack
    {
        Node head;

        public bool IsEmpty()
        {
            return head == null;
        }
       

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head= newNode;
                return;
                
            }

            newNode.next = head;
            head = newNode; 

        }
        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int top = head.data;
            head = head.next;
            return top;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return head.data;
            
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();

            s.Push(10);
            s.Push(20);
            s.Push(30);

            while (!s.IsEmpty())
            {
                Console.WriteLine(s.Peek());
                s.Pop();
            } 
        }
    }
}