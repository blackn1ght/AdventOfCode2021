using System.IO;
using NUnit.Framework;

namespace AdventOfCode2021
{
    [TestFixture]
    public abstract class TestBase
    {
        protected readonly string[] InputLines;
        protected readonly string[] ExampleLines;

        protected TestBase(int day)
        {
            InputLines = ReadInput(day);
            ExampleLines = ReadExample(day);
        }

        [Test]
        public abstract void Part1_PlayerInput();

        [Test]
        public abstract void Part1_ExampleInput();

        [Test]
        public abstract void Part2_PlayerInput();

        [Test]
        public abstract void Part2_ExampleInput();

        private static string[] ReadInput(int day)
        {
            return ReadFile(day, "input.txt");
        }

        private static string[] ReadExample(int day)
        {
            return ReadFile(day, "example.txt");
        }

        private static string[] ReadFile(int day, string filename)
        {
            var file = "";
            var filepath = $"Day{day.ToString().PadLeft(2, '0')}/{filename}";

            using (var reader = new StreamReader(filepath))
            {
                file = reader.ReadToEnd();
            }

            return file.Split("\r\n");
        }
    }
}
