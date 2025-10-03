/*
 * Brandon Kass
 * CS 201 - Grade Calculator
 * Due: 10/03/25
 */

using System;

class Program
{
    static void Main()
    {
        //Declare and initialize my name
        string studentName = "Brandon";

        //Declare and initialize the grades array
        int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

        Console.WriteLine($"Welcome {studentName}!");
        Console.WriteLine("Here are your grades:");

        int total = 0;
        int count = 0;

        //Loop through each grade
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("This grade is an A!");
                if (grade == 100)
                {
                    Console.WriteLine("WOW! A perfect score!");
                }
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("This grade is a B.");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("This grade is a C.");
            }
            else if (grade >= 65 && grade <= 69)
            {
                Console.WriteLine("This grade is a D.");
            }
            else if (grade >= 0 && grade <= 64)
            {
                Console.WriteLine("This grade is a F.");
            }
            else
            {
                Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                continue; 
            }

            total += grade;
            count++;
        }

        //Calculate the average
        double average = (double)total / count;
        Console.WriteLine($"Your final calculated average is: {average}");

        Console.WriteLine($"We have displayed all grades for {studentName}");
    }
}
