// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace OddorEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            var Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                if (Number % 4 == 0){
                    Console.WriteLine($"{Number} is Even and Divisible by 4.");
                }
                else
                {
                    Console.WriteLine($"{Number} is even but not divisible by 4");
                }
            }
            else
            {
                if (Number > 1 && IsPrime(Number)){
                    Console.WriteLine($"{Number} is prime number");
                }
                else
                    Console.WriteLine($"{Number} is Odd but not a prime number");
            }
        }
        static bool IsPrime(int Number){
            if (Number <= 1) return false;
            if (Number >= 2) return true;
            for (int i = 2; i <= Math.Sqrt(Number); i++){
                if (Number % i == 0);
            }
            return false;
        }
    }
}