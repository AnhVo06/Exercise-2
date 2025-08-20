using System;
using System.Collections.Generic;
using System.Numerics;
using System.Transactions;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //Exercises in OPERATORS LESSON
        EX01();
        EX02();
        EX03();
        EX04();
        EX05();
    }
    static void EX01()
    {
        //1.Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,/,%)
        //on them and displays the result of that operation.
        Console.WriteLine("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Here are some calculations:");
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        if (b != 0)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }
        else
        {
            Console.WriteLine("Division by ZERO is not allowed");
        }
    }                       
    static void EX02()
    {
        //2.Write a C# Sharp program to display certain values of the function
        //x = y2 + 2y + 1(using integer numbers for y, ranging from - 5 to + 5).
        Console.WriteLine("y\t|\tx");
        Console.WriteLine("------------------");
        for (int y = -5; y <= 5; y++)
        {
            int x = (y * y) + (2 * y) + 1;
            Console.WriteLine($"{y}\t|\t{x}");
        }
    }
    static void EX03()
    {
        //3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) 
        //as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
        Console.WriteLine("Enter distance (km):");
        double distance = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter hours:");
        double hours = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter minutes:");
        double minutes = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter seconds:");
        double seconds = double.Parse(Console.ReadLine());
        double totatlHours = hours + (minutes / 60) + (seconds / 3600);
        double speedkmh = distance / totatlHours;
        double speedmph = speedkmh * 0.62137119;
        Console.WriteLine($"The speed in kilometers per hour is: {speedkmh} km/h\nThe speed in miles per hour is: {speedmph} miles/h");
    }
    static void EX04() 
    {
        //4.Write a C# Sharp program that takes the radius of a sphere as input and calculates
        //and displays the surface and volume of the sphere.  V = 4/3*π*r3 
        Console.WriteLine("Enter the radius:");
        double radius = double.Parse(Console.ReadLine());
        double surface = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4/3) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"The surface of the sphere is: {surface}\nThe volume of the sphere is:{volume}");
    }
    static void EX05() 
    {
        //5.Write a C# Sharp program that takes a character as input and
        //checks if it is a vowel, a digit, or any other symbol.
        Console.WriteLine("Enter a character:");
        char ch = Console.ReadKey().KeyChar;
        if ("ueoaiUEOAI".IndexOf(ch) >= 0)
        {
            Console.WriteLine($"\n{ch} is a vowel");
        }
        else if (Char.IsDigit(ch))
        {
            Console.WriteLine($"\n{ch} is a digit");
        }
        else
        {
            Console.WriteLine($"\n{ch} is other symbol");
        }
    }
}

