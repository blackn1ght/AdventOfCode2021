using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day11
{
    public class DumboOctopusChallenge
    {
        private int[,] _octopuses;
        private readonly int _gridSize;

        public DumboOctopusChallenge(IReadOnlyList<string> inputData)
        {
            _gridSize = inputData.Count;
            var octopuses = new int[_gridSize, _gridSize];

            for (var y = 0; y < _gridSize; y++)
            {
                for (var x = 0; x < _gridSize; x++)
                {
                    octopuses[y, x] = int.Parse(inputData[y][x].ToString());
                }
            }

            _octopuses = octopuses;
        }

        private int UpdateNeighbours(int y, int x, HashSet<(int Y, int X)> flashedOctopuses)
        {
            var adjacentOctopuses = CoordinateHelper.GetAdjacentOctopusCoordinates(y, x)
                .Where(adj => flashedOctopuses.Contains(adj) == false);
            var flashes = 0;

            foreach (var adjacentOctopus in adjacentOctopuses)
            {
                _octopuses[adjacentOctopus.Y, adjacentOctopus.X]++;

                if (_octopuses[adjacentOctopus.Y, adjacentOctopus.X] > 9)
                {
                    _octopuses[adjacentOctopus.Y, adjacentOctopus.X] = 0;
                    flashes++;
                    flashedOctopuses.Add(adjacentOctopus);
                    flashes += UpdateNeighbours(adjacentOctopus.Y, adjacentOctopus.X, flashedOctopuses);
                }
            }

            return flashes;
        }

        private void IncrementEachOctopusEnergyLevel()
        {
            for (var y = 0; y < _gridSize; y++)
            {
                for (var x = 0; x < _gridSize; x++)
                {
                    _octopuses[y, x]++;
                }
            }
        }

        private int FlashOctopusesAndIncrementNeighboursEnergy()
        {
            var flashes = 0;
            var flashedOctopuses = new HashSet<(int Y, int X)>();

            for (var y = 0; y < _gridSize; y++)
            {
                for (var x = 0; x < _gridSize; x++)
                {
                    if (_octopuses[y, x] > 9)
                    {
                        flashes++;
                        _octopuses[y, x] = 0;
                        flashedOctopuses.Add(new(y, x));
                        flashes += UpdateNeighbours(y, x, flashedOctopuses);
                    }
                }
            }

            return flashes;
        }


        private int TakeStepAndGetFlashCount()
        {
            IncrementEachOctopusEnergyLevel();
            var flashes = FlashOctopusesAndIncrementNeighboursEnergy();

            return flashes;
        }

        private bool AreAllOctopusesFlashing()
        {
            for (var y = 0; y < _gridSize; y++)
            {
                for (var x = 0; x < _gridSize; x++)
                {
                    if (_octopuses[y, x] != 0) return false;
                }
            }

            return true;
        }

        public int Part1(int steps = 100)
        {
            var flashes = 0;

            for (var step = 0; step < steps; step++)
            {
                flashes += TakeStepAndGetFlashCount();
            }

            return flashes;
        }

        public int Part2()
        {
            var steps = 0;

            while (AreAllOctopusesFlashing() == false)
            {
                TakeStepAndGetFlashCount();
                steps++;
            }

            return steps;
        }
    }
}
