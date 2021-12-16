using NUnit.Framework;

namespace AdventOfCode2021.Day12
{
    public class PassagePathingChallengeTests : TestBase
    {
        public PassagePathingChallengeTests() : base(12)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new PassagePathingChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(4659, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new PassagePathingChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(10, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new PassagePathingChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(148962, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new PassagePathingChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(36, answer);
        }
    }
}
