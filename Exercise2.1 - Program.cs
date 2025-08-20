using System;
using System.Collections.Generic;
using System.Numerics;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    { 
        //Exercises in DATA TYPES LESSON
        EX01();
        EX02();
        EX03();
    }
    static void EX01()
    {
        //Create a C# program to convert from degrees Celsius to Kelvin and
        //Fahrenheit.Request the user the number of degrees celsius to convert
        //them using the following conversion tables:

        Console.WriteLine("Enter degree in Celsius:");
        string S = Console.ReadLine();
        double celsius = 0;
        while (!double.TryParse(S, out celsius))
        {
            Console.WriteLine("Please try again with a different number");
            S = Console.ReadLine();
        }
        double kelvin = celsius + 273;
        double fahrenheit = celsius * 18 / 10 + 32;
        Console.WriteLine($"{celsius} degree in Celsius = {kelvin} degree in Kelvin");
        Console.WriteLine($"{celsius} degree in Celsius = {fahrenheit} degree in Fahrenheit");
    }
    static void EX02()
    {
        //Create a program in C# for calculate the surface and volume of a sphere, given its radius.

        Console.WriteLine("Enter the radius of the sphere (r): ");
        string S = Console.ReadLine();
        double r = 0;
        while (!double.TryParse(S, out r))
        {
            Console.WriteLine("Please try again with a different number");
            S = Console.ReadLine();
        }
        double surface = 4 * Math.PI * Math.Pow(r, 2);
        double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"The surface of the sphere is {surface} and The volume of the sphere is {volume}");
    }
    static void EX03()
    {
        //Write a program in C# that calculates the result of adding, subtracting,
        //multiplying and dividing two numbers entered by the user.
        //- In addition you should also calculate the rest of the division on the last line.

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
}

