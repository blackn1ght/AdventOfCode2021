using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Utilities;
using NUnit.Framework;

namespace AdventOfCode2021
{
    [TestFixture]
    public class Day02
    {
        public class Instruction
        {
            public string Direction { get; set; }
            public int Value { get; set; }
        }

        private static IEnumerable<Instruction> GetInstructions()
        {
            return DayInputReader
                .Read(2)
                .Select(x => x.Split(' '))
                .Select(x => new Instruction
                {
                    Direction = x[0],
                    Value = int.Parse(x[1])
                });
        }

        [Test]
        public void Part1()
        {
            var instructions = GetInstructions();

            var position = 0;
            var depth = 0;

            foreach (var instruction in instructions)
            {
                switch (instruction.Direction)
                {
                    case "forward":
                        position += instruction.Value;
                        break;
                    case "up":
                        depth -= instruction.Value;
                        break;
                    case "down":
                        depth += instruction.Value;
                        break;
                }
            }

            var answer = position * depth;

            Assert.AreEqual(1488669, answer);
        }

        [Test]
        public void Part2()
        {
            var instructions = GetInstructions();

            var position = 0;
            var depth = 0;
            var aim = 0;

            foreach (var instruction in instructions)
            {
                switch (instruction.Direction)
                {
                    case "forward":
                        position += instruction.Value;
                        depth += (aim * instruction.Value);
                        break;
                    case "up":
                        aim -= instruction.Value;
                        break;
                    case "down":
                        aim += instruction.Value;
                        break;
                }
            }

            var answer = position * depth;

            Assert.AreEqual(1176514794, answer);
        }
    }
}