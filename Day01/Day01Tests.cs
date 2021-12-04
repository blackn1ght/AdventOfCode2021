using NUnit.Framework;

namespace AdventOfCode2021.Day01
{
    [TestFixture]
    public class Day01Tests : TestBase
    {
        public Day01Tests() : base(1)
        {
        }
        
        [Test]
        public override void Part1_PlayerInput()
        {
            var day = new Day01(InputLines);

            var answer = day.Part1();

            Assert.AreEqual(1502, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var day = new Day01(ExampleLines);

            var answer = day.Part1();

            Assert.AreEqual(7, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var day = new Day01(InputLines);

            var answer = day.Part2();

            Assert.AreEqual(1538, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var day = new Day01(ExampleLines);

            var answer = day.Part2();

            Assert.AreEqual(5, answer);
        }
    }
}