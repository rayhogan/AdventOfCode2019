using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    public static class Helper
    {
        public static string[] ParseInput(string location)
        {
            string[] input = System.IO.File.ReadAllLines(location);

            return input;
        }

        public static string ParseSingleLineInput(string location)
        {
            string input = System.IO.File.ReadAllText(location);

            return input;
        }

    }
}
