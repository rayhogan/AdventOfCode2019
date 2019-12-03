using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2019
{
    public static class Day2
    {
        public static void Run()
        {
            string input = Helper.ParseSingleLineInput(@"Inputs\\Day2.txt");
            Part1(input);
            Part2(input);
        }

        public static void Part1(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Part I");
            Console.ForegroundColor = ConsoleColor.White;

            List<int> inputCollection = GenerateCollection(input);

            inputCollection[1] = 12;
            inputCollection[2] = 2;


            int result = ProcessOpCodes(inputCollection.ToList());

            Console.WriteLine("Value a position 0: "+result);
        }

        public static void Part2(string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Part II");
            Console.ForegroundColor = ConsoleColor.White;

            List<int> inputCollection = GenerateCollection(input);

            int haltWhen = 19690720;

            inputCollection[1] = 0;
            inputCollection[2] = 0;

            int noun = 0;
            int verb = 0;

            for(int i=0;i<99;i++)
            {
                for(int j=0;j<99;j++)
                {
                    inputCollection[1] = i;
                    inputCollection[2] = j;

                    int result = ProcessOpCodes(inputCollection.ToList());

                    if (result == haltWhen)
                    {
                        noun = i;
                        verb = j;
                        i = 99;
                        j = 99;
                    }

                }
            }

            int sum = 100 * noun + verb;

            Console.WriteLine("100 * " + noun + " + " + verb + ": " + sum);
        }

        public static List<int> GenerateCollection(string input)
        {
            List<int> collection = new List<int>();

            string[] split = input.Split(",");

            foreach(string s in split)
            {
                collection.Add(Int32.Parse(s));
            }

            return collection;
        }

        public static int ProcessOpCodes(List<int> inputCollection)
        {
            for (int i = 0; i < inputCollection.Count; i += 4)
            {
                // Check if we should halt
                if (inputCollection[i] == 99)
                    i = inputCollection.Count;
                else
                {
                    int position1 = inputCollection[i + 1];
                    int position2 = inputCollection[i + 2];
                    int position3 = inputCollection[i + 3];

                    if (inputCollection[i] == 1)
                    {
                        inputCollection[position3] = inputCollection[position1] + inputCollection[position2];
                    }
                    else if (inputCollection[i] == 2)
                    {
                        inputCollection[position3] = inputCollection[position1] * inputCollection[position2];
                    }
                    else
                    {
                        throw new Exception("Unknown Value, Captain!");
                    }
                }
            }

            return inputCollection[0];
        }

    }
}
