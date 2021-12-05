using NUnit.Framework;

namespace AdventOfCode2021.Day03
{
    public class BinaryDiagnosticChallengeTests : TestBase
    {
        public BinaryDiagnosticChallengeTests() : base(3)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new BinaryDiagnosticChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(2967914, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new BinaryDiagnosticChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(198, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new BinaryDiagnosticChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(7041258, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new BinaryDiagnosticChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(230, answer);
        }
    }
}
