/*
 * Name: Ahmed Affaan
 * Title: Program.cs
 * Folder: C-Sharp/Variables
 * Date: 03/12/2022
 * Country: Republic of Maldives
 * Code version: -
 * Description: Understanding variables in C#
 * Credits to: Bro Code
 * Credits to link: https://www.youtube.com/watch?v=wxznTygnRfQ
 * Note: Uncomment codes to execute and comment them when not in use.
 */

// Using system libraries.
using System;

namespace Variables{
    // Main class.
    class Program{
        // Main function.
        static void Main(string[] args){
            int x; // Variable declaration.
            x = 123; // Variable initialization.
            int y = 321; // Variable declared and initialized.
            int z = x + y; // Calculates sum of variables x and y.
            int age = 23; // Integer variable for age.
            double ExactAge = 23.9; // Decimal number variable for age.
            double ExactHeight = 300.5; // Decimal number variable for height.
            bool IsAlive = true; // Boolean value for alive status.
            bool IsNotAlive = false; // Boolean value for not alive status.
            char symbol = '@';

            // Displaying variable values.
            Console.WriteLine("Variable x value: " + x + ".");
            Console.WriteLine("Variable y value: " + y + ".");

            // Displays sum of variables x and y.
            Console.WriteLine("Sum of variables: " + z);

            // Displaying variable value with a message.
            Console.WriteLine("Your age is: " + age + ".");
            Console.WriteLine("Your exact age is: " + ExactAge + "." + " And your height is: " + ExactHeight + "cm.");

            // Displaying boolean value with a message.
            Console.WriteLine("Are you alive?: " + IsAlive);
            Console.WriteLine("Are you alive now?: " + IsNotAlive);

            // Displaying single character value.
            Console.WriteLine("Your symbol is: " + symbol);

            // Reads user input characters.
            Console.ReadKey();
        }
    }
}
