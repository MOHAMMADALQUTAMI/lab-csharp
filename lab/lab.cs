using System;
using System.Text;

class program
{
    static void Main(string[] args)
    {
        // Using StringBuilder
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello ");
        sb.Append("World!");
        Console.WriteLine(sb.ToString()); // Output: Hello World!

        // Using String Interpolation
        string firstName = "John";
        string lastName = "Doe";
        int age = 30;
        string message = $"My name is {firstName} {lastName} and I'm {age} years old.";
        Console.WriteLine(message); // Output: My name is John Doe and I'm 30 years old.
    }
}