using NUnit.Framework;

namespace AdventOfCode2021.Day11
{
    [TestFixture]
    public class DumboOctopusChallengeTests : TestBase
    {
        public DumboOctopusChallengeTests() : base(11)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new DumboOctopusChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(1732, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new DumboOctopusChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(1656, answer);
        }

        [TestCase(2, 35)]
        [TestCase(10, 204)]
        [TestCase(100, 1656)]
        public void Part1_WithCustomSteps_ExampleInput(int steps, int expectedFlashes)
        {
            var challenge = new DumboOctopusChallenge(ExampleLines);

            var answer = challenge.Part1(steps);

            Assert.AreEqual(expectedFlashes, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new DumboOctopusChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(290, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new DumboOctopusChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(195, answer);
        }
    }
}
