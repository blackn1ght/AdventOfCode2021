using System;
using System.Linq;
using AdventOfCode2021.Utilities;
using NUnit.Framework;

namespace AdventOfCode2021
{
    [TestFixture]
    public class Day03
    {
        [Test]
        public void Part1()
        {
            var diagnosticLines = DayInputReader.Read(3).ToList();
            var lineCount = diagnosticLines.Count;
            var lineLength = diagnosticLines[0].Length;

            var gammaRate = "";

            for (var i = 0; i < lineLength; i++)
            {
                var zeroes = diagnosticLines.Sum(line => line[i] == '0' ? 1 : 0);

                gammaRate += (zeroes > (lineCount / 2)) ? "0" : "1";
            }

            static char FlipBit(char input)
            {
                return input switch
                {
                    '0' => '1',
                    '1' => '0',
                    _ => input
                };
            }

            var epsilonRate = gammaRate
                .Select(FlipBit)
                .Aggregate("", (total, current) => $"{total}{current}");

            var gammaNumber = Convert.ToInt32(gammaRate, 2);
            var epsilonNumber = Convert.ToInt32(epsilonRate, 2);

            var answer = gammaNumber * epsilonNumber;

            Assert.AreEqual(2967914, answer);
        }

        [Test]
        public void Part2()
        {
            var diagnosticLines = DayInputReader.Read(3).ToList();
            var oxygenLines = diagnosticLines.ToList();
            var co2ScrubberLines = diagnosticLines.ToList();

            var position = 0;

            while (oxygenLines.Count > 1)
            {
                var zeroes = oxygenLines.Sum(line => line[position] == '0' ? 1 : 0);

                var commonValue = zeroes > (oxygenLines.Count / 2) ? '0' : '1';

                oxygenLines = oxygenLines.Where(line => line[position] == commonValue).ToList();

                position++;
            }

            position = 0;

            while (co2ScrubberLines.Count > 1)
            {
                var zeroes = co2ScrubberLines.Sum(line => line[position] == '0' ? 1 : 0);

                var commonValue = zeroes > (co2ScrubberLines.Count / 2) ? '1' : '0';

                co2ScrubberLines = co2ScrubberLines.Where(line => line[position] == commonValue).ToList();

                position++;
            }

            var oxygenGeneratorRating = Convert.ToInt32(oxygenLines[0], 2);
            var co2ScrubberRating = Convert.ToInt32(co2ScrubberLines[0], 2);
            var answer = oxygenGeneratorRating * co2ScrubberRating;

            Assert.AreEqual(7041258, answer);
        }
    }
}