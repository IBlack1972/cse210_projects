using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int gradeNumber = int.Parse(grade);

        string letter = "";
        if(gradeNumber >= 90)
        {
            letter = "A";
        }
        else if(gradeNumber >= 80)
        {
            letter = "B";
        }
         else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else if (gradeNumber < 60 )
        {
            letter = "F";
        }

        int gradeSign = gradeNumber % 10;

        string sign = "";
        if (gradeNumber < 90 && gradeNumber > 60 && gradeSign >= 7)
        {
            sign = "+";
        }
        else if (gradeNumber < 90 && gradeNumber > 60 && gradeSign <= 3 )
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}");

        string message = "";
        if(gradeNumber > 70)
        {
            message = "CONGRATULATIONS!  You passed!";
        }
        else
        {
            message = "Great Effort, You'll get it next time";
        }
        Console.WriteLine(message);

    }
}