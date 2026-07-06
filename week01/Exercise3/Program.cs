using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        while (true)
        {
            Console.Write("What is your guess? :");
            int guess = int.Parse(Console.ReadLine());
            if (guess == magic_number)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }char 

        
    }
}