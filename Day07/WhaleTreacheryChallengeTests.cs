using NUnit.Framework;

namespace AdventOfCode2021.Day07
{
    [TestFixture]
    public class WhaleTreacheryChallengeTests : TestBase
    {
        public WhaleTreacheryChallengeTests() : base(7)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new WhaleTreacheryChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(348996, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new WhaleTreacheryChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(37, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new WhaleTreacheryChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(98231647, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new WhaleTreacheryChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(168, answer);
        }
    }
}
