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
        static int ageFiveYears;

        public static void Main(string[] args) 
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        AskNumberOfSiblings();
        CalculateAgeIn5Years(age);
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
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
        Console.WriteLine("What size shoes do they wear?");
        shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor()
    {
        Console.WriteLine("What is their favorite color?");
        favColor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("What is their favorite tv show or movie?");
        favMovieOrTv = Console.ReadLine();
    }
    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Who is their favorite teacher?");
        favTeach = Console.ReadLine();
    }
    public static void AskFavoriteClass()
    {
        Console.WriteLine("What is their class?");
        favClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What is their favorite holiday?");
        favHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason()
    {
        Console.WriteLine("What is their favorite season?");
        favSeason = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
        Console.WriteLine("What is their dream job?");
        dreamJob = Console.ReadLine();
    }
    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do they have?");
        siblings = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years(string age)
    {
        ageFiveYears = int.Parse(age) + 5;
    }
    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("Your friends name is " + name + " they are " + age + " years old their their eye color is " + eyeColor + " hair color is " + hairColor + " they shoe size is " + shoeSize + " their favorite color is " + favColor + " their favorite tv show/movie is " + favMovieOrTv + " their favorite teacher is " + favTeach + " their favorite class is " + favClass + " their favorite holiday is " + favHoliday + " their favorite season is " + favSeason + " their dream job is " + dreamJob + " they have " + siblings + " sibling(s) they will be " + ageFiveYears + " in 5 years");
    }
}