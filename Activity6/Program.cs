using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ask for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Create a list to store the grades
        List<int> grades = new List<int>();

        // Loop to get the grades
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter grade for student {i + 1}: ");
            int grade = int.Parse(Console.ReadLine());
            grades.Add(grade);
        }

        // Initialize counters for pass and fail
        int passCount = 0;
        int failCount = 0;

        // Loop through the grades to count passes and fails
        foreach (int grade in grades)
        {
            if (grade >= 50)
            {
                passCount++;
            }
            else
            {
                failCount++;
            }
        }

        // Display the results
        Console.WriteLine($"Pass: {passCount}, Fail: {failCount}");
    }
}
