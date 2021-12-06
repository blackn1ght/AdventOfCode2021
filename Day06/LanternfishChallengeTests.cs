using NUnit.Framework;

namespace AdventOfCode2021.Day06
{
    [TestFixture]
    public class LanternfishChallengeTests : TestBase
    {
        public LanternfishChallengeTests() : base(6)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new LanternfishChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(386640, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new LanternfishChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(5934, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new LanternfishChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(1733403626279, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new LanternfishChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(26984457539, answer);
        }
    }
}
