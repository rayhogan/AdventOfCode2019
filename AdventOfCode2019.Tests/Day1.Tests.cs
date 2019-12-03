using NUnit.Framework;
using AdventOfCode2019;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Day1Part1()
        {
            Assert.AreEqual(AdventOfCode2019.Day1.CalculateFuel(12), 2);
            Assert.AreEqual(AdventOfCode2019.Day1.CalculateFuel(14), 2);
            Assert.AreEqual(AdventOfCode2019.Day1.CalculateFuel(1969), 654);
            Assert.AreEqual(AdventOfCode2019.Day1.CalculateFuel(100756), 33583);
        }

        [Test]
        public void Day1Part2()
        {
            Assert.AreEqual(AdventOfCode2019.Day1.CalculateFuelEnhanced(14), 2);
            Assert.AreEqual(AdventOfCode2019.Day1.CalculateFuelEnhanced(1969), 966);
            Assert.AreEqual(AdventOfCode2019.Day1.CalculateFuelEnhanced(100756), 50346);
        }
    }
}