using NUnit.Framework;

namespace AdventOfCode2021.Day01
{
    [TestFixture]
    public class SonarSweepChallengeTests : TestBase
    {
        public SonarSweepChallengeTests() : base(1)
        {
        }
        
        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new SonarSweepChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(1502, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new SonarSweepChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(7, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var day = new SonarSweepChallenge(InputLines);

            var answer = day.Part2();

            Assert.AreEqual(1538, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new SonarSweepChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(5, answer);
        }
    }
}