using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { '1', '3', '5', 'a', '7', '9', 'b','0', 'c' };
            var numbers = new List<int>();
            string str = string.Empty;


            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array

            foreach(var character in arr)
            {
                try
                {
                    str = character.ToString();
                    int num = int.Parse(str);
                    numbers.Add(num);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Unable to parse {character}");
                    Console.WriteLine(ex.Message);
                }
                

            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
