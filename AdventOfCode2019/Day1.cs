using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    public static class Day1
    {
        public static void Run()
        {
            string[] input = Helper.ParseInput(@"Inputs\\Day1.txt");
            Part1(input);
            Part2(input);
        }

        public static void Part1(string[] input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Part I");
            Console.ForegroundColor = ConsoleColor.White;

            int result = 0;

            foreach(string s in input)
            {
                result += CalculateFuel(Int32.Parse(s));
            }

            Console.WriteLine("Fuel Required: "+result);
        }

        public static void Part2(string[] input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Part II");
            Console.ForegroundColor = ConsoleColor.White;

            int result = 0;

            foreach (string s in input)
            {
                result += CalculateFuelEnhanced(Int32.Parse(s));
            }

            Console.WriteLine("Actual Fuel: "+result);
        }

        public static int CalculateFuel(int mass)
        {
            return (mass / 3) - 2;
        }

        public static int CalculateFuelEnhanced(int mass)
        {
            int totalFuel = 0;

            int calculation = (mass / 3) - 2;

            if (calculation > 0)
            {
                totalFuel += calculation;
                return totalFuel += CalculateFuelEnhanced(calculation);
            }

            return totalFuel;
        }
    }
}
