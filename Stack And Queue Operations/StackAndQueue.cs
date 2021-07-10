using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_And_Queue_Operations
{
    class StackAndQueue
    {
        Node top;

        //STACK OPERATIONS
        //Push data at Top
        public void Push(int data)
        {
            Node newNode = new Node(data);
            top = Add(newNode);
        }

        //Add data at top
        public Node Add(Node newNode)
        {
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
            return top;
        }
        //Pop data from top
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack is empty! Nothing to Pop");
                return;
            }
            Console.WriteLine("\n***POPPED ELEMENT***\n{0}", Peek());
            top = top.next;
        }

        //Peek at top element and return
        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("No element in stack to pop");
                return -1;
            }
            return top.data;
        }
        //Display stack data
        public int DisplayStack()
        {
            Node temp = top;
            int count = 0;
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
            return count;
        }


        //QUEUE OPERATIONS
        Node front;

        //Push data at rear
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            Append(newNode);
        }

        //Add data at rear
        public void Append(Node newNode)
        {
            if (front == null)
            {
                front = newNode;
            }
            else
            {
                Node temp = GetLastNode();
                temp.next = newNode;

            }
        }
        public Node GetLastNode()
        {
            Node temp = front;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Dequeue data from front
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("\nQueue is empty! Nothing to Pop");
                return;
            }
            Console.WriteLine("\nDE QUEUED ELEMENT: {0}", front.data);
            front = front.next;
        }
        //Display Queue data
        public int DisplayQueue()
        {
            Node temp = front;
            int count = 0;
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
            return count;
        }




    }
}
