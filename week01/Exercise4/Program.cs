using System;
using System.Numerics;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            string aNumber = Console.ReadLine();
            newNumber = int.Parse(aNumber);

            if(newNumber != 0)
            {
            numbers.Add(newNumber);
            }
        }
        float total = 0;
        int largest = 0;
        for (int i = 0; i < numbers.Count(); i++)
        {
            int number = numbers[i];
            total = total + number;
            if (number > largest)
            {
                largest = number;
            }

        }
        float average = total / numbers.Count();
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}