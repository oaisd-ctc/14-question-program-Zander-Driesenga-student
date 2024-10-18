using System;
public class Program 
{    
        static string name;
        static string age;
        static string eyeColor;
        static string hairColor;
        static string shoeSize;
        static string favColor;
        static string favMovieOrTv;
        static string favTeach;
        static string favClass;
        static string favHoliday;
        static string favSeason;
        static string dreamJob;
        static string siblings;
        static int ageFiveYears = int.Parse(age) + 5;

        public static void Main(string[] args) 
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        
        Console.WriteLine("What is their favorite color?");
        string favColor = Console.ReadLine();
        Console.WriteLine("What is their favorite tv show or movie?");
        string favMovieOrTv = Console.ReadLine();
        Console.WriteLine("Who is their favorite teacher?");
        string favTeach = Console.ReadLine();
        Console.WriteLine("What is their class?");
        string favClass = Console.ReadLine();
        Console.WriteLine("What is their favorite holiday?");
        string favHoliday = Console.ReadLine();
        Console.WriteLine("What is their favorite season?");
        string favSeason = Console.ReadLine();
        Console.WriteLine("What is their dream job?");
        string dreamJob = Console.ReadLine();
        Console.WriteLine("How many siblings do they have?");
        string siblings = Console.ReadLine();
        int ageFiveYears = int.Parse(age) + 5;
        DisplaySummaryMessage();
    }
    public static void AskName()
    {
        Console.WriteLine("What is your friends name?");
        name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine("What is their age?");
        age = Console.ReadLine();
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("What color is their eyes?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine("What is the color of their hair?");
        string hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
        Console.WriteLine("What size shoes do they wear?");
        string shoeSize = Console.ReadLine();
    }
    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("Your friends name is " + name + " they are " + age + " years old their their eye color is " + eyeColor + " hair color is " + hairColor + " they shoe size is " + shoeSize + " their favorite color is " + favColor + " their favorite tv show/movie is " + favMovieOrTv + " their favorite teacher is " + favTeach + " their favorite class is " + favClass + " their favorite holiday is " + favHoliday + " their favorite season is " + favSeason + " their dream job is " + dreamJob + " they have " + siblings + " they will be " + ageFiveYears + " in 5 years");
    }
}