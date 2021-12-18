using NUnit.Framework;

namespace AdventOfCode2021.Day13
{
    [TestFixture]
    public class TransparentOrigamiChallengeTests : TestBase
    {
        public TransparentOrigamiChallengeTests() : base(13)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new TransparentOrigamiChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(765, answer);
        }
        
        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new TransparentOrigamiChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(17, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new TransparentOrigamiChallenge(InputLines);

            Assert.DoesNotThrow(() => challenge.Part2());
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new TransparentOrigamiChallenge(ExampleLines);

            Assert.DoesNotThrow(() => challenge.Part2());
        }
    }
}
