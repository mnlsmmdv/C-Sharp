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

            /*
            // Displaying variable values.
            Console.WriteLine("Variable x value: " + x + ".");
            Console.WriteLine("Variable y value: " + y + ".");
            */

            /*
            // Displays sum of variables x and y.
            Console.WriteLine("Sum of variables: " + z);
            */

            // Reads user input characters.
            Console.ReadKey();
        }
    }
}
