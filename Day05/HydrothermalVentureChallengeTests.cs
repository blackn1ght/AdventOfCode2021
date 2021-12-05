using NUnit.Framework;

namespace AdventOfCode2021.Day05
{
    [TestFixture]
    public class HydrothermalVentureChallengeTests : TestBase
    {
        public HydrothermalVentureChallengeTests() : base(5)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new HydrothermalVentureChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(6564, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new HydrothermalVentureChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(5, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new HydrothermalVentureChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(19172, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new HydrothermalVentureChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(12, answer);
        }
    }
}
