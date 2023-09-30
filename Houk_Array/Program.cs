using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Houk_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new array, stopwatch, and random object
            char[] charArray = new char[50];
            Stopwatch sw = new Stopwatch();
            Random r = new Random();

            // Start the stopwatch
            sw.Start();

            // Loop through the array and add a random character
            int i = 0;

            while (i < charArray.Length)
            {
                //Generate a random char
                char randomChar = (char)r.Next(65, 123);

                //Check if randomChar is an alpha character, if not change it to one
                if (randomChar > 90 && randomChar < 97) 
                    randomChar = (char)(randomChar + 7);

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