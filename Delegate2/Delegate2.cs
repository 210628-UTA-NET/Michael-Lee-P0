using System;

namespace Delegate2
{

    class Delegate2
    {
        //This is creating a delegate method
        public delegate void Del(string message);

        // this is a simple method that takes a string and writes it to the console
        public static void WriteMessage(string message) 
        {
            System.Console.WriteLine(message);
        }
        public static void WriteMessageCaps(string message)
        {
            System.Console.WriteLine(message.ToUpper());
        }
        public static void WriteMessageSpace(string message)
        {
            char[] ch = message.ToCharArray(); //String: collection of characters, using a char can make a string into a list
            foreach (char c in ch) //using a foreach loop
            {
                Console.Write(c);
                Console.Write(" "); //Putting a space between each letter. 
            }
            Console.WriteLine();
        }
        public static void readMessage(Del callback)
        {
            Console.WriteLine("Input message: ");
            string message = Console.ReadLine();
            callback(message);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Assign the WriteMessage method to a Del variable named handler
            Del handler1 = WriteMessage;
            Del handler2 = WriteMessageCaps;
            Del handler3 = WriteMessageSpace;  
            Del handlerall = handler1 + handler2 + handler3;
            // using the delegate to call WriteMessage
            readMessage(handlerall);
            // readMessage(handler2);
            // readMessage(handler3);

        }
    }
}

