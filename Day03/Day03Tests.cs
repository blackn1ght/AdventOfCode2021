using NUnit.Framework;

namespace AdventOfCode2021.Day03
{
    public class Day03Tests : TestBase
    {
        public Day03Tests() : base(3)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var day = new Day03(InputLines);

            var answer = day.Part1();

            Assert.AreEqual(2967914, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var day = new Day03(ExampleLines);

            var answer = day.Part1();

            Assert.AreEqual(198, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var day = new Day03(InputLines);

            var answer = day.Part2();

            Assert.AreEqual(7041258, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var day = new Day03(ExampleLines);

            var answer = day.Part2();

            Assert.AreEqual(230, answer);
        }
    }
}
