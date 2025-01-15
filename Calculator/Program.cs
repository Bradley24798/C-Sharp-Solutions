// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipelines;

Console.Write("Enter an operation symbol (+,-,*,/): ");
var Operator = Console.ReadLine();
Console.Write("Enter 1st Number: ");
var Number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd Number");
var Number_2 = Convert.ToInt32(Console.ReadLine());

// var Operator = Console.ReadLine();
switch (Operator)
{
    case "+":
        var sum = Number_1 + Number_2;
        Console.WriteLine($"Answer is {sum}");
        break;
    case "-":
        var difference = Number_2 - Number_1;
        Console.WriteLine($"Answer is {difference}");
        break;

    case "*":
        var multiplication = Number_2 * Number_1;
        Console.WriteLine($"Answer is {multiplication}");
        break;
    case "/":
        var division = Number_2 * Number_1;
        Console.WriteLine($"Answer is {division}");
        break;
    default:
        Console.WriteLine("Enter valid operator");
        break;
}
