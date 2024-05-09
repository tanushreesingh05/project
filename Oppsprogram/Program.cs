using System;



//Program of Queue implementation using linkedlist
namespace Oppsprogram
{
   
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

    }
    class Queue
    {
        Node head = null;
        Node tail = null;


        public bool IsEmpty()
        {
          return head==null & tail == null;
        
        }
        public void add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            tail.next = newNode;
            tail = newNode;

        }

        public int remove()
        {

            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            int front = head.data;
            //single element
            if (head == tail){
                head = tail = null;

            }
            else
            {
                head = head.next;
            }
            return front;

        }

        public int peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return head.data;
        }

    }


    
   

    class Program
    {
        static void Main(string[] args)
        {

            Queue q = new Queue();
            q.add(1);
            q.add(2);

            q.add(3);

            q.add(4);

            q.add(5);

            Console.WriteLine("Front element in the queue : " + q.peek());
            while (!q.IsEmpty())
            {
                Console.WriteLine(q.remove());
            }






        }
    }
}