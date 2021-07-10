using System;
using Models;
public class ModelsTest
{
    public static void Main(string [] args)
    { 
        //Arrange
        Customer c1 = new Customer();
        string name = "Sean Young";

        //Act
        c1.LastName = name;

        //Assert
        Test(c1.LastName, "ABCDEFG");

    }
    public static void Test(object received, object expected)
    {
        if(received != expected) Console.WriteLine("EXPECTED: {0}, GOT {1}", expected, received);
    }

        
    
}