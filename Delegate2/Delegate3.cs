using System;
namespace Delegate3
{ 
    class Delegate3
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
        }
        public static void Main3(String[] args)
        {
            Del writer = WriteMessage;
            //writer("hello world");
            Del WriteCap = WriteMessageCaps;
            Del WriteSpace = WriteMessageSpace;

            //writeAll is an invocation list of delegates
            Del writeAll = writer + WriteCap +WriteSpace;
            //Outputs the number of delegates in the invocation list
            writeAll -= writer;
            Console.WriteLine(writeAll.GetInvocationList().GetLength(0));
            writeAll("Greetings");
            //Outputs the number of delegates in the invocation list
            Console.WriteLine(writeAll.GetInvocationList().GetLength(0));
        }
    }
}
