using System;
using System.Diagnostics;

namespace Houk_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new array, stopwatch, and random object
            char[] charArray = new char[50];
            Stopwatch sw = new Stopwatch();
            Random rand = new Random();

            // Start the stopwatch
            sw.Start();

            // Loop through the array and add a random character
            int i = 0;

            while (i < charArray.Length)
            {
                //Generate a random uppercase char
                char randomChar = (char)rand.Next('A', 'Z' + 1);
                //Check if the char doesn't exist and add it
                if (Array.IndexOf(charArray, randomChar) == -1)
                {
                    charArray[i] = randomChar;
                    i++;
                }

                //Generate a random lowercase char
                randomChar = (char)rand.Next('a', 'z' + 1);
                //Check if the char doesn't exist and add it
                if (Array.IndexOf(charArray, randomChar) == -1)
                {
                    charArray[i] = randomChar;
                    i++;
                }
            }

            // Stop the stopwatch and print the time elapsed
            sw.Stop();
            Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
            Console.WriteLine(charArray);
        }
    }
}