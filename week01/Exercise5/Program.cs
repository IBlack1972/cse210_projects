using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        float squaredNumber = SquareNumber(userNumber);
        DisplayResults(squaredNumber, userName);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");   
    }

    static string PromptUserName()
    {
        Console.Write("Please Enter Your Name: ");
        String userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static float SquareNumber(int userNumber)
    {
        float squared = userNumber * userNumber;
        return squared;
    }

    static void DisplayResults(float squared, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}");
    }
}