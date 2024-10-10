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
        Console.WriteLine("Who is their favorite teacher");
        string favTeach = Console.ReadLine();
        Console.WriteLine("What is their class");
        string favClass = Console.ReadLine();
        Console.WriteLine("What is their favorite holiday");
        string favHoliday = Console.ReadLine();
        Console.WriteLine("What is their favorite season");
        string favSeason = Console.ReadLine();
        Console.WriteLine("What is their dream job");
        string dreamJob = Console.ReadLine();
        Console.WriteLine("How many siblings do they have");
        string siblings = Console.ReadLine();
        Console.WriteLine("Your friends name is " + name + " they are " + age + " years old their hair color is " + hairColor + " they normaly wear " + shoes + " shoes " + " their favorite color is " + favColor + " their favorite tv show/movie is " + favMovieOrTv + " their favorite teacher is " + favTeach + " their favorite class is " + favClass + " their favorite holiday is " + favHoliday + " their favorite season is " + favSeason + " their dream job is " + dreamJob + " they have " + siblings + " they will be " + (age + 5) + " in 5 years");
    }
}