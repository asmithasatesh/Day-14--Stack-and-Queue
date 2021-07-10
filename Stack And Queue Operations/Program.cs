using System;

namespace Stack_And_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object for stack and queue operations
            StackAndQueue queue = new StackAndQueue();
            StackAndQueue stack = new StackAndQueue();
            Console.WriteLine("Welcome to Stack and Queue Operations!");
            Console.WriteLine("Enter 1 for Stack Operations");
            Console.WriteLine("Enter 2 for Queue Operations");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter 1-to Push Element to Stack");
                    Console.WriteLine("Enter 2-to peek and Pop Element onStack");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            //Push operations
                            stack.Push(70);
                            stack.Push(30);
                            stack.Push(56);
                            //Display operation
                            Console.Write("\n-----DISPLAYING STACK ELEMENTS-----\n\n");
                            int total=stack.DisplayStack();
                            break;
                        case 2:

                            //Push operations
                            int count = 0;
                            stack.Push(70);
                            stack.Push(30);
                            stack.Push(56);
                            //Display operation
                            Console.Write("\n-----DISPLAYING STACK ELEMENTS-----\n\n");
                            count = stack.DisplayStack();

                            //Pop operation
                            for (int i = 0; i <= count; i++)
                            {
                                stack.Pop();

                            }
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter 1-to Enqueue Element to Queue");
                    Console.WriteLine("Enter 2-to Dequeue on Queue");
                    int optionqueue = Convert.ToInt32(Console.ReadLine());
                    switch (optionqueue)
                    {
                        case 1:
                            //Add operations
                            int count = 0;
                            queue.Enqueue(56);
                            queue.Enqueue(30);
                            queue.Enqueue(70);

                            //Display operation
                            Console.Write("\n-----DISPLAYING QUEUE ELEMENTS-----\n\n");
                            count = queue.DisplayQueue();
                            break;

                        case 2:
                            //Push operations
                            int total = 0;
                            queue.Enqueue(56);
                            queue.Enqueue(30);
                            queue.Enqueue(70);

                            //Display operation
                            Console.Write("\n-----DISPLAYING QUEUE ELEMENTS-----\n\n");
                            count = queue.DisplayQueue();
                            for (int i = 0; i <= count; i++)
                            {
                                queue.Dequeue();
                            }
                            break;
                    }
                    break;

            }

        }
    }
}
