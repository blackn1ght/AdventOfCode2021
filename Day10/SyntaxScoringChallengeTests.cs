using NUnit.Framework;

namespace AdventOfCode2021.Day10
{
    [TestFixture]
    public class SyntaxScoringChallengeTests : TestBase
    {
        public SyntaxScoringChallengeTests() : base(10)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new SyntaxScoringChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(319233, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new SyntaxScoringChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(26397, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new SyntaxScoringChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(1118976874, answer);
        }
        
        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new SyntaxScoringChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(288957, answer);
        }
    }
}
