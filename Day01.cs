using System.Linq;
using AdventOfCode2021.Utilities;
using NUnit.Framework;

namespace AdventOfCode2021
{
    [TestFixture]
    public class Day01
    {
        [Test]
        public void Part1()
        {
            var depths = DayInputReader.Read(1).Select(int.Parse).ToList();

            var increments = 0;

            for (var i = 1; i < depths.Count; i++)
            {
                var previous = depths[i - 1];
                var current = depths[i];

                if (current > previous) increments++;
            }

            Assert.AreEqual(1502, increments);
        }

        [Test]
        public void Part2()
        {
            var depths = DayInputReader.Read(1).Select(int.Parse).ToList();

            var increments = 0;

            for (var i = 1; i <= depths.Count; i++)
            {
                var previousWindowTotal = depths.Skip(i - 1).Take(3).Sum();
                var currentWindowTotal = depths.Skip(i).Take(3).Sum();

                if (currentWindowTotal > previousWindowTotal) increments++;
            }

            Assert.AreEqual(1538, increments);
        }
    }
}