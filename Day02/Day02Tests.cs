using NUnit.Framework;

namespace AdventOfCode2021.Day02
{
    [TestFixture]
    public class Day02Tests : TestBase
    {
        public Day02Tests() : base(2)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var day = new Day02(InputLines);

            var answer = day.Part1();

            Assert.AreEqual(1488669, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var day = new Day02(ExampleLines);

            var answer = day.Part1();

            Assert.AreEqual(150, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var day = new Day02(InputLines);

            var answer = day.Part2();

            Assert.AreEqual(1176514794, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var day = new Day02(ExampleLines);

            var answer = day.Part2();

            Assert.AreEqual(900, answer);
        }
    }
}