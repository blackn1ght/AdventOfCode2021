using NUnit.Framework;

namespace AdventOfCode2021.Day04
{
    [TestFixture]
    public class GiantSquidChallengeTests : TestBase
    {
        public GiantSquidChallengeTests() : base(4)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new GiantSquidChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(72770, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new GiantSquidChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(4512, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new GiantSquidChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(13912, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new GiantSquidChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(1924, answer);
        }
    }
}