using System;

namespace Stack_And_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object for stack and queue operations
            StackAndQueue stack = new StackAndQueue();
            Console.WriteLine("Welcome to Stack and Queue Operations!");
            Console.WriteLine("Enter 1 for Stack Operations");
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

            }

        }
    }
}
