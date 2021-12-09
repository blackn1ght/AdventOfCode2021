using System;
using NUnit.Framework;

namespace AdventOfCode2021.Day08
{
    [TestFixture]
    public class SevenSegmentSearchChallengeTests : TestBase
    {
        public SevenSegmentSearchChallengeTests() : base(8)
        {
        }

        [Test]
        public override void Part1_PlayerInput()
        {
            var challenge = new SevenSegmentSearchChallenge(InputLines);

            var answer = challenge.Part1();

            Assert.AreEqual(274, answer);
        }

        [Test]
        public override void Part1_ExampleInput()
        {
            var challenge = new SevenSegmentSearchChallenge(ExampleLines);

            var answer = challenge.Part1();

            Assert.AreEqual(26, answer);
        }

        [Test]
        public override void Part2_PlayerInput()
        {
            var challenge = new SevenSegmentSearchChallenge(InputLines);

            var answer = challenge.Part2();

            Assert.AreEqual(1012089, answer);
        }

        [Test]
        public override void Part2_ExampleInput()
        {
            var challenge = new SevenSegmentSearchChallenge(ExampleLines);

            var answer = challenge.Part2();

            Assert.AreEqual(61229, answer);
        }
    }
}
