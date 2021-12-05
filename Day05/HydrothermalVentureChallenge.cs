using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day05
{
    public class Line
    {
        public Tuple<int, int> Start { get; set; }
        public Tuple<int, int> End { get; set; }
    }

    public class HydrothermalVentureChallenge
    {
        private readonly IReadOnlyList<Line> _lines;

        public HydrothermalVentureChallenge(IReadOnlyList<string> inputLines)
        {
            _lines = inputLines
                .Select(ParseInputLine)
                .ToList();
        }

        private static Line ParseInputLine(string inputLine)
        {
            var parts = inputLine.Split(' ');

            static Tuple<int, int> ParseCoordinates(string part)
            {
                var coordinates = part
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                return new Tuple<int, int>(coordinates[0], coordinates[1]);
            }

            return new Line
            {
                Start = ParseCoordinates(parts[0]),
                End = ParseCoordinates(parts[2])
            };
        }

        private (int width, int height) GetGridDimensions()
        {
            var startMaxWidth = _lines.Max(l => l.Start.Item1);
            var startMaxHeight = _lines.Max(l => l.Start.Item2);

            return (startMaxWidth, startMaxHeight);
        }

        private List<List<int>> GenerateGrid()
        {
            var (width, height) = GetGridDimensions();

            var grid = new List<List<int>>();

            for (var y = 0; y <= height; y++)
            {
                grid.Add(Enumerable
                    .Range(0, width + 1)
                    .Select(n => 0)
                    .ToList());
            }

            return grid;
        }

        private int GetNumberOfMultipleOverlaps(bool includeDiagonal)
        {
            var grid = GenerateGrid();

            static (int low, int high) GetLowAndHigh(int n1, int n2)
            {
                return n1 > n2 ? (n2, n1) : (n1, n2);
            }

            foreach (var line in _lines)
            {
                var (x1, y1) = line.Start;
                var (x2, y2) = line.End;

                if (x1 == x2)
                {
                    var (yStart, yEnd) = GetLowAndHigh(y1, y2);

                    for (var y = yStart; y <= yEnd; y++)
                    {
                        grid[y][x1]++;
                    }
                }
                else if (y1 == y2)
                {
                    var (xStart, xEnd) = GetLowAndHigh(x1, x2);

                    for (var x = xStart; x <= xEnd; x++)
                    {
                        grid[y1][x]++;
                    }
                }
                else if (includeDiagonal)
                {
                    var (yStart, yEnd) = GetLowAndHigh(y1, y2);

                    var diff = yEnd - yStart;

                    var counter = 0;
                    var y = y1;
                    var x = x1;

                    while (counter <= diff)
                    {
                        grid[y][x]++;

                        y = y1 > y2 ? y - 1 : y + 1;
                        x = x1 > x2 ? x - 1 : x + 1;
                        counter++;
                    }
                }
            }

            return grid.Sum(x => x.Sum(y => y >= 2 ? 1 : 0));
        }

        public int Part1()
        {
            return GetNumberOfMultipleOverlaps(false);
        }

        public int Part2()
        {
            return GetNumberOfMultipleOverlaps(true);
        }
    }
}
