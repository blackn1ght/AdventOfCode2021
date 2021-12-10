using NUnit.Framework;

namespace AdventOfCode2021.Day09
{
    [TestFixture]
    public class SmokeBasinChallengeTests : TestBase
    {
        public SmokeBasinChallengeTests() : base(9)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new SmokeBasinChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(550, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new SmokeBasinChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(15, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new SmokeBasinChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(1100682, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new SmokeBasinChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(1134, answer);
        }
    }
}
