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
                            stack.Display();
                            break;
                    }
                    break;

            }

        }
    }
}
