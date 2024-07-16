// Project Prologue
// Name: Carter Quesenberry
// Date: 6/25/2024
// Purpose: Lab #00 Command Line Program
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source 
// code from any other source constitutes plagiarism, and that I will receive 
// a zero on this project if I am found in violation of this policy.

using System;

namespace lab0
{
    class Program
    {
        static void Main(string[] args)
        {	
            // handle error if fewer than two arguments are provided:
            if (args.Length < 2)
            {
                Console.WriteLine("Error: Please provide at least two arguments.");
                return;
            }
            // loop through and print all args with their argument type:
            for (int i = 0; i < args.Length; i++) 
            { 
                // output the arguments and call GetArgumentType:
                Console.WriteLine($"Argument {i + 1}: {args[i]} (type: {GetArgumentType(args[i])})");
            }
            // keep the console window open
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        // determine argument type (int, double, string):
        static string GetArgumentType(string arg)
        {
            if (int.TryParse(arg, out int intResult))
            {
                return "int";
            }
            else if (double.TryParse(arg, out double doubleResult))
            {
                return "double";
            }
            else
            {
                return "string";
            }
        }
    }
}


