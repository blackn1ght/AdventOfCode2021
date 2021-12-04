using NUnit.Framework;

namespace AdventOfCode2021.Day04
{
    [TestFixture]
    public class Day04Tests : TestBase
    {
        public Day04Tests() : base(4)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var day = new Day04(InputLines);

            var answer = day.Part1();

            Assert.AreEqual(72770, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var day = new Day04(ExampleLines);

            var answer = day.Part1();

            Assert.AreEqual(4512, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var day = new Day04(InputLines);

            var answer = day.Part2();

            Assert.AreEqual(13912, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var day = new Day04(ExampleLines);

            var answer = day.Part2();

            Assert.AreEqual(1924, answer);
        }
    }
}