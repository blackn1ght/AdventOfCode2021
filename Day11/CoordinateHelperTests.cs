using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdventOfCode2021.Day11
{
    [TestFixture]
    public class CoordinateHelperTests
    {
        [Test]
        public void GetAdjacentNeighbours_TopLeftCorner_ShouldReturnCorrectCoordinates()
        {
            var x = 0;
            var y = 0;

            var expectedOutputs = new List<(int Y, int X)>
            {
                new(0, 1),
                new(1, 0),
                new(1, 1)
            };

            var neighbours = CoordinateHelper.GetAdjacentOctopusCoordinates(y, x);

            Assert.AreEqual(expectedOutputs.Count, neighbours.Count());
            foreach (var expectedOutput in expectedOutputs)
            {
                Assert.IsTrue(neighbours.Contains(expectedOutput));
            }
        }

        [Test]
        public void GetAdjacentNeighbours_TopRightCorner_ShouldReturnCorrectCoordinates()
        {
            var x = 9;
            var y = 0;

            var expectedOutputs = new List<(int Y, int X)>
            {
                new(0, 8),
                new(1, 8),
                new(1, 9)
            };

            var neighbours = CoordinateHelper.GetAdjacentOctopusCoordinates(y, x);

            Assert.AreEqual(expectedOutputs.Count, neighbours.Count());
            foreach (var expectedOutput in expectedOutputs)
            {
                Assert.IsTrue(neighbours.Contains(expectedOutput));
            }
        }

        [Test]
        public void GetAdjacentNeighbours_BottomLeftCorner_ShouldReturnCorrectCoordinates()
        {
            var x = 0;
            var y = 9;

            var expectedOutputs = new List<(int Y, int X)>
            {
                new(8, 0),
                new(8, 1),
                new(9, 1)
            };

            var neighbours = CoordinateHelper.GetAdjacentOctopusCoordinates(y, x);

            Assert.AreEqual(expectedOutputs.Count, neighbours.Count());
            foreach (var expectedOutput in expectedOutputs)
            {
                Assert.IsTrue(neighbours.Contains(expectedOutput));
            }
        }


        [Test]
        public void GetAdjacentNeighbours_BottomRightCorner_ShouldReturnCorrectCoordinates()
        {
            var x = 9;
            var y = 9;

            var expectedOutputs = new List<(int Y, int X)>
            {
                new(8, 8),
                new(8, 9),
                new(9, 8)
            };

            var neighbours = CoordinateHelper.GetAdjacentOctopusCoordinates(y, x);

            Assert.AreEqual(expectedOutputs.Count, neighbours.Count());
            foreach (var expectedOutput in expectedOutputs)
            {
                Assert.IsTrue(neighbours.Contains(expectedOutput));
            }
        }

        [Test]
        public void GetAdjacentNeighbours_MiddleOfBoard_ShouldReturnCorrectCoordinates()
        {
            var x = 5;
            var y = 5;

            var expectedOutputs = new List<(int Y, int X)>
            {
                new(4, 4),
                new(4, 5),
                new(4, 6),
                new(5, 4),
                new(5, 6),
                new(6, 4),
                new(6, 5),
                new(6, 6)
            };

            var neighbours = CoordinateHelper.GetAdjacentOctopusCoordinates(y, x);

            Assert.AreEqual(expectedOutputs.Count, neighbours.Count());
            foreach (var expectedOutput in expectedOutputs)
            {
                Assert.IsTrue(neighbours.Contains(expectedOutput));
            }
        }
    }
}
