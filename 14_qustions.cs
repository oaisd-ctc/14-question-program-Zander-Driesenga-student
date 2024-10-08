using System;
public class Program 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("What is your friends name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is their age?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the color of their hair?");
        string hairColor = Console.ReadLine();
        Console.WriteLine("What shoes do they normaly wear?");
        string shoes = Console.ReadLine();
        Console.WriteLine("What is their favorite color?");
        string favColor = Console.ReadLine();
        Console.WriteLine("What is their favorite tv show or movie");
        string favMovieOrTv = Console.ReadLine();
        Console.WriteLine("Your friends name is " + name + age + hairColor + shoes + favColor);
    }
}