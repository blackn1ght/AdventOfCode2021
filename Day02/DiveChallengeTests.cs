using NUnit.Framework;

namespace AdventOfCode2021.Day02
{
    [TestFixture]
    public class DiveChallengeTests : TestBase
    {
        public DiveChallengeTests() : base(2)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new DiveChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(1488669, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new DiveChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(150, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new DiveChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(1176514794, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new DiveChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(900, answer);
        }
    }
}