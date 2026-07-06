using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade in number format (0-100): ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "";
        if (grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
        }
        else if (grade >= 90)
        {
            if (grade%10 >= 7)
            {
                letterGrade= "A+";
            }
            else if (grade%10 >= 3)
            {
                letterGrade= "A";
            }
            else
            {
                letterGrade= "A-";
            }
            Console.WriteLine($"Your passed the class!");
        }
        else if (grade >= 80)
        {
            if (grade%10 >= 7)
            {
                letterGrade= "B+";
            }
            else if (grade%10 >= 3)
            {
                letterGrade= "B";
            }
            else
            {
                letterGrade= "B-";
            }
            Console.WriteLine($"Your passed the class!");
        }
        else if (grade >= 70)
        {
            if (grade%10 >= 7)
            {
                letterGrade= "C+";
            }
            else if (grade%10 >= 3)
            {
                letterGrade= "C";
            }
            else
            {
                letterGrade= "C-";
            }
            Console.WriteLine($"Your passed the class!");
        }
        else if (grade >= 60)
        {
            letterGrade= "D";
        }
        else
        {
            letterGrade= "F";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}.");
    }
}