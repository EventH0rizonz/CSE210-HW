using System;

class Program
{
    static void Main(string[] args)
    {
        IntroMessage();
        string userName = GetUserName();
        int userNumber = GetUserNumber();
        int numberSquared = NumberSquared(userNumber);
        DisplayResult(userName, numberSquared);

    }
    static void IntroMessage()
    {
        Console.WriteLine("Welcome to this program.");
    }
    static string GetUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }
    static int GetUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int NumberSquared(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, your favorite number squared is {squared}!");
    }

}