using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.Write("What's your name? ");
        string name = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {name}!");
    }
}