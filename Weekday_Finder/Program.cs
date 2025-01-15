// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace Weekday_Finder
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Enter an Integer ranging from 1 to 5: ");
            var Weekday = Console.ReadLine();
            switch (Weekday)
            {
                case("1"):
                    Console.WriteLine("Monday");
                    Console.Write("Is it a holiday(yes / no): ");
                    var con1 = Console.ReadLine();
                    switch (con1)
                    {
                        case("yes"):
                            Console.Write("Holiday");
                            break;
                        default:
                            Console.WriteLine("Workday");
                            break;
                    }
                    break;
                case("2"):
                    Console.WriteLine("Tuesday");
                    Console.Write("Is it a holiday or a weekday (yes / no): ");
                    var con2 = Console.ReadLine();
                    switch (con2)
                    {
                        case("yes"):
                            Console.Write("Holiday");
                            break;
                        default:
                            Console.WriteLine("Workday");
                            break;
                    }
                    break;
                case("3"):
                    Console.WriteLine("Wednesday");
                    Console.Write("Is it a holiday or a weekday (yes / no): ");
                    var con3 = Console.ReadLine();
                    switch (con3)
                    {
                        case("yes"):
                            Console.Write("Holiday");
                            break;
                        default:
                            Console.WriteLine("Workday");
                            break;
                    }
                    break;
                
                case("4"):
                    Console.WriteLine("Thursday");
                    Console.Write("Is it a holiday or a weekday (yes / no): ");
                    var con4 = Console.ReadLine();
                    switch (con4)
                    {
                        case("yes"):
                            Console.Write("Holiday");
                            break;
                        default:
                            Console.WriteLine("Workday");
                            break;
                    }
                    break;
                 case("5"):
                    Console.WriteLine("Friday");
                    Console.Write("Is it a holiday or a weekday (yes / no): ");
                    var con5 = Console.ReadLine();
                    switch (con5)
                    {
                        case("yes"):
                            Console.Write("Holiday");
                            break;
                        default:
                            Console.WriteLine("Workday");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Integer input");
                    break;
            }
        }
    }
}