using System;



//Program of Queue implementation using linkedlist
namespace Oppsprogram
{
   
  
    
    class Queue<T>
    {
        T[] arrList;
        int front = 0;
        int rear = -1;
        int size;

        public Queue(int size)
        {
            arrList = new T[size];
            this.size = size;
        }


        public bool IsEmpty()
        {
          return rear==-1;
        
        }
        public void add(T data)
        {
            if(rear==arrList.Length-1)
            {
                Console.WriteLine("Queue is Full");
            }
            rear++;
            arrList[rear] = data;

        }

        public T remove()
        {

            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                
            }

            T removeditem = arrList[front];
            front++;

            return removeditem;

        }

        public T peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                
            }
            return arrList[front];
        }

    }


    
   

    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> q = new Queue<int>(5);
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