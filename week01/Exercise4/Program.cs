using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        int total_sum = numbers.Sum();
        int largest_number = numbers.Max();
        int smallest_number = numbers.Min();
        double average = numbers.Average();
        Console.WriteLine($"The sum of all numbers is: {total_sum}");
        Console.WriteLine($"The largest number is: {largest_number}");
        Console.WriteLine($"The smallest number is: {smallest_number}");
        Console.WriteLine($"The average is: {average}");
    }
}